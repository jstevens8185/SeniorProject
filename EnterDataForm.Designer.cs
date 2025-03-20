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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuControl
            // 
            this.MenuControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuControl.Location = new System.Drawing.Point(0, 0);
            this.MenuControl.Name = "MenuControl";
            this.MenuControl.Size = new System.Drawing.Size(800, 26);
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
            this.YearComboBox.Location = new System.Drawing.Point(105, 62);
            this.YearComboBox.Name = "YearComboBox";
            this.YearComboBox.Size = new System.Drawing.Size(121, 21);
            this.YearComboBox.TabIndex = 1;
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(105, 39);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(29, 13);
            this.YearLabel.TabIndex = 2;
            this.YearLabel.Text = "Year";
            // 
            // SloSelectComboBox
            // 
            this.SloSelectComboBox.FormattingEnabled = true;
            this.SloSelectComboBox.Location = new System.Drawing.Point(105, 134);
            this.SloSelectComboBox.Name = "SloSelectComboBox";
            this.SloSelectComboBox.Size = new System.Drawing.Size(121, 21);
            this.SloSelectComboBox.TabIndex = 3;
            // 
            // SloSelectLabel
            // 
            this.SloSelectLabel.AutoSize = true;
            this.SloSelectLabel.Location = new System.Drawing.Point(105, 109);
            this.SloSelectLabel.Name = "SloSelectLabel";
            this.SloSelectLabel.Size = new System.Drawing.Size(28, 13);
            this.SloSelectLabel.TabIndex = 4;
            this.SloSelectLabel.Text = "SLO";
            // 
            // MetricComboBox
            // 
            this.MetricComboBox.FormattingEnabled = true;
            this.MetricComboBox.Location = new System.Drawing.Point(105, 199);
            this.MetricComboBox.Name = "MetricComboBox";
            this.MetricComboBox.Size = new System.Drawing.Size(121, 21);
            this.MetricComboBox.TabIndex = 5;
            // 
            // MetricLabel
            // 
            this.MetricLabel.AutoSize = true;
            this.MetricLabel.Location = new System.Drawing.Point(105, 178);
            this.MetricLabel.Name = "MetricLabel";
            this.MetricLabel.Size = new System.Drawing.Size(36, 13);
            this.MetricLabel.TabIndex = 6;
            this.MetricLabel.Text = "Metric";
            // 
            // DataTextBox
            // 
            this.DataTextBox.Location = new System.Drawing.Point(105, 269);
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.Size = new System.Drawing.Size(100, 20);
            this.DataTextBox.TabIndex = 7;
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.Location = new System.Drawing.Point(105, 250);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(88, 13);
            this.DataLabel.TabIndex = 8;
            this.DataLabel.Text = "Aggregate Grade";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(692, 388);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(105, 319);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(488, 388);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 12;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(488, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // EnterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
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
            this.Name = "EnterData";
            this.Text = "AddData";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnterData_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}