using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace $safeprojectname$
{
    public partial class Navigation : Form
    {
        Animals livestock;
        List<Animals> list = new List<Animals>();


        public Navigation()
        {
            InitializeComponent();
            getLiveStock();
            refreshGraph();
            refreshGrid();
        }

 
        /**
        private void chart1_Load(object sender, EventArgs e)
        {
           
            refreshGraph();
        }
        **/


        private void FillOrCancel_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Opens the NewCustomer form as a dialog box,
        /// which returns focus to the calling form when it is closed. 
        /// </summary>
        private void btnGoToAdd_Click(object sender, EventArgs e)
        {
            Form frm = new NewCustomer();
            frm.Show();
        }

        /// <summary>
        /// Opens the FillorCancel form as a dialog box. 
        /// </summary>
        private void btnGoToFillOrCancel_Click(object sender, EventArgs e)
        {
            Form frm = new FillOrCancel();
            frm.ShowDialog();
        }

        /// <summary>
        /// Closes the application (not just the Navigation form).
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInitalize_Click(object sender, EventArgs e)
        {
            refreshGraph();
        }


        private void refreshGraph()
        {
            // Convert to DataTable.
            //DataTable table = ConvertListToDataTable(list);

            DataSet ds = new DataSet();
            ds = Common.ToDataSet(getLiveStock2());
            //ds = getLiveStock();
            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            this.chart1.ChartAreas[0].AxisX.Title = "Breed";
            this.chart1.ChartAreas[0].AxisY.Title = "Total Head";

            this.chart1.Series.Clear();
            this.chart1.DataBindCrossTable(dt.Rows, "Type", "Breed", "Total", "");

            /**
            this.chart1.Series["Cows"].Points.AddXY("Angus", 10);
            this.chart1.Series["Cows"].Points.AddXY("Hereford", 3);
            this.chart1.Series["Bulls"].Points.AddXY("Angus", 2);
            this.chart1.Series["Bulls"].Points.AddXY("Hereford", 1);
            this.chart1.Series["Calves"].Points.AddXY("Angus", 22);
            this.chart1.Series["Calves"].Points.AddXY("Hereford", 61);
    **/
            foreach (Series cs in chart1.Series)
            {
                cs.ChartType = SeriesChartType.StackedColumn;
                cs.IsValueShownAsLabel = true;
                cs.LabelToolTip = "#VAL #SERIESNAME";
            }


        }

        private void refreshGrid()
        {
            dataGridView1.DataSource = getLiveStock2();
        }




        private dynamic getLiveStock2()
        {
            using (Entities db = new Entities())
            {
                var query = (from cal in db.Calves select new { Breed = cal.Breed, Cull_Code = cal.Cull_Code, Type = "Calves" })
                    .Concat(from bul in db.Bulls select new { Breed = bul.Breed, Cull_Code = bul.Cull_Code, Type = "Bulls" })
                    .Concat(from cow in db.Cows select new { Breed = cow.Breed, Cull_Code = cow.Cull_Code, Type = "Cows" })
                    .GroupBy(p => new { p.Breed, p.Type }, (key, group) => new { Breed = key.Breed, Type = key.Type, Total = group.Count() });

                //var query2 = query.GroupBy(p => new { p.Breed, p.Type }, (key, group) => new { Breed = key.Breed, Type = key.Type, Total = group.Count() });


                return query.ToList();
            }
        }

        private dynamic getLiveStock()
        {

            //var query = commonClass.db.Meter_Proving.ToList();    // your starting point - table in the "from" statement

            using (Entities db = new Entities())
            {
                List<Livestock> record = db.Livestocks.ToList();
                return record;
            }

            /**
            list.Add(new Animals() { Type = "Cows", Breed = "Angus", Total = 70 });
            list.Add(new Animals() { Type = "Calves", Breed = "Angus", Total = 50 });
            list.Add(new Animals() { Type = "Bulls", Breed = "Angus", Total = 5 });

            list.Add(new Animals() { Type = "Cows", Breed = "Hereford", Total = 90 });
            list.Add(new Animals() { Type = "Calves", Breed = "Hereford", Total = 40 });
            list.Add(new Animals() { Type = "Bulls", Breed = "Hereford", Total = 10 });
            **/
        }


    }

    public class Animals
    {
        public string Type { get; set; }
        public string Breed { get; set; }
        public int Total { get; set; }

        // Other properties, methods, events...
    }
}
