using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterApiCallerForm
{
    public partial class Report : UserControl
    {
        Form1 form1;
        SemnanEntities3 db = new SemnanEntities3();
        public Report(Form1 f)
        {
            InitializeComponent();
            form1 = f;
            cbProvince.SelectedIndex = 4;
        }

        private void Report_Load(object sender, EventArgs e)
        {
           
        }

        private void btnTagGroup_Click(object sender, EventArgs e)
        {
            var query = db.Anbars.GroupBy(x => x.explain).Select(x => new { explain = x.Key, count = x.Count() }).OrderBy(x => x.count).OrderBy(x => x.count);
            
            Publics.MakeChart(chart,  "explain", "count", query);
        }

        private void btnRegisteredPerProvince_Click(object sender, EventArgs e)
        {
            var query = Publics.AnbarStatus.AnbarsRegistered(db).GroupBy(x => x.province).Select(x => new { province = x.Key, count = x.Count() }).OrderBy(x=>x.count);
            Publics.MakeChart(chart,  "province", "count", query);
        }

        private void btnPerCityBtPrivince_Click(object sender, EventArgs e)
        {
            var query = Publics.AnbarStatus.AnbarsRegistered(db).Where(x=>x.province==cbProvince.Text).GroupBy(x => x.city).Select(x => new { city = x.Key, count = x.Count() }).OrderBy(x => x.count);
            Publics.MakeChart(chart, "city", "count", query);

        }

        


    }
}
