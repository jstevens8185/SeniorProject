namespace SeniorProject
{
    partial class MainMenu
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
            this.EnterDataButton = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.AddSLOButton = new System.Windows.Forms.Button();
            this.menuControl1 = new SeniorProject.MenuControl();
            this.SuspendLayout();
            // 
            // EnterDataButton
            // 
            this.EnterDataButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterDataButton.Location = new System.Drawing.Point(43, 67);
            this.EnterDataButton.Name = "EnterDataButton";
            this.EnterDataButton.Size = new System.Drawing.Size(120, 35);
            this.EnterDataButton.TabIndex = 0;
            this.EnterDataButton.Text = "Enter Data";
            this.EnterDataButton.UseVisualStyleBackColor = true;
            this.EnterDataButton.Click += new System.EventHandler(this.EnterDataButton_Click);
            // 
            // ViewButton
            // 
            this.ViewButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewButton.Location = new System.Drawing.Point(43, 142);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(120, 35);
            this.ViewButton.TabIndex = 1;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ReportsButton_Click);
            // 
            // AddSLOButton
            // 
            this.AddSLOButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSLOButton.Location = new System.Drawing.Point(43, 217);
            this.AddSLOButton.Name = "AddSLOButton";
            this.AddSLOButton.Size = new System.Drawing.Size(120, 35);
            this.AddSLOButton.TabIndex = 3;
            this.AddSLOButton.Text = "Add SLO";
            this.AddSLOButton.UseVisualStyleBackColor = true;
            this.AddSLOButton.Click += new System.EventHandler(this.NewSLOButton_Click);
            // 
            // menuControl1
            // 
            this.menuControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuControl1.Location = new System.Drawing.Point(0, 0);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(207, 29);
            this.menuControl1.TabIndex = 2;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(207, 309);
            this.Controls.Add(this.AddSLOButton);
            this.Controls.Add(this.menuControl1);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.EnterDataButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EnterDataButton;
        private System.Windows.Forms.Button ViewButton;
        private MenuControl menuControl1;
        private System.Windows.Forms.Button AddSLOButton;
    }
}