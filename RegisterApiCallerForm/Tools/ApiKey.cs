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
    public partial class ApiKey : Form
    {
        TextBox textBox;
        public ApiKey(TextBox tb)
        {
            InitializeComponent();
            dgv.DataSource = new SemnanEntities3().Keys.Select(x => x).ToList();
            textBox = tb;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                textBox.Text = dgv.Rows[dgv.SelectedRows[0].Index].Cells["api_key"].Value.ToString();
             
                this.Close();

            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSelect.PerformClick();
        }
    }
}
