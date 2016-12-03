using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterApiCallerForm
{
    public partial class ErrorMgmt : UserControl
    {
        SemnanEntities3 db = new SemnanEntities3();
        public ErrorMgmt()
        {
            InitializeComponent();
        }

        private void ErrorMgmt_Load(object sender, EventArgs e)
        {
            LoadErrors();
        }

        private void LoadErrors()
        {
            dgvErrors.Rows.Clear();
            var errors_service = Publics.AnbarStatus.AnbarsSentNotRegistered(db)
                .Select(x => new { title = x.output_result, farsi = x.error_farsi }).Distinct().OrderBy(x=>x.title).ToList();

            foreach (var error in errors_service)
            {
                if (error != null)
                    dgvErrors.Rows.Add(error.title, error.farsi);
                else dgvErrors.Rows.Add("null", "");
            }
        }

        private void dgvErrors_SelectionChanged(object sender, EventArgs e)
        {
            lblError.Text=tbNewFarsi.Text = string.Empty;
            if (dgvErrors.SelectedRows.Count > 0)
            {
                var errorRow = dgvErrors.SelectedRows[0];
                lblError.Text = (string)errorRow.Cells[0].Value;
                tbNewFarsi.Text = (string)errorRow.Cells[1].Value;
            }
            
                

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Loading loading = new Loading();
            loading.lblLoading.Text = "در حال ذخیره سازی";
            loading.lblSrart.Text = loading.lblTime.Text = loading.lblEnd.Text =  "";
            loading.btnStop.Enabled=false;
            loading.Show();
            int selected = dgvErrors.SelectedRows[0].Index;
            var rows = db.Anbars.Where(x => x.output_result == lblError.Text).Select(x => x);
            int i = 0;
            foreach (var row in rows)
            {
                i++;
                loading.lblLoading.Text = "در حال ذخیره سازی "+i;
                Application.DoEvents();
                row.error_farsi = tbNewFarsi.Text;
            }
            db.SaveChanges();
            LoadErrors();
            dgvErrors.Rows[selected].Selected = true;
            loading.lblLoading.Text = "تعداد بروز شده " + i;
            loading.btnClose.Enabled = true;
            loading.Close();
            
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Loading loading = new Loading();
            loading.lblLoading.Text = "در حال ذخیره سازی";
            loading.lblSrart.Text = loading.lblTime.Text = loading.lblEnd.Text = "";
            loading.btnStop.Enabled = false;
            loading.Show();
            foreach (DataGridViewRow row_ in dgvErrors.Rows)
            {
                if (row_.Cells["current"].Value != null)
                {
                    string value = (string)row_.Cells["error"].Value;
                    var rows = db.Anbars.Where(x => x.output_result ==value).Select(x => x);
                    int i = 0;
                    foreach (var row in rows)
                    {
                        i++;
                        loading.lblLoading.Text = "در حال ذخیره سازی " + i;
                        Application.DoEvents();
                        row.error_farsi = row_.Cells["current"].Value.ToString();
                    }
                    db.SaveChanges();
                    LoadErrors();


                    loading.lblLoading.Text = "تعداد بروز شده " + i;
                    loading.btnClose.Enabled = true;
                }
            }
        }
    }
}
