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
            // TODO: This line of code loads data into the 'sloDBDataSet.SLO' table. You can move, or remove it, as needed.
            this.sLOTableAdapter.Fill(this.sloDBDataSet.SLO);
            // TODO: This line of code loads data into the 'sloDBDataSet.Measurement' table. You can move, or remove it, as needed.
            this.measurementTableAdapter.Fill(this.sloDBDataSet.Measurement);

            // Bind the first combo box to the SLO table
            SloSelectComboBox.DisplayMember = "Title"; // Replace with your SLO name column
            SloSelectComboBox.ValueMember = "SLO_ID";     // Replace with your SLO primary key
            SloSelectComboBox.DataSource = sloDBDataSet.SLO;

            // Initially clear the Measurement combo box
            MetricComboBox.DataSource = null;

            FilterMeasurements();

        }

        private void SloSelectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterMeasurements();
        }

        private void FilterMeasurements()
        {
            if (SloSelectComboBox.SelectedValue != null)
            {
                //For debugging. Show type being returned from combobox
                //MessageBox.Show(SloSelectComboBox.SelectedValue.GetType().ToString());
                int selectedSLOID = (int)SloSelectComboBox.SelectedValue;

                // Use a DataView to filter the Measurement table
                DataView measurementView = new DataView(sloDBDataSet.Measurement);
                measurementView.RowFilter = $"SLO_ID = {selectedSLOID}"; // Assuming foreign key column in Measurement table

                MetricComboBox.DisplayMember = "Description"; // Replace with your column name
                MetricComboBox.ValueMember = "Title";     // Replace with your column name
                MetricComboBox.DataSource = measurementView;
            }
        }
    }

}

