using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegisterApiCallerForm.CompanyServiceReference;

namespace RegisterApiCallerForm
{
    public partial class CompanyService : UserControl
    {
        LegalPersonServiceClient service = new LegalPersonServiceClient();
        public CompanyService()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Parameter param=new Parameter();
            param.PassWord="doo71519734";
            param.UserName="smgk.Service";
            param.NationalCode="10780084578";
            Result result= service.InquiryByNationalCode(param);
            MessageBox.Show(result.Message + result.Name);
        }

    }
}
