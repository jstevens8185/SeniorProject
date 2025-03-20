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

namespace SeniorProject
{
    public partial class EnterData : Form
    {
        public EnterData()
        {
            InitializeComponent();
            LoadData();
            MenuControl.DatabaseReset += LoadData;
        }

        public void SaveData()
        {
            // Validate user input
            if (YearComboBox.SelectedItem == null || string.IsNullOrWhiteSpace(DataTextBox.Text))
            {
                MessageBox.Show("Please select a Year and enter a Grade.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedYear = Convert.ToInt32(YearComboBox.SelectedItem);
            string enteredGrade = DataTextBox.Text.Trim();
            string dbPath = "Database/data.db"; // Path to your SQLite file

            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                conn.Open();
                string query = "INSERT INTO StudentGrades (Year, Grade) VALUES (@Year, @Grade)";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Year", selectedYear);
                    cmd.Parameters.AddWithValue("@Grade", enteredGrade);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void LoadData()
        {
            string dbPath = "Database/data.db";

            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                conn.Open();
                string query = "SELECT Year, Grade FROM StudentGrades";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt; // Assuming you have a DataGridView
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            SaveData();
            LoadData();
        }
    }

}

