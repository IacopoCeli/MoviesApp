using IndustrialSoftware_App.Controller;
using IndustrialSoftware_App.Model;
using System.Windows.Forms;

namespace IndustrialSoftware_App
{
    public partial class Form1 : Form
    {

        private Controller.DataController dataController;
        private bool onInit = true;

        public Form1()
        {

            InitializeComponent();

            this.dataController = Controller.DataController.GetInstance();
            this.dataController.Inizialize(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "HollywoodMovies.csv"));
        
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.dataController.DownloadData();

            dataGridView1.Rows.Clear();

            foreach (var movie in this.dataController.moviesList)
            {
                dataGridView1.Rows.Add(movie.Movie,
                                        movie.LeadStudio,
                                        movie.RottenTomatoes,
                                        movie.AudienceScore,
                                        movie.Story,
                                        movie.Genre,
                                        movie.TheatersOpenWeek,
                                        movie.OpeningWeekend,
                                        movie.BOAvgOpenWeekend,
                                        movie.DomesticGross,
                                        movie.ForeignGross,
                                        movie.WorldGross,
                                        movie.Budget,
                                        movie.Profitability,
                                        movie.OpenProfit,
                                        movie.Year,
                                        movie.Director);
            }

            onInit = false;

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (!this.onInit)
                this.dataController.ModElement(dataGridView1[0, e.RowIndex].Value.ToString(), 
                                            dataGridView1.Columns[e.ColumnIndex].Name, 
                                            dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString());

        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

            string key = dataGridView1[0, e.Row.Index].Value.ToString();

            if (MessageBox.Show($"Sure to delete the movie : \"{key}\"", "Deleting", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
            else
                this.dataController.DeleteElement(key);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Sure to save on file the grid content?", "Saving", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.dataController.SaveData();
        }
    }
}
