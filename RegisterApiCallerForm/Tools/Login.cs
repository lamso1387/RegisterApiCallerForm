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
    public partial class Login : Form
    {
        Form1 form1;
        public Login(Form1 f)
        {
            InitializeComponent();
            form1 = f;
            this.AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "2628") form1.Close();
            else this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
