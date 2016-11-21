using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RegisterApiCallerForm
{
    public partial class DataMgmt : UserControl
    {
        Form1 form1;
        SemnanEntities3 db = new SemnanEntities3();
        Loading loading;
        List<Anbar> queryList;
        IQueryable<Anbar> query;
        public DataMgmt(Form1 f)
        {
            InitializeComponent();
            form1 = f;
            cbRegisterStatus.SelectedIndex = 0;
            cbSendStatus.SelectedIndex = 0;
            
            dtpFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            dtpTo.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 0, 0);


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            queryList = null;
            query = null;
            query = db.Anbars.Select(x => x)
                .OrderBy(x => x.ID)
                .Skip(string.IsNullOrWhiteSpace(tbFrom.Text) ? 0 : int.Parse(tbFrom.Text) - 1)
                .Take(string.IsNullOrWhiteSpace(tbTo.Text) ? db.Anbars.Select(z => z).Count() : int.Parse(tbTo.Text))
                .Where(q => cbTag.Text == string.Empty ? true : q.tag == cbTag.Text)
                .Where(x => dtpFrom.Checked ? (x.last_sent >= dtpFrom.Value) : true)
                .Where(x => dtpTo.Checked ? (x.last_sent <= dtpTo.Value) : true)
               ;

            if (cbSendStatus.SelectedIndex == 1) query = query.Intersect(Publics.AnbarStatus.AnbarsSent(db));
            else if (cbSendStatus.SelectedIndex == 2) query = query.Intersect(Publics.AnbarStatus.AnbarsNotSent(db));

            if (cbRegisterStatus.SelectedIndex == 1) query = query.Intersect(Publics.AnbarStatus.AnbarsRegistered(db));
            else if (cbRegisterStatus.SelectedIndex == 2) query = query.Intersect(Publics.AnbarStatus.AnbarsNotRegistered(db));

            if (cberrorType.Text == "null") query = query.Intersect(Publics.AnbarStatus.AnbarsSentNotRegistered(db)).Where(x => x.output_result == null);
            else if (cberrorType.Text != "select") query = query.Where(y => y.output_result == cberrorType.Text || y.error == cberrorType.Text);

            queryList = query.ToList();
            dgv.DataSource = queryList;
            btnCount.PerformClick();
        }


        private void DataMgmt_Load(object sender, EventArgs e)
        {
            var errors = Publics.AnbarStatus.AnbarsSentNotRegistered(db)
                .Select(x => x.output_result ).Distinct().Union(
                Publics.AnbarStatus.AnbarsWithError(db)
                .Select(x => x.error).Distinct()
                ).ToList();

            cberrorType.Items.Add("select");

            foreach (var error in errors)
            {
                if (error != null)
                    cberrorType.Items.Add(error);
                else cberrorType.Items.Add("null");
            }

            

            cbTag.Items.Add(string.Empty);
            foreach (var tag in db.Anbars.Select(x => x.tag).Distinct().ToList())
            {
                if (tag != null)
                    cbTag.Items.Add(tag);
            }

            cberrorType.SelectedIndex = 0;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Publics.ButtonLoading(btnSearch_Click);
            var DBitems = queryList;
            Publics.ParallelSend(db, queryList, tbFrom.Text, btnSearch,tbParalel.Text);
            
        }
       
        private void btnCount_Click(object sender, EventArgs e)
        {
            lblCount.Text = dgv.Rows.Count.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ایا مطمئن هستید؟", "مورد برای پاکسازی" + queryList.Count.ToString(), MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                btnSearch.PerformClick();
                var itemsToReset = queryList;
                loading = new Loading();
                loading.Show();
                int i = 1;
                int all = itemsToReset.Count;
                foreach (Anbar item in itemsToReset)
                {

                    loading.lblLoading.Text = "در حال حذف " + i + " از " + all;
                    i++;
                    try
                    {
                        item.user_id = null;
                        item.api_key = null;
                        item.city = null;
                        item.company_name = null;
                        item.error = null;
                        item.full_address = null;
                        item.last_sent = null;
                        item.output_result = null;
                        item.province = null;
                        item.user_first_name = null;
                        item.user_last_name = null;
                        item.warehouse_id = null;
                        item.user_id = null;

                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);

                    }
                }
                db.SaveChanges();
                loading.Close();
                btnSearch.PerformClick();
            }
        }

        private void tbTag_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTag_Leave(object sender, EventArgs e)
        {


        }

        private void btnDataOwnerInfo_Click(object sender, EventArgs e)
        {
           
           
        }

        private void cbTag_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblExplain.Text = db.Anbars.Where(w => w.tag == cbTag.Text).Select(x => x.explain).DefaultIfEmpty(" ").FirstOrDefault();
            
        }

        private void btnErrorCount_Click(object sender, EventArgs e)
        {
            Publics.ButtonLoading(btnSearch_Click);
            new ErrorGroup(query,db).ShowDialog();
        }

        private void btnTagIndex_Click(object sender, EventArgs e)
        {
            var loading = new Loading();
            loading.Show();
            loading.lblLoading.Text = "در حال خواندن از پایگاه داده";
            List<Publics.DataReport> dataSource = new List<Publics.DataReport>();
            Publics.DataReport dataReport;

            foreach (var data in db.Anbars.Select(x => new { tag = x.tag, explain = x.explain }).Distinct().ToList())
            {
                Application.DoEvents();
                dataReport = new Publics.DataReport();
                dataReport.tag = data.tag;
                dataReport.explain = data.explain;
                dataReport.index = db.Anbars.ToList().IndexOf(db.Anbars.Where(x => x.tag == data.tag).First()) + 1;
                dataReport.count = db.Anbars.Where(x => x.tag == data.tag).Count();
                dataReport.sent = Publics.AnbarStatus.AnbarsSent(db).Where(x => x.tag == data.tag).Count();
                dataReport.registered = Publics.AnbarStatus.AnbarsRegistered(db).Where(x => x.tag == data.tag).Count();
                dataReport.error = Publics.AnbarStatus.AnbarsSentNotRegisteredOrError(db)
                   .Where(x => x.tag == data.tag).Count();
                dataSource.Add(dataReport);
            }     
          dgv.DataSource = dataSource;
          loading.Close();
        }

        private void btnGetRow_Click(object sender, EventArgs e)
        {
            Publics.GetRows(dgv, tbFrom, tbTo, db);
        }
        
        private void cbTag_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void chbFrom_CheckedChanged(object sender, EventArgs e)
        {
         
            
        }

        private void chbTo_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void cberrorType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Publics.ButtonLoading(btnSearch_Click);
            ExportToExcell(dgv);
            
        }

        private void ExportToExcell(DataGridView dgview)
        {
            
            Loading loading = new Loading();
            loading.lblLoading.Text = "در حال اکسل سازی";
            loading.lblTime.Text = "";
            loading.dataGridView1.Visible = false;
            loading.Show();
            DataSet ds = new DataSet();
            DataTable table = new DataTable("DataFromDGV");
            ds.Tables.Add(table);
            foreach (DataGridViewColumn col in dgview.Columns)
                table.Columns.Add(col.HeaderText, typeof(string));
            foreach (DataGridViewRow row in dgv.Rows)
            {
                Application.DoEvents();
                table.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    Application.DoEvents();
                    table.Rows[row.Index][cell.ColumnIndex] = cell.Value;
                    loading.lblLoading.Text = "در حال اکسلینگ ردیف " + row.Index;
                }
            }

            ExcelLibrary.DataSetHelper.CreateWorkbook(@"C:\Users\project\Desktop\MyExcelFile.xls", ds);
            loading.lblLoading.Text = "خروجی در مسیر دسکتاپ انجام شد";
            loading.btnClose.Enabled = true;
        }
        
    }
}
