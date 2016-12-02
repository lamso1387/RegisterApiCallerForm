using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Globalization;
using System.Text.RegularExpressions;

using HibernatingRhinos.Profiler.Appender;

namespace RegisterApiCallerForm
{
    public partial class Form1 : Form
    {
        public HttpClient client = new HttpClient();
        

        public Form1()
        {
            InitializeComponent();

            cbMethodName.SelectedIndex = 0;
            tbBaseAddress.Text = "http://app1.nwms.ir/v2/b2b-api/";
            tbApiKey.Text = "0123456789";

            Publics.apiKey = tbApiKey.Text;
            Publics.uri = tbRequestUri.Text;
            Publics.client.BaseAddress = new Uri("http://app1.nwms.ir/v2/b2b-api/");
            Publics.client.DefaultRequestHeaders.Accept.Clear();
            Publics.client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            client.BaseAddress = new Uri("http://app1.nwms.ir/v2/b2b-api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            lblKeyTitle.Text = new SemnanEntities3().Keys.Where(x => x.api_key == tbApiKey.Text).Select(y => y.title).DefaultIfEmpty("کاربر: نامشخص").FirstOrDefault();
            
        }


        private  void btnRegWarehouse_Click(object sender, EventArgs e)
        {
          


         }

        
        private void btnAddActivity_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void miSendDB_Click(object sender, EventArgs e)
        {
            pnlmain.Controls.Clear();
            pnlmain.Controls.Add(new SendDB(this));
        }

        private void btnEpoch_Click(object sender, EventArgs e)
        {
        }

        private void miMgmt_Click(object sender, EventArgs e)
        {
            pnlmain.Controls.Clear();
            pnlmain.Controls.Add(new DataMgmt(this));
        }

        private void miSingleTest_Click(object sender, EventArgs e)
        {
            //HibernatingRhinos.Profiler.Appender.NHibernate.NHibernateProfiler.Initialize();
            pnlmain.Controls.Clear();
            pnlmain.Controls.Add(new SingleTest(this));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            new Login(this).ShowDialog();
            pnlmain.Controls.Add(new SingleTest(this));
            
        }

        public async Task<string> SendAnbarAsync(object anbar)
        {
            Task<HttpResponseMessage> response = client.PostAsJsonAsync(tbApiKey.Text + tbRequestUri.Text, anbar);

            //response.Result.EnsureSuccessStatusCode();

            // Return the URI of the created resource.

            return await response.Result.Content.ReadAsStringAsync();
            // return response.Headers.Location;
        }

        private void tbApiKey_TextChanged(object sender, EventArgs e)
        {
            Publics.apiKey = tbApiKey.Text;
        }

        private void tbRequestUri_TextChanged(object sender, EventArgs e)
        {
            
            Publics.uri = tbRequestUri.Text;
        }

        private void cbErrorSMS_SelectedIndexChanged(object sender, EventArgs e)
        {
            Publics.errorSMS =cbErrorSMS.Text;                
        }

        private void tbApiKey_Leave(object sender, EventArgs e)
        {
            
            lblKeyTitle.Text = new SemnanEntities3().Keys.Where(x => x.api_key == tbApiKey.Text).Select(y=>y.title).DefaultIfEmpty("کاربر: نامشخص").FirstOrDefault();
        }

        private void btnKeyTitles_Click(object sender, EventArgs e)
        {
            new ApiKey(tbApiKey).ShowDialog();
            tbApiKey_Leave(null,null);
        }

        private void chbMaxTime_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbMaxTime_TextChanged(object sender, EventArgs e)
        {
        }

        private void miReport_Click(object sender, EventArgs e)
        {
            pnlmain.Controls.Clear();
            pnlmain.Controls.Add(new Report(this));
            
            
        }

        private void miErrorMgtm_Click(object sender, EventArgs e)
        {
            pnlmain.Controls.Clear();
            pnlmain.Controls.Add(new ErrorMgmt());

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbRequestUri.Text = cbMethodName.Text;
        }

        private void miEstelamTest_Click(object sender, EventArgs e)
        {
            pnlmain.Controls.Clear();
            pnlmain.Controls.Add(new EstelamTest(this));
        }

        private void tbBaseAddress_TextChanged(object sender, EventArgs e)
        {
            Publics.client.BaseAddress = new Uri(tbBaseAddress.Text);
        }

        private void miPostCodeAssignReport_Click(object sender, EventArgs e)
        {
            pnlmain.Controls.Clear();
            pnlmain.Controls.Add(new PostCodeAssignReport(this));
        }
       
    }
}
