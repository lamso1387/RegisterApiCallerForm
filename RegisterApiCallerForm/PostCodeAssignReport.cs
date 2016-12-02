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
           
           pmRestGetCasesAdvanceSearch(login_response.access_token);

 
        }

        private void pmRestGetCasesAdvanceSearch(string accessToken )
        {
            HttpClient client = new HttpClient();
           client.BaseAddress = new Uri("http://cartable.nwms.ir/api/1.0/samt/cases/advanced-search");
           client.DefaultRequestHeaders.Accept.Clear();
           client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
           client.DefaultRequestHeaders.Add("Authorization","Bearer " + accessToken);
//curl_setopt($ch, CURLOPT_HTTPHEADER, array("Authorization: Bearer " . $accessToken));
//curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
           var aCases = client.GetAsync("?limit=1&pro_uid=20163348356ffa0d4a693a4030047364").Result.Content.ReadAsStringAsync().Result;
            //;
            //var result_encode = System.Text.RegularExpressions.Regex.Unescape(result);
         //   foreach (var item in aCases) {
	  // print "<p> Case {$oCase->app_title} status  {$oCase->app_status} created {$oCase->app_create_date} finished {$oCase->app_finish_date}.";
	  // $start=strtotime($oCase->app_create_date);
	  // $end=strtotime($oCase->app_finish_date);
	 //  $diff_day=($end-$start)/(3600*24);
	 //  print " $diff_day";
         //   }

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

    }
}
