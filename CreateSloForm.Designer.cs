namespace SeniorProject
{
    partial class CreateSloForm
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
            this.SLONameLabel = new System.Windows.Forms.Label();
            this.MetricLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DataTypeBox = new System.Windows.Forms.ComboBox();
            this.DataTypeLabel = new System.Windows.Forms.Label();
            this.AddMetricButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SaveSLOButton = new System.Windows.Forms.Button();
            this.menuControl1 = new SeniorProject.MenuControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sloDBDataSet = new SeniorProject.SloDBDataSet();
            this.sloDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sloDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sloDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SLONameLabel
            // 
            this.SLONameLabel.AutoSize = true;
            this.SLONameLabel.Location = new System.Drawing.Point(117, 64);
            this.SLONameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SLONameLabel.Name = "SLONameLabel";
            this.SLONameLabel.Size = new System.Drawing.Size(104, 16);
            this.SLONameLabel.TabIndex = 0;
            this.SLONameLabel.Text = "SLO Description";
            // 
            // MetricLabel
            // 
            this.MetricLabel.AutoSize = true;
            this.MetricLabel.Location = new System.Drawing.Point(117, 123);
            this.MetricLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MetricLabel.Name = "MetricLabel";
            this.MetricLabel.Size = new System.Drawing.Size(114, 16);
            this.MetricLabel.TabIndex = 2;
            this.MetricLabel.Text = "Metric Description";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 143);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(533, 22);
            this.textBox2.TabIndex = 4;
            // 
            // DataTypeBox
            // 
            this.DataTypeBox.FormattingEnabled = true;
            this.DataTypeBox.Items.AddRange(new object[] {
            "# Students",
            "Percentage",
            "T/F"});
            this.DataTypeBox.Location = new System.Drawing.Point(121, 202);
            this.DataTypeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataTypeBox.Name = "DataTypeBox";
            this.DataTypeBox.Size = new System.Drawing.Size(160, 24);
            this.DataTypeBox.TabIndex = 5;
            // 
            // DataTypeLabel
            // 
            this.DataTypeLabel.AutoSize = true;
            this.DataTypeLabel.Location = new System.Drawing.Point(117, 182);
            this.DataTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DataTypeLabel.Name = "DataTypeLabel";
            this.DataTypeLabel.Size = new System.Drawing.Size(68, 16);
            this.DataTypeLabel.TabIndex = 6;
            this.DataTypeLabel.Text = "DataType";
            // 
            // AddMetricButton
            // 
            this.AddMetricButton.Location = new System.Drawing.Point(121, 252);
            this.AddMetricButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddMetricButton.Name = "AddMetricButton";
            this.AddMetricButton.Size = new System.Drawing.Size(100, 28);
            this.AddMetricButton.TabIndex = 7;
            this.AddMetricButton.Text = "Add Metric";
            this.AddMetricButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 84);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(533, 22);
            this.textBox1.TabIndex = 1;
            // 
            // SaveSLOButton
            // 
            this.SaveSLOButton.Location = new System.Drawing.Point(121, 491);
            this.SaveSLOButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveSLOButton.Name = "SaveSLOButton";
            this.SaveSLOButton.Size = new System.Drawing.Size(100, 28);
            this.SaveSLOButton.TabIndex = 8;
            this.SaveSLOButton.Text = "Save SLO";
            this.SaveSLOButton.UseVisualStyleBackColor = true;
            // 
            // menuControl1
            // 
            this.menuControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuControl1.Location = new System.Drawing.Point(0, 0);
            this.menuControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(1067, 37);
            this.menuControl1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.sloDBDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(568, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // sloDBDataSet
            // 
            this.sloDBDataSet.DataSetName = "SloDBDataSet";
            this.sloDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sloDBDataSetBindingSource
            // 
            this.sloDBDataSetBindingSource.DataSource = this.sloDBDataSet;
            this.sloDBDataSetBindingSource.Position = 0;
            // 
            // CreateSloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuControl1);
            this.Controls.Add(this.SaveSLOButton);
            this.Controls.Add(this.AddMetricButton);
            this.Controls.Add(this.DataTypeLabel);
            this.Controls.Add(this.DataTypeBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.MetricLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SLONameLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreateSloForm";
            this.Text = "CreateSloForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateSloForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sloDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sloDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SLONameLabel;
        private System.Windows.Forms.Label MetricLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox DataTypeBox;
        private System.Windows.Forms.Label DataTypeLabel;
        private System.Windows.Forms.Button AddMetricButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SaveSLOButton;
        private MenuControl menuControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sloDBDataSetBindingSource;
        private SloDBDataSet sloDBDataSet;
    }
}