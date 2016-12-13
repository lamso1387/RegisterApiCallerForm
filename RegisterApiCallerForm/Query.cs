using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RegisterApiCallerForm
{
    public partial class Query : UserControl
    {
        public Query()
        {
            InitializeComponent();
           
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string query = "drop table TableQuery; " +
"select * " +
"into TableQuery from( ";
            query += tbQuery.Text;
            query += " ) rez2 ;";// +
                //" ALTER TABLE TableQuery ADD Table_ID int NOT NULL IDENTITY (1,1) PRIMARY KEY;";
            Publics.ExecuteQuery(new SemnanEntities3(), query);
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Semnan;User ID=sa;Password=123@abc");
            SqlCommand com = new SqlCommand("select * from TableQuery", con);
            SqlDataAdapter data = new SqlDataAdapter(com);
            DataSet ds=new DataSet();
            data.Fill(ds);
            DataTable dt = ds.Tables[0];
            dgv.DataSource = dt;
            lblCount.Text = dgv.Rows.Count.ToString();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbQuery.Text=" SELECT SUM(multi)/ SUM(cont) AS time_avg "+
	   " FROM "+
	   " (SELECT CAST(time_taken AS int) AS sec, COUNT(CAST(time_taken AS int)) AS cont, CAST(time_taken AS int) * COUNT(CAST(time_taken AS int)) AS multi "+
                           " FROM            dbo.TimeTaken "+
                           " GROUP BY CAST(time_taken AS int)) AS rez ";
        }
    }
}
