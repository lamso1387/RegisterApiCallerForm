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
        public EstelamTest(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            

            StartSending(int.Parse(tbParallel.Text), int.Parse(tbRound.Text));

        }

        public void StartSending( int parallel, int round)
        {
            SemnanEntities3 db= new SemnanEntities3();
            Loading loading = new Loading();
            loading.Show();
            loading.lblTime.Text="";
            loading.dataGridView1.Visible=false;
            loading.lblSrart.Text = DateTime.Now.ToString();
            
            Publics.TruncateTimeTable(db,"EstelamTime");
            Publics.stopLoop = false;
          
            for (int j = 1; j < (round+1); j++)
            {
                Application.DoEvents();
                if (Publics.stopLoop) break;
                loading.lblLoading.Text = " در حال ارسال  " + parallel + " درخواست بطور موازی در بار   " + j;
                ParallelSend(parallel,j);

            }


            loading.lblLoading.Text = " ارسال موازی در   " + parallel + "  کانال انجام شد در   " + round + "  مرتبه   ";
            loading.lblEnd.Text = DateTime.Now.ToString();
            loading.Text += "-done";
            loading.btnClose.Enabled = true;
            btnSee.PerformClick();
            lblTime.Text = db.EstelamTimes.Select(x => x.estalam_time).Average().ToString();
            loading.Close();
            
        }
        private void ParallelSend(int parallel, int round)
        {
            List<Task> task_list = new List<Task>();
            for (int i = 0; i < parallel; i++)
            {
                Application.DoEvents();
                Task task = new Task(() => Estelam( parallel, round));
                task_list.Add(task);
                task.Start();

            }
            Task.WaitAll(task_list.ToArray());

        }

        private void Estelam( int parallel, int round)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();            
            var result = Publics.client.GetAsync(Publics.apiKey + Publics.uri).Result.Content.ReadAsStringAsync().Result;            
            timer.Stop();
            InsertIntoEstelamTime(result, timer.Elapsed.TotalSeconds, parallel, round);

        }

        private void InsertIntoEstelamTime( string result, double time_taken, int parallel, int round)
        {
           
            EstelamTime estelam_time = new EstelamTime();
            estelam_time.estalam_time = time_taken;
            estelam_time.estelam_parallel = parallel;
            estelam_time.estelam_round = round;
            estelam_time.output_result = System.Text.RegularExpressions.Regex.Unescape(result); 
            SemnanEntities3 db = new SemnanEntities3();
            db.EstelamTimes.Add(estelam_time);
            db.SaveChanges();

        }

        private void tbPostalCode_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPostalCode.Text)) form1.tbRequestUri.Text = form1.cbMethodName.Text;
            else form1.tbRequestUri.Text =form1.cbMethodName.Text+ "/"+ tbPostalCode.Text;
        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            dgvSeeTimes.DataSource = new SemnanEntities3().EstelamTimes.Select(x => x).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           HttpClient client = new HttpClient();
           client.BaseAddress = new Uri("http://app1.nwms.ir/v2/b2b-api/");
           client.DefaultRequestHeaders.Accept.Clear();
           client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
           var result = client.GetAsync("0123456789" + "/complex_by_post_code/4713644457").Result.Content.ReadAsStringAsync().Result;
           var result_encode = System.Text.RegularExpressions.Regex.Unescape(result);
           MessageBox.Show(result_encode);
        }
    }
}
