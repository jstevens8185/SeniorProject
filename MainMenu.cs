using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeniorProject
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void EnterDataButton_Click(object sender, EventArgs e)
        {
            EnterData enterData = new EnterData();
            enterData.Show();
            this.Hide();
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            View reports = new View();
            reports.Show();
            this.Hide();
        }

        
        private void NewSLOButton_Click(object sender, EventArgs e)
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
            parentForm.Hide();
        }
    }
}
