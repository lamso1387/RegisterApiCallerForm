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
    }
}
