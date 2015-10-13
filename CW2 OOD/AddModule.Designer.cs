﻿namespace CW2_OOD
{
    partial class AddModule
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
            this.label1 = new System.Windows.Forms.Label();
            this.ModuleTitleText = new System.Windows.Forms.TextBox();
            this.ModuleSaveButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Credit15 = new System.Windows.Forms.RadioButton();
            this.Credit30 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.ModuleCodeText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Module Title";
            // 
            // ModuleTitleText
            // 
            this.ModuleTitleText.Location = new System.Drawing.Point(160, 33);
            this.ModuleTitleText.Name = "ModuleTitleText";
            this.ModuleTitleText.Size = new System.Drawing.Size(100, 20);
            this.ModuleTitleText.TabIndex = 2;
            // 
            // ModuleSaveButton
            // 
            this.ModuleSaveButton.Location = new System.Drawing.Point(185, 94);
            this.ModuleSaveButton.Name = "ModuleSaveButton";
            this.ModuleSaveButton.Size = new System.Drawing.Size(75, 23);
            this.ModuleSaveButton.TabIndex = 6;
            this.ModuleSaveButton.Text = "Save";
            this.ModuleSaveButton.UseVisualStyleBackColor = true;
            this.ModuleSaveButton.Click += new System.EventHandler(this.ModuleSaveButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Credit Value";
            // 
            // Credit15
            // 
            this.Credit15.AutoSize = true;
            this.Credit15.Checked = true;
            this.Credit15.Location = new System.Drawing.Point(85, 60);
            this.Credit15.Name = "Credit15";
            this.Credit15.Size = new System.Drawing.Size(37, 17);
            this.Credit15.TabIndex = 3;
            this.Credit15.TabStop = true;
            this.Credit15.Text = "15";
            this.Credit15.UseVisualStyleBackColor = true;
            // 
            // Credit30
            // 
            this.Credit30.AutoSize = true;
            this.Credit30.Location = new System.Drawing.Point(128, 60);
            this.Credit30.Name = "Credit30";
            this.Credit30.Size = new System.Drawing.Size(37, 17);
            this.Credit30.TabIndex = 4;
            this.Credit30.Text = "30";
            this.Credit30.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Enter Module Code";
            // 
            // ModuleCodeText
            // 
            this.ModuleCodeText.Location = new System.Drawing.Point(160, 13);
            this.ModuleCodeText.Name = "ModuleCodeText";
            this.ModuleCodeText.Size = new System.Drawing.Size(100, 20);
            this.ModuleCodeText.TabIndex = 1;
            // 
            // AddModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 129);
            this.Controls.Add(this.ModuleCodeText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Credit30);
            this.Controls.Add(this.Credit15);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ModuleSaveButton);
            this.Controls.Add(this.ModuleTitleText);
            this.Controls.Add(this.label1);
            this.Name = "AddModule";
            this.Text = "AddModule";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ModuleTitleText;
        private System.Windows.Forms.Button ModuleSaveButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Credit15;
        private System.Windows.Forms.RadioButton Credit30;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ModuleCodeText;
    }
}