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
    public partial class ErrorGroup : Form
    {
        
        IQueryable<Anbar> query;
        SemnanEntities3 db;
        public ErrorGroup(IQueryable<Anbar> q, SemnanEntities3 d)
        {
            InitializeComponent();
            query = q;
            db = d;
        }

        private void ErrorGroup_Load(object sender, EventArgs e)
        {
            var errors = query.Intersect(Publics.AnbarStatus.AnbarsSentNotRegistered(db))
                     .GroupBy(x => new { x.output_result, x.error_farsi })
                 .Select(x => new { error = x.Key.output_result, farsi = x.Key.error_farsi, count = x.Count(), type = "output_result" })
              .Union(
                   query.Intersect(Publics.AnbarStatus.AnbarsWithError(db))
                .GroupBy(x => new { x.error})
             .Select(x => new { error = x.Key.error, farsi = "", count = x.Count(), type = "error" })
                 );


            dgv.DataSource = errors.ToList();

            
         
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
        

            Publics.ExcelMake.ExportToExcell(dgv,2000);
        }

        private void button1_Click(object sender, EventArgs e)
        {   
         
        }

        private void tnPerbOrgb_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            dgv.Columns.Add("error", "error");

            var query_with_error=chbContainErrors.Checked ?
                query.Intersect(Publics.AnbarStatus.AnbarsSentNotRegistered(db)).Union(query.Intersect(Publics.AnbarStatus.AnbarsWithError(db))):
                query.Intersect(Publics.AnbarStatus.AnbarsSentNotRegistered(db));

               foreach(var col in query_with_error.Select(x=>x.explain).Distinct())
               {
                   if (!string.IsNullOrWhiteSpace(col)) dgv.Columns.Add(col.ToString(), col.ToString());
               }
               


            int row_index = 0;
            foreach(var error in query_with_error.Select(x=>x.error_farsi).Distinct()){

                if (!string.IsNullOrWhiteSpace(error))
                { 
                    dgv.Rows.Add();
                    dgv.Rows[row_index].Cells["error"].Value = error.ToString();
                     foreach (var error_per_org in query_with_error.Where(x => x.error_farsi == error).GroupBy(x => new { x.explain }).Select(x => new { organ = x.Key.explain, count = x.Count() }))
                     {
                         dgv.Rows[row_index].Cells[error_per_org.organ].Value = error_per_org.count.ToString();
                     }
                     row_index++;
                }
            }

            dgv.Columns.Add("null_add", " ");
          
        }
    }
}
