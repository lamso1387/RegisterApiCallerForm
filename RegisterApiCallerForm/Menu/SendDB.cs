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
using System.Diagnostics;

namespace RegisterApiCallerForm
{
    public partial class SendDB : UserControl
    {
        Form1 form1;
        SemnanEntities3 db = new SemnanEntities3();
        public SendDB(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void btnSeeData_Click(object sender, EventArgs e)
        {

            dgvInput.DataSource = db.Anbars.Select(x => x).OrderBy(x => x.ID).Skip(int.Parse(tbFrom.Text) - 1).Take(int.Parse(tbTo.Text)).ToList();
        }

        private  void btnSendDB_Click(object sender, EventArgs e)
        {


            List<Anbar> DBitems = db.Anbars.Select(x => x).OrderBy(x => x.ID).Skip(int.Parse(tbFrom.Text) - 1).Take(int.Parse(tbTo.Text)).ToList();
            Publics.StartSending(db, DBitems);
        }

        private void btnGetRows_Click(object sender, EventArgs e)
        {
            Publics.GetRows(dgvInput, tbFrom, tbTo, db);
        }


    }
}
