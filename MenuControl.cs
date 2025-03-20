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
    public partial class MenuControl : UserControl
    {
        public MenuControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (parentForm is MainMenu)
            {
                return;
            }

            foreach (Form form in Application.OpenForms)
            {
                if (form is MainMenu)
                {
                    form.Show();
                    form.Activate();
                    parentForm.Visible = false;
                    return;
                }
            }

            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            parentForm.Visible = false;

        }

        private void createSLOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (parentForm is CreateSloForm)
            {
                return;
            }

            foreach (Form form in Application.OpenForms)
            {
                if (form is CreateSloForm)
                {
                    form.Show();
                    form.Activate();
                    parentForm?.Close();
                    return;
                }
            }

            CreateSloForm createSloForm = new CreateSloForm();
            createSloForm.Show();
            parentForm.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is MainMenu)
                {
                    form.Close();
                    return;
                }
            }
        }

        public event Action DatabaseReset;

        private void resetDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to reset the database? This will delete all data permanently.",
                "Confirm Reset",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                ResetDatabase();
                DatabaseReset?.Invoke(); // Notify subscribers (like MainForm)
            }
        }

        public void ResetDatabase()
        {
            string dbPath = "Database/data.db";
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                try
                {
                    conn.Open();
                    string query = @"
                DROP TABLE IF EXISTS StudentGrades;
                CREATE TABLE StudentGrades (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Year INTEGER NOT NULL,
                    Grade TEXT NOT NULL
                );";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Database reset!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error resetting database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (parentForm is ViewForm)
            {
                return;
            }

            foreach (Form form in Application.OpenForms)
            {
                if (form is ViewForm)
                {
                    form.Show();
                    form.Activate();
                    parentForm?.Close();
                    return;
                }
            }

            ViewForm viewForm = new ViewForm();
            viewForm.Show();
            parentForm.Visible = false;
        }

        private void enterDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (parentForm is EnterDataForm)
            {
                return;
            }

            foreach (Form form in Application.OpenForms)
            {
                if (form is EnterDataForm)
                {
                    form.Show();
                    form.Activate();
                    parentForm.Visible = false;
                    return;
                }
            }

            EnterDataForm enterDataForm = new EnterDataForm();
            enterDataForm.Show();
            parentForm.Visible = false;
        }
    }
}
