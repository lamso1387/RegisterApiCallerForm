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
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace RegisterApiCallerForm
{
    public partial class PostCodeAssignReport : UserControl
    {
        Form1 form1;
        public PostCodeAssignReport(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           OAuhLogin login_response= pmRestLogin("WSFNEKECWDQKPBWHRGEPLFRKSJSXFXQB" ,"615332776583be556512160029030327");

           lblLogin.Text = login_response.access_token;
          

 
        }

        private void pmRestGetCasesAdvanceSearch(string accessToken )
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://cartable.nwms.ir/api/1.0/samt/cases/advanced-search");
           client.DefaultRequestHeaders.Accept.Clear();
           client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
           client.DefaultRequestHeaders.Add("Authorization","Bearer " + accessToken);
           string all_cases = client.GetAsync("?app_status=COMPLETED&limit=10000&pro_uid=20163348356ffa0d4a693a4030047364").Result.Content.ReadAsStringAsync().Result;
           //20163348356ffa0d4a693a4030047364
           List<CaseProp> cases = JsonConvert.DeserializeObject<List<CaseProp>>(all_cases);
           OrganizeCasesTime(cases);
            dgv.DataSource=cases;

        }

        private void OrganizeCasesTime(List<CaseProp> cases)
        {
            double sec_avg = 0;
            foreach (var per_case in cases)
            {
                TimeSpan day_duration = DateTime.Parse(per_case.app_finish_date) - DateTime.Parse(per_case.app_create_date);
                double second_duration=day_duration.TotalSeconds;
                per_case.case_day_duration = day_duration;
                per_case.case_second_duration = second_duration;
                sec_avg += second_duration;
            }
            sec_avg /= cases.Count;
            lblTimeAvg.Text += (sec_avg/(3600*24)).ToString();
        }
        private OAuhLogin pmRestLogin(string clientId, string clientSecretd)
        { 
            
   Dictionary<string,string> postParams =new Dictionary<string,string>();
            postParams.Add("grant_type","password");
            postParams.Add("scope","*");
             postParams.Add("client_id",clientId);
             postParams.Add("client_secret", clientSecretd);
             postParams.Add("username","lamso1387");
            postParams.Add("password","2050130351");
             HttpClient client = new HttpClient();
           client.BaseAddress = new Uri("http://cartable.nwms.ir");
           client.DefaultRequestHeaders.Accept.Clear();
           client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
           string response = client.PostAsJsonAsync("/samt/oauth2/token", postParams).Result.Content.ReadAsStringAsync().Result;
           OAuhLogin resultAnbar = JsonConvert.DeserializeObject<OAuhLogin>(response);
            

            return resultAnbar; 
}
        class OAuhLogin
        {
            public string access_token { get; set; }
            public string expires_in { get; set; }
            public string token_type { get; set; }
            public string brear { get; set; }
            public string address { get; set; }
            public string scope { get; set; }
            public string refresh_token { get; set; }
            
        }
        class CaseProp
        {
         //public string app_uid { get; set; }
         //   public string del_index { get; set; }
         //   public string del_last_index { get; set; }
         //   public string app_number { get; set; }
            
            public string app_status { get; set; }
            //public string TO_DO { get; set; }
            //public string usr_uid { get; set; }
            //public string previous_usr_uid { get; set; }
           
            
            //public string pro_uid { get; set; }
            //public string del_delegate_date { get; set; }
            //public string del_init_date { get; set; }
           // public string del_finish_date { get; set; }

            // public string tas_uid { get; set; }
            //public string del_task_due_date { get; set; }
            //public string del_risk_date { get; set; }
            //public string del_thread_status { get; set; }

             //public string app_thread_status { get; set; }
            public string app_title { get; set; }
            //public string app_pro_title { get; set; }
            //public string app_tas_title { get; set; }
           
           
            //public string app_current_user { get; set; }
            //public string app_del_previous_user { get; set; }
            //public string del_priority { get; set; }
            //public string del_duration { get; set; }

            //public string del_queue_duration { get; set; }
            //public string del_delay_duration { get; set; }
            //public string del_started { get; set; }
            //public string del_finished { get; set; }

            //public string del_delayed { get; set; }
            public string app_create_date { get; set; }
            public string app_finish_date { get; set; }
            //public string app_update_date { get; set; }
           
            //public string app_overdue_percentage { get; set; }
            //public string usr_firstname { get; set; }
            //public string usr_lastname { get; set; }
            //public string usr_username { get; set; }

            //public string appdelcr_app_tas_title { get; set; }
            //public string usrcr_usr_uid { get; set; }
            //public string usrcr_usr_firstname { get; set; }
            //public string usrcr_usr_lastname { get; set; }
            
            //public string usrcr_usr_username { get; set; }
            //public string app_status_label { get; set; }

            public TimeSpan case_day_duration { get; set; }
            public double case_second_duration { get; set; }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(lblLogin.Text)) pmRestGetCasesAdvanceSearch(lblLogin.Text);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Publics.ExcelMake.ExportToExcell(dgv, 2000);
        }
    }
}
