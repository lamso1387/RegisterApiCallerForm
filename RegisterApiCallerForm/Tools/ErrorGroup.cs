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
                .GroupBy(x => new { x.output_result, x.error_farsi }).Select(x => new { error = x.Key.output_result, farsi = x.Key.error_farsi, count = x.Count(), type = "output_result" }).Union(
                 query.Intersect(Publics.AnbarStatus.AnbarsWithError(db))
               .GroupBy(x => new { x.error, x.error_farsi }).Select(x => new { error = x.Key.error, farsi = x.Key.error_farsi, count = x.Count(), type = "error" })          
               );
            dgv.DataSource = errors.ToList();

         
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
           // Publics.ExportToExcell(dgvExport);
        }
    }
}
