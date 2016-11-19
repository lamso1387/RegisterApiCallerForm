using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;

namespace RegisterApiCallerForm
{
    public partial class SingleTest : UserControl
    {
        
        Dictionary<string, object> input;
        Form1 form1;
        public SingleTest(Form1 f)
        {
            InitializeComponent();
            form1 = f;
            cbOwnership.SelectedIndex = 0;
            cbType.SelectedIndex = 0;


        }

        private void miMgmt_Click(object sender, EventArgs e)
        {

        }

        private void btnRegWarehouse_Click(object sender, EventArgs e)
        {

        }

        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            lbActivity.Items.Add(tbActivitySec.Text);
            tbActivitySec.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbActivity.SelectedItems.Count > 0)
            {
                foreach (var item in lbActivity.SelectedItems.OfType<string>().ToList())
                    lbActivity.Items.Remove(item);
            }
        }

        private  void btnRegWarehouse_Click_1(object sender, EventArgs e)
        {
            try
            {
                //for (int i=0; i<3;i++) 
                 RegisterAnbar();
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void btnEpoch_Click(object sender, EventArgs e)
        {
            TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);
            // TimeSpan t = new DateTime(2012,05,01) - new DateTime(1970, 1, 1);
            //TimeSpan t = dateTimePicker1.Value - new DateTime(1970, 1, 1);
            int secondsSinceEpoch = (int)t.TotalSeconds;
            MessageBox.Show(secondsSinceEpoch.ToString());
        }

        public  void RegisterAnbar()
        {
            input = new Dictionary<string, object>();
            input = CreateInput(input);

            MessageBox.Show(JsonConvert.SerializeObject(input));
            var result = Publics.SendAnbar(input);

            MessageBox.Show(System.Text.RegularExpressions.Regex.Unescape(result));

        }

        private Dictionary<string, object> CreateInput(Dictionary<string, object> input)
        {

            input.Add("national_id", tbNatioCode.Text);
            if (!string.IsNullOrWhiteSpace(tbSSNNno.Text)) input.Add("SSNN_no", tbSSNNno.Text);
            if (!string.IsNullOrWhiteSpace(tbGender.Text)) input.Add("gender", tbGender.Text);
            if (!string.IsNullOrWhiteSpace(tbBirthepoch.Text)) input.Add("birthepoch", tbBirthepoch.Text);
            if (!string.IsNullOrWhiteSpace(tbMobile.Text)) input.Add("mobile", tbMobile.Text);
            if (!string.IsNullOrWhiteSpace(tbEmail.Text)) input.Add("email", tbEmail.Text);
            input.Add("name", tbName.Text);
            if (!string.IsNullOrWhiteSpace(tbCoName.Text)) input.Add("co_name", tbCoName.Text);
            if (!string.IsNullOrWhiteSpace(tbCoNatio.Text)) input.Add("co_national_id", tbCoNatio.Text);
            if (!string.IsNullOrWhiteSpace(tbCoRegister.Text)) input.Add("co_register_no", tbCoRegister.Text);
            input.Add("postal_code", tbPostalCode.Text);
            input.Add("contractor_or_agent", cbOwnership.Text);
            if (!string.IsNullOrWhiteSpace(cbType.Text)) input.Add("type", cbType.Text);
            if (lbActivity.Items.Count > 0) input.Add("activity_sector", lbActivity.Items.Cast<object>().Select(item => item.ToString()).ToList());

            if (!string.IsNullOrWhiteSpace(tbProvince.Text)) input.Add("province", tbEmail.Text);
            if (!string.IsNullOrWhiteSpace(tbCity.Text)) input.Add("city", tbCity.Text);

            if (!string.IsNullOrWhiteSpace(cbAutoContinue.Text)) input.Add("auto_continue", Boolean.Parse(cbAutoContinue.Text));

            if (!string.IsNullOrWhiteSpace(cbAutoFillUserData.Text)) input.Add("auto_fill_user_data", Boolean.Parse(cbAutoFillUserData.Text));
            if (!string.IsNullOrWhiteSpace(Publics.errorSMS)) input.Add("on_error_data_send_sms_to_user", Boolean.Parse(Publics.errorSMS));

            return input;
        }

        
    }
}
