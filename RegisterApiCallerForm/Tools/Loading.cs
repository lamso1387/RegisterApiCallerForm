using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterApiCallerForm
{
    public partial class Loading : Form
    {
        public bool cancel = false;
        public Loading()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancel = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Publics.stopLoop = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDgvBind_Click(object sender, EventArgs e)
        {
            SemnanEntities3 db=new SemnanEntities3();
            dataGridView1.DataSource = db.TimeTakens.Select(x => x.time_taken).ToList();

        }
    }
}
