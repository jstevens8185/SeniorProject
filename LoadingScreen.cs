using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace SeniorProject
{
    public partial class LoadingScreen : Form
    {

        private Timer timer;
        private int progressValue = 0;
        Random rnd = new Random();

        public LoadingScreen()
        {
            InitializeComponent();
            InitializeLoading();
            InitializeDatabase();
        }

        private void InitializeLoading()
        {
            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (progressValue < 100)
            {

                progressValue += rnd.Next(1, 5);
                if(progressValue > 100)
                {
                    progressValue = 100;
                }
                progressBar1.Value = progressValue;
            }
            else
            {
                timer.Stop();
                
                this.Close();
            }
        }

        public void InitializeDatabase()
        {
            string dbPath = "Database/data.db"; // Path to your SQLite file

            // Check if the database file exists; if not, create it
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
            }

            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                conn.Open();
                string createTableQuery = @"CREATE TABLE IF NOT EXISTS StudentGrades (
                                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                                    Year INTEGER NOT NULL,
                                    Grade TEXT NOT NULL
                                );";
                using (SQLiteCommand cmd = new SQLiteCommand(createTableQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
