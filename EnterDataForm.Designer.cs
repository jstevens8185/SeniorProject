namespace SeniorProject
{
    partial class EnterDataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MenuControl = new SeniorProject.MenuControl();
            this.YearComboBox = new System.Windows.Forms.ComboBox();
            this.YearLabel = new System.Windows.Forms.Label();
            this.SloSelectComboBox = new System.Windows.Forms.ComboBox();
            this.SloSelectLabel = new System.Windows.Forms.Label();
            this.MetricComboBox = new System.Windows.Forms.ComboBox();
            this.MetricLabel = new System.Windows.Forms.Label();
            this.DataTextBox = new System.Windows.Forms.TextBox();
            this.DataLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.sloDBDataSet = new SeniorProject.SloDBDataSet();
            this.measurementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.measurementTableAdapter = new SeniorProject.SloDBDataSetTableAdapters.MeasurementTableAdapter();
            this.sLOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sLOTableAdapter = new SeniorProject.SloDBDataSetTableAdapters.SLOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sloDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sLOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuControl
            // 
            this.MenuControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuControl.Location = new System.Drawing.Point(0, 0);
            this.MenuControl.Margin = new System.Windows.Forms.Padding(5);
            this.MenuControl.Name = "MenuControl";
            this.MenuControl.Size = new System.Drawing.Size(1067, 32);
            this.MenuControl.TabIndex = 0;
            // 
            // YearComboBox
            // 
            this.YearComboBox.FormattingEnabled = true;
            this.YearComboBox.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035"});
            this.YearComboBox.Location = new System.Drawing.Point(140, 76);
            this.YearComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.YearComboBox.Name = "YearComboBox";
            this.YearComboBox.Size = new System.Drawing.Size(160, 24);
            this.YearComboBox.TabIndex = 1;
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(140, 48);
            this.YearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(36, 16);
            this.YearLabel.TabIndex = 2;
            this.YearLabel.Text = "Year";
            // 
            // SloSelectComboBox
            // 
            this.SloSelectComboBox.DataSource = this.sLOBindingSource;
            this.SloSelectComboBox.DisplayMember = "Title";
            this.SloSelectComboBox.FormattingEnabled = true;
            this.SloSelectComboBox.Location = new System.Drawing.Point(140, 165);
            this.SloSelectComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.SloSelectComboBox.Name = "SloSelectComboBox";
            this.SloSelectComboBox.Size = new System.Drawing.Size(160, 24);
            this.SloSelectComboBox.TabIndex = 3;
            // 
            // SloSelectLabel
            // 
            this.SloSelectLabel.AutoSize = true;
            this.SloSelectLabel.Location = new System.Drawing.Point(140, 134);
            this.SloSelectLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SloSelectLabel.Name = "SloSelectLabel";
            this.SloSelectLabel.Size = new System.Drawing.Size(33, 16);
            this.SloSelectLabel.TabIndex = 4;
            this.SloSelectLabel.Text = "SLO";
            // 
            // MetricComboBox
            // 
            this.MetricComboBox.DataSource = this.measurementBindingSource;
            this.MetricComboBox.DisplayMember = "Title";
            this.MetricComboBox.FormattingEnabled = true;
            this.MetricComboBox.Location = new System.Drawing.Point(140, 245);
            this.MetricComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.MetricComboBox.Name = "MetricComboBox";
            this.MetricComboBox.Size = new System.Drawing.Size(160, 24);
            this.MetricComboBox.TabIndex = 5;
            // 
            // MetricLabel
            // 
            this.MetricLabel.AutoSize = true;
            this.MetricLabel.Location = new System.Drawing.Point(140, 219);
            this.MetricLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MetricLabel.Name = "MetricLabel";
            this.MetricLabel.Size = new System.Drawing.Size(43, 16);
            this.MetricLabel.TabIndex = 6;
            this.MetricLabel.Text = "Metric";
            // 
            // DataTextBox
            // 
            this.DataTextBox.Location = new System.Drawing.Point(140, 331);
            this.DataTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.Size = new System.Drawing.Size(132, 22);
            this.DataTextBox.TabIndex = 7;
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.Location = new System.Drawing.Point(140, 308);
            this.DataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(112, 16);
            this.DataLabel.TabIndex = 8;
            this.DataLabel.Text = "Aggregate Grade";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(923, 478);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 28);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(140, 393);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 28);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(651, 478);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(100, 28);
            this.RemoveButton.TabIndex = 12;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // sloDBDataSet
            // 
            this.sloDBDataSet.DataSetName = "SloDBDataSet";
            this.sloDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // measurementBindingSource
            // 
            this.measurementBindingSource.DataMember = "Measurement";
            this.measurementBindingSource.DataSource = this.sloDBDataSet;
            // 
            // measurementTableAdapter
            // 
            this.measurementTableAdapter.ClearBeforeFill = true;
            // 
            // sLOBindingSource
            // 
            this.sLOBindingSource.DataMember = "SLO";
            this.sLOBindingSource.DataSource = this.sloDBDataSet;
            // 
            // sLOTableAdapter
            // 
            this.sLOTableAdapter.ClearBeforeFill = true;
            // 
            // EnterDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.DataTextBox);
            this.Controls.Add(this.MetricLabel);
            this.Controls.Add(this.MetricComboBox);
            this.Controls.Add(this.SloSelectLabel);
            this.Controls.Add(this.SloSelectComboBox);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.YearComboBox);
            this.Controls.Add(this.MenuControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EnterDataForm";
            this.Text = "AddData";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnterData_FormClosed);
            this.Load += new System.EventHandler(this.EnterDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sloDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sLOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuControl MenuControl;
        private System.Windows.Forms.ComboBox YearComboBox;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.ComboBox SloSelectComboBox;
        private System.Windows.Forms.Label SloSelectLabel;
        private System.Windows.Forms.ComboBox MetricComboBox;
        private System.Windows.Forms.Label MetricLabel;
        private System.Windows.Forms.TextBox DataTextBox;
        private System.Windows.Forms.Label DataLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private SloDBDataSet sloDBDataSet;
        private System.Windows.Forms.BindingSource measurementBindingSource;
        private SloDBDataSetTableAdapters.MeasurementTableAdapter measurementTableAdapter;
        private System.Windows.Forms.BindingSource sLOBindingSource;
        private SloDBDataSetTableAdapters.SLOTableAdapter sLOTableAdapter;
    }
}