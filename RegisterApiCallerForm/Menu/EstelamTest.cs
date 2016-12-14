using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Diagnostics;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace RegisterApiCallerForm
{
    public partial class EstelamTest : UserControl
    {
       

        Form1 form1;
        HttpClient client = new HttpClient();
        public EstelamTest(Form1 f)
        {
            InitializeComponent();
            form1 = f;
            client.BaseAddress = new Uri("http://app1.nwms.ir/v2/b2b-api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Publics.stopLoop = false;
            Loading loading = new Loading();
            loading.Show();
            foreach (var _count in cbCount.Items)
            {
                Application.DoEvents();
                if (Publics.stopLoop) break;
                cbCount.SelectedItem = _count;
                int count = int.Parse(cbCount.Text);
                int round = GetRound(count);
                loading.lblLoading.Text = "در حال ارسال همزمان  : " + count.ToString();
                SendByRound(count, round);
            }


            loading.Close();
            lblTime.Text = new SemnanEntities3().countrounds.Select(x => x.time_taken).Average().ToString();

        }
        private void SendByRound(int count, int round)
        {
            for (int i = 1; i <= round; i++)
            {
                SendByCount(count, i, cbUri.SelectedIndex, tbPostalCode.Text);
            }
        }

        private void SendByCount(int count, int round, int api_index, string post_code)
        {
            List<Task> TaskList = new List<Task>();
            for (int i = 1; i <= count; i++)
            {

                Task task = new Task(() => SendData(count, round, api_index, post_code));
                TaskList.Add(task);
                task.Start();
            }

            Task.WaitAll(TaskList.ToArray());
        }
        private void SendData(int count, int round, int api_index,string post_code)
        {
            Stopwatch timer = new Stopwatch();
            string result = "not_set";
            switch (api_index)
            {
                case -1:
                    MessageBox.Show("سرویس را انتخاب کنید");
                    break;
                case 0:
                    timer.Start();
                    result = Publics.client.GetAsync("2050130351/complex_by_post_code/" + post_code).Result.Content.ReadAsStringAsync().Result;
                    timer.Stop();
                    break;
                case 1:
                    Dictionary<string, object> input=new Dictionary<string,object>();
                    input.Add("postal_code",post_code);
                    timer.Start();
                    result = client.PostAsJsonAsync("2050130351/admin/ext-service/postal_code" , input).Result.Content.ReadAsStringAsync().Result;
                    timer.Stop();
                    break;

            }
            
            InsertIntoDB(result, timer.Elapsed.TotalSeconds, count, round);

        }
        private int GetRound(int count)
        {
            int round = 0;
            switch (count)
            {
                case 1:
                    round = 30;
                    break;
                case 2:
                    round = 15;
                    break;
                case 3:
                    round = 10;
                    break;
                case 5:
                    round = 6;
                    break;
                case 6:
                    round = 5;
                    break;
                case 10:
                    round = 3;
                    break;
                case 15:
                    round = 2;
                    break;
                case 30:
                    round = 1;
                    break;
            }
            return round;
        }

        private void InsertIntoDB(string result, double time_taken, int count, int round)
        {
            SemnanEntities3 db = new SemnanEntities3();
            countround table = new countround();
            table.counter = count;
            table.round = round;
            table.time_taken = time_taken;
            table.input_type = tbType.Text;
            table.message = System.Text.RegularExpressions.Regex.Unescape(result);
            db.countrounds.Add(table);
            db.SaveChanges();

        }

        private void tbPostalCode_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            dgvSeeTimes.DataSource = new SemnanEntities3().countrounds .Select(x => x).ToList();
            lblTime.Text = new SemnanEntities3().countrounds.Select(x => x.time_taken).Average().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           HttpClient client = new HttpClient();
           client.BaseAddress = new Uri("http://app1.nwms.ir/v2/b2b-api/");
           client.DefaultRequestHeaders.Accept.Clear();
           client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
           var result = client.GetAsync("2050130351" + "/complex_by_post_code/4713644457").Result.Content.ReadAsStringAsync().Result;
           var result_encode = System.Text.RegularExpressions.Regex.Unescape(result);
           MessageBox.Show(result_encode);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Publics.TruncateTimeTable(new SemnanEntities3(), "countround");
            MessageBox.Show("جدول زمان حذف شد");
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Publics.ExcelMake.ExportToExcell(dgvSeeTimes, 2000);
        }

        private void cbUri_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbType.Text = cbUri.Text;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            SemnanEntities3 db= new SemnanEntities3();
           dgvSeeTimes.DataSource= db.countrounds.GroupBy(x=>x.input_type).Select(x=>new {input_type=x.Key,num_sent= x.Count(), avgerage_second=x.Average(y=>y.time_taken)}).ToList();
          
        }

        private void btnExcelImport_Click(object sender, EventArgs e)
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
                    dgvEstelamRezalt.Columns.Add(header.Value.StringValue, header.Value.StringValue);
                }

                // add rows
                for (int rowIndex = cells.FirstRowIndex + 1; rowIndex <= cells.LastRowIndex; rowIndex++)
                {
                    ExcelLibrary.Office.Excel.Row file_row = cells.GetRow(rowIndex);

                    dgvEstelamRezalt.Rows.Add(file_row.GetCell(0).Value);
                }

            }
        }

        private bool CheckExcelHeaders(ExcelLibrary.Office.Excel.CellCollection cells)
        {
            string[] main_headers = { "postal_code"};
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

            List<string> file_headers = new List<string>();
            foreach (var file_header in cells.GetRow(cells.FirstRowIndex)) file_headers.Add(file_header.Value.StringValue);
            foreach (var main_header in main_headers)
            {
                Application.DoEvents();
                if (!file_headers.Contains(main_header))
                {
                    MessageBox.Show("file does not have column: " + main_header);
                    return false;
                }
                else continue;
            }

            return true;

        }

        private void btnEstelamPostalCode_Click(object sender, EventArgs e)
        {
            Loading loading = new Loading();
            loading.Show();
            SemnanEntities3 db = new SemnanEntities3();
            Publics.ExecuteQuery(db, "truncate table OrganEstelam");
            foreach (DataGridViewRow row in dgvEstelamRezalt.Rows)
            {               
                Application.DoEvents();
                if(row.Cells[0].Value ==null) continue;
                string postal_code = row.Cells[0].Value.ToString();
                if (string.IsNullOrWhiteSpace(postal_code)) continue;
                OrganEstelam organ_estelam = new OrganEstelam();                
                organ_estelam.postal_code = postal_code;              
                var local_estalam= db.PostalCodes.Where(x => x.postal_code == postal_code).Select(x => x);
                if (local_estalam.Count() > 0 )
                {
                    var local_estalam_vars = local_estalam.First();
                    organ_estelam.last_sent = DateTime.Now.ToString();
                    organ_estelam.province = local_estalam_vars.province;
                    organ_estelam.city = local_estalam_vars.city;
                    organ_estelam.township = local_estalam_vars.township;
                    organ_estelam.address = local_estalam_vars.address;
                    organ_estelam.city = local_estalam_vars.city;

                }
                else 
                {
                    string result = Publics.client.GetAsync("2050130351/complex_by_post_code/" + postal_code).Result.Content.ReadAsStringAsync().Result;
                    organ_estelam.output_result = System.Text.RegularExpressions.Regex.Unescape(result);
                    organ_estelam.error_farsi = string.Empty;
                    if (string.IsNullOrWhiteSpace(result)) organ_estelam.error = "soheil writes: result is empty from server";
                    else if (!Publics.IsJson(result)) organ_estelam.error = "soheil writes: result is not json";
                    else
                    {
                        PostalCode local_post = new PostalCode();
                        local_post.postal_code = postal_code;
                        var resul_post = JsonConvert.DeserializeObject<Publics.EstelamResult>(result);
                        local_post.province = organ_estelam.province = resul_post.province;
                        local_post.city = organ_estelam.city = resul_post.city;
                        local_post.address = organ_estelam.address = string.IsNullOrWhiteSpace(resul_post.full_address) ?  resul_post.address: resul_post.full_address;
                        local_post.township = organ_estelam.township = resul_post.township;
                        local_post.last_sent =organ_estelam.last_sent= DateTime.Now.ToString();
                        local_post.error =organ_estelam.error= string.Empty;
                        db.PostalCodes.Add(local_post);
                        
                    }

                }
                db.OrganEstelams.Add(organ_estelam);
                db.SaveChanges();
                
            }
            dgvEstelamRezalt.DataSource = db.OrganEstelams.ToList();
            loading.Close();

        }

        private void btnExportEstelamRezalt_Click(object sender, EventArgs e)
        {
            Publics.ExcelMake.ExportToExcell(dgvEstelamRezalt, 2000);
        }
    }
}
