﻿namespace IfElse_Lesson
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClothing = new Button();
            cbxRaining = new CheckBox();
            cbxSunny = new CheckBox();
            cbxCold = new CheckBox();
            lblRaining = new Label();
            lblCold = new Label();
            lblSunny = new Label();
            SuspendLayout();
            // 
            // btnClothing
            // 
            btnClothing.Location = new Point(176, 23);
            btnClothing.Name = "btnClothing";
            btnClothing.Size = new Size(119, 86);
            btnClothing.TabIndex = 0;
            btnClothing.Text = "What Do I wear";
            btnClothing.UseVisualStyleBackColor = true;
            btnClothing.Click += btnClothing_Click;
            // 
            // cbxRaining
            // 
            cbxRaining.AutoSize = true;
            cbxRaining.Location = new Point(28, 33);
            cbxRaining.Name = "cbxRaining";
            cbxRaining.Size = new Size(92, 19);
            cbxRaining.TabIndex = 4;
            cbxRaining.Text = "Is it Raining?";
            cbxRaining.UseVisualStyleBackColor = true;
            cbxRaining.CheckedChanged += cbxRaining_CheckedChanged;
            // 
            // cbxSunny
            // 
            cbxSunny.AutoSize = true;
            cbxSunny.Location = new Point(28, 83);
            cbxSunny.Name = "cbxSunny";
            cbxSunny.Size = new Size(85, 19);
            cbxSunny.TabIndex = 5;
            cbxSunny.Text = "Is it Sunny?";
            cbxSunny.UseVisualStyleBackColor = true;
            cbxSunny.CheckedChanged += cbxSunny_CheckedChanged;
            // 
            // cbxCold
            // 
            cbxCold.AutoSize = true;
            cbxCold.Location = new Point(28, 58);
            cbxCold.Name = "cbxCold";
            cbxCold.Size = new Size(77, 19);
            cbxCold.TabIndex = 6;
            cbxCold.Text = "Is it Cold?";
            cbxCold.UseVisualStyleBackColor = true;
            cbxCold.CheckedChanged += cbxCold_CheckedChanged;
            // 
            // lblRaining
            // 
            lblRaining.AutoSize = true;
            lblRaining.Location = new Point(123, 33);
            lblRaining.Name = "lblRaining";
            lblRaining.Size = new Size(38, 15);
            lblRaining.TabIndex = 7;
            lblRaining.Text = "label1";
            // 
            // lblCold
            // 
            lblCold.AutoSize = true;
            lblCold.Location = new Point(123, 62);
            lblCold.Name = "lblCold";
            lblCold.Size = new Size(38, 15);
            lblCold.TabIndex = 8;
            lblCold.Text = "label1";
            // 
            // lblSunny
            // 
            lblSunny.AutoSize = true;
            lblSunny.Location = new Point(119, 87);
            lblSunny.Name = "lblSunny";
            lblSunny.Size = new Size(38, 15);
            lblSunny.TabIndex = 9;
            lblSunny.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 151);
            Controls.Add(lblSunny);
            Controls.Add(lblCold);
            Controls.Add(lblRaining);
            Controls.Add(cbxCold);
            Controls.Add(cbxSunny);
            Controls.Add(cbxRaining);
            Controls.Add(btnClothing);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClothing;
        private CheckBox cbxRaining;
        private CheckBox cbxSunny;
        private CheckBox cbxCold;
        private Label lblRaining;
        private Label lblCold;
        private Label lblSunny;
    }
}
