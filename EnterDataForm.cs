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
    public partial class EnterDataForm : Form
    {
        public EnterDataForm()
        {
            InitializeComponent();
            
        }


        private void EnterData_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void EnterDataForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sloDBDataSet.Measurement' table. You can move, or remove it, as needed.
            this.measurementTableAdapter.Fill(this.sloDBDataSet.Measurement);

        }
    }

}

