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
            this.SLONameLabel = new System.Windows.Forms.Label();
            this.MetricLabel = new System.Windows.Forms.Label();
            this.MetricsTextBox = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DataTypeBox = new System.Windows.Forms.ComboBox();
            this.DataTypeLabel = new System.Windows.Forms.Label();
            this.AddMetricButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SaveSLOButton = new System.Windows.Forms.Button();
            this.menuControl1 = new SeniorProject.MenuControl();
            this.SuspendLayout();
            // 
            // SLONameLabel
            // 
            this.SLONameLabel.AutoSize = true;
            this.SLONameLabel.Location = new System.Drawing.Point(88, 52);
            this.SLONameLabel.Name = "SLONameLabel";
            this.SLONameLabel.Size = new System.Drawing.Size(84, 13);
            this.SLONameLabel.TabIndex = 0;
            this.SLONameLabel.Text = "SLO Description";
            // 
            // MetricLabel
            // 
            this.MetricLabel.AutoSize = true;
            this.MetricLabel.Location = new System.Drawing.Point(88, 100);
            this.MetricLabel.Name = "MetricLabel";
            this.MetricLabel.Size = new System.Drawing.Size(92, 13);
            this.MetricLabel.TabIndex = 2;
            this.MetricLabel.Text = "Metric Description";
            // 
            // MetricsTextBox
            // 
            this.MetricsTextBox.Location = new System.Drawing.Point(554, 62);
            this.MetricsTextBox.Name = "MetricsTextBox";
            this.MetricsTextBox.Size = new System.Drawing.Size(196, 342);
            this.MetricsTextBox.TabIndex = 3;
            this.MetricsTextBox.Text = "";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(401, 20);
            this.textBox2.TabIndex = 4;
            // 
            // DataTypeBox
            // 
            this.DataTypeBox.FormattingEnabled = true;
            this.DataTypeBox.Items.AddRange(new object[] {
            "# Students",
            "Percentage",
            "T/F"});
            this.DataTypeBox.Location = new System.Drawing.Point(91, 164);
            this.DataTypeBox.Name = "DataTypeBox";
            this.DataTypeBox.Size = new System.Drawing.Size(121, 21);
            this.DataTypeBox.TabIndex = 5;
            // 
            // DataTypeLabel
            // 
            this.DataTypeLabel.AutoSize = true;
            this.DataTypeLabel.Location = new System.Drawing.Point(88, 148);
            this.DataTypeLabel.Name = "DataTypeLabel";
            this.DataTypeLabel.Size = new System.Drawing.Size(54, 13);
            this.DataTypeLabel.TabIndex = 6;
            this.DataTypeLabel.Text = "DataType";
            // 
            // AddMetricButton
            // 
            this.AddMetricButton.Location = new System.Drawing.Point(91, 205);
            this.AddMetricButton.Name = "AddMetricButton";
            this.AddMetricButton.Size = new System.Drawing.Size(75, 23);
            this.AddMetricButton.TabIndex = 7;
            this.AddMetricButton.Text = "Add Metric";
            this.AddMetricButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(401, 20);
            this.textBox1.TabIndex = 1;
            // 
            // SaveSLOButton
            // 
            this.SaveSLOButton.Location = new System.Drawing.Point(91, 399);
            this.SaveSLOButton.Name = "SaveSLOButton";
            this.SaveSLOButton.Size = new System.Drawing.Size(75, 23);
            this.SaveSLOButton.TabIndex = 8;
            this.SaveSLOButton.Text = "Save SLO";
            this.SaveSLOButton.UseVisualStyleBackColor = true;
            // 
            // menuControl1
            // 
            this.menuControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuControl1.Location = new System.Drawing.Point(0, 0);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(800, 30);
            this.menuControl1.TabIndex = 9;
            // 
            // CreateSloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuControl1);
            this.Controls.Add(this.SaveSLOButton);
            this.Controls.Add(this.AddMetricButton);
            this.Controls.Add(this.DataTypeLabel);
            this.Controls.Add(this.DataTypeBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.MetricsTextBox);
            this.Controls.Add(this.MetricLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SLONameLabel);
            this.Name = "CreateSloForm";
            this.Text = "CreateSloForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateSloForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SLONameLabel;
        private System.Windows.Forms.Label MetricLabel;
        private System.Windows.Forms.RichTextBox MetricsTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox DataTypeBox;
        private System.Windows.Forms.Label DataTypeLabel;
        private System.Windows.Forms.Button AddMetricButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SaveSLOButton;
        private MenuControl menuControl1;
    }
}