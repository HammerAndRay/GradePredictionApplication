﻿namespace CW2_OOD
{
    partial class AddAssessment
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AssessmentNameText = new System.Windows.Forms.TextBox();
            this.AssessmentSubmitButton = new System.Windows.Forms.Button();
            this.AssessmentMarkNUD = new System.Windows.Forms.NumericUpDown();
            this.AssessmentWeightNUD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.AssessmentMarkNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssessmentWeightNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assessment Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Assessment Weight:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Assessment Mark:";
            // 
            // AssessmentNameText
            // 
            this.AssessmentNameText.Location = new System.Drawing.Point(134, 12);
            this.AssessmentNameText.Name = "AssessmentNameText";
            this.AssessmentNameText.Size = new System.Drawing.Size(120, 20);
            this.AssessmentNameText.TabIndex = 3;
            // 
            // AssessmentSubmitButton
            // 
            this.AssessmentSubmitButton.Location = new System.Drawing.Point(176, 90);
            this.AssessmentSubmitButton.Name = "AssessmentSubmitButton";
            this.AssessmentSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.AssessmentSubmitButton.TabIndex = 6;
            this.AssessmentSubmitButton.Text = "Submit";
            this.AssessmentSubmitButton.UseVisualStyleBackColor = true;
            this.AssessmentSubmitButton.Click += new System.EventHandler(this.AssessmentSubmitButton_Click);
            // 
            // AssessmentMarkNUD
            // 
            this.AssessmentMarkNUD.Location = new System.Drawing.Point(134, 38);
            this.AssessmentMarkNUD.Name = "AssessmentMarkNUD";
            this.AssessmentMarkNUD.Size = new System.Drawing.Size(120, 20);
            this.AssessmentMarkNUD.TabIndex = 7;
            // 
            // AssessmentWeightNUD
            // 
            this.AssessmentWeightNUD.Location = new System.Drawing.Point(134, 64);
            this.AssessmentWeightNUD.Name = "AssessmentWeightNUD";
            this.AssessmentWeightNUD.Size = new System.Drawing.Size(120, 20);
            this.AssessmentWeightNUD.TabIndex = 8;
            // 
            // AddAssessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 121);
            this.Controls.Add(this.AssessmentWeightNUD);
            this.Controls.Add(this.AssessmentMarkNUD);
            this.Controls.Add(this.AssessmentSubmitButton);
            this.Controls.Add(this.AssessmentNameText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddAssessment";
            this.Text = "AddAssessment";
            ((System.ComponentModel.ISupportInitialize)(this.AssessmentMarkNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssessmentWeightNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AssessmentNameText;
        private System.Windows.Forms.Button AssessmentSubmitButton;
        private System.Windows.Forms.NumericUpDown AssessmentMarkNUD;
        private System.Windows.Forms.NumericUpDown AssessmentWeightNUD;
    }
}