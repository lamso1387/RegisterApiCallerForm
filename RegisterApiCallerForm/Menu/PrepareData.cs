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
    public partial class PrepareData : UserControl
    {
        Form1 form1;
        public PrepareData(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void btnSelectExcel_Click(object sender, EventArgs e)
        {

            LoadDGVFromExcel();
            
        }
     

        private void LoadDGVFromExcel()
        {
            openFileDialog1.Filter = "Only 97/2003 excel with one sheet|*.xls";
            openFileDialog1.ShowDialog();
            lblFileName.Text = openFileDialog1.FileName;

            ExcelLibrary.Office.Excel.Workbook excel_file = ExcelLibrary.Office.Excel.Workbook.Open(openFileDialog1.FileName);
            var worksheet = excel_file.Worksheets[0]; // assuming only 1 worksheet
            var cells = worksheet.Cells;

            if (CheckExcelHeaders(cells))
            {

                // add columns
                foreach (var header in cells.GetRow(cells.FirstRowIndex))
                {
                    dataGridView1.Columns.Add(header.Value.StringValue, header.Value.StringValue);
                }

                // add rows
                for (int rowIndex = cells.FirstRowIndex + 1; rowIndex <= cells.LastRowIndex; rowIndex++)
                {
                    ExcelLibrary.Office.Excel.Row file_row=cells.GetRow(rowIndex);

                    dataGridView1.Rows.Add(file_row.GetCell(0).Value, file_row.GetCell(1).Value, file_row.GetCell(2).Value, file_row.GetCell(3).Value, file_row.GetCell(4).Value,
                        file_row.GetCell(5).Value, file_row.GetCell(6).Value, file_row.GetCell(7).Value, file_row.GetCell(8).Value, file_row.GetCell(9).Value, file_row.GetCell(10).Value,
                        file_row.GetCell(11).Value, file_row.GetCell(12).Value, file_row.GetCell(13).Value, file_row.GetCell(14).Value, file_row.GetCell(15).Value, file_row.GetCell(16).Value,
                        file_row.GetCell(17).Value, file_row.GetCell(18).Value, file_row.GetCell(19).Value, file_row.GetCell(20).Value, file_row.GetCell(21).Value, file_row.GetCell(22).Value, file_row.GetCell(23).Value,
                        file_row.GetCell(24).Value, file_row.GetCell(25).Value, file_row.GetCell(26).Value, file_row.GetCell(27).Value, file_row.GetCell(28).Value, file_row.GetCell(29).Value, file_row.GetCell(30).Value
                        );
                }

            }
        }

        private bool CheckExcelHeaders(ExcelLibrary.Office.Excel.CellCollection cells)
        {
            string[] main_headers = { "address","tel","fname","etehadie","senf_id","family","raste","national_id","date","mobile",
                                        "co_national_id","name","postal_code","contractor_or_agent","type","activity_sector",
                                        "province_input","city_input","province","city","user_id","user_first_name","full_address",
                                        "warehouse_id","company_name","user_last_name","error","api_key","tag","last_sent","explain",
            "output_result"};
            foreach (var file_header in cells.GetRow(cells.FirstRowIndex))
            {
                Application.DoEvents();
                if (!main_headers.Contains(file_header.Value.StringValue))
                {
                    MessageBox.Show(file_header.Value.StringValue + " is not valid.");
                    return false;
                }
                else continue;
            }

            List<string> file_headers =new List<string>();
            foreach (var file_header in cells.GetRow(cells.FirstRowIndex)) file_headers.Add(file_header.Value.StringValue);
            foreach (var main_header in main_headers)
            {
                Application.DoEvents();
                if (!file_headers.Contains(main_header))
                {
                    MessageBox.Show("file does not have column: " + main_header );
                    return false;
                }
                else continue;
            }

            return true;
           
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
           InsertDbFromDGV(dataGridView1, new SemnanEntities3());
        }

      

        private static void InsertDbFromDGV(DataGridView dgview, SemnanEntities3 db)
        {
            Loading loading = new Loading();
            loading.Show();
            foreach (DataGridViewRow row in dgview.Rows)
            {
                Application.DoEvents();
                Anbar anbar = new Anbar();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    Application.DoEvents();
                    var insert = cell.Value != null ? cell.Value.ToString() : null;
                    switch (cell.OwningColumn.Name)
                    {
                            
                        case "name":
                            anbar.name = insert;
                            break;
                        case "postal_code":
                            anbar.postal_code = insert;
                            break;
                        case "contractor_or_agent":
                            anbar.contractor_or_agent = insert;
                            break;
                        case "type":
                            anbar.type = insert;
                            break;
                        case "co_national_id":
                            anbar.co_national_id = insert;
                            break;
                        case "activity_sector":
                            anbar.activity_sector = insert;
                            break;
                        case "national_id":
                            anbar.national_id = insert;
                            break;
                        case "date":
                            anbar.date = insert;
                            break;
                        case "mobile":
                            anbar.mobile = insert;
                            break;
                        case "raste":
                            anbar.raste = insert;
                            break;
                        case "family":
                            anbar.family = insert;
                            break;
                        case "senf_id":
                            anbar.senf_id = insert;
                            break;
                        case "etehadie":
                            anbar.etehadie = insert;
                            break;
                        case "fname":
                            anbar.fname = insert;
                            break;
                        case "tel":
                            anbar.tel = insert;
                            break;
                        case "address":
                            anbar.address = insert;
                            break;
                        case "city_input":
                            anbar.city_input = insert;
                            break;
                        case "province_input":
                            anbar.province_input = insert;
                            break;
                        case "explain":
                            anbar.explain = insert;
                            break;
                        case "tag":
                            anbar.tag = insert;
                            break;
                    }

                }

                db.Anbars.Add(anbar);
                db.SaveChanges();
            }
            loading.Close();
        }

    }
}
