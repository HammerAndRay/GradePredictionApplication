namespace CW2_OOD
{
    partial class ListAssessments
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
            this.AddAsse = new System.Windows.Forms.Button();
            this.AssessmentsPanel = new System.Windows.Forms.Panel();
            this.CloseAsse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddAsse
            // 
            this.AddAsse.Location = new System.Drawing.Point(454, 12);
            this.AddAsse.Name = "AddAsse";
            this.AddAsse.Size = new System.Drawing.Size(99, 23);
            this.AddAsse.TabIndex = 25;
            this.AddAsse.Text = "Add Assessment";
            this.AddAsse.UseVisualStyleBackColor = true;
            this.AddAsse.Click += new System.EventHandler(this.AddAsse_Click);
            // 
            // AssessmentsPanel
            // 
            this.AssessmentsPanel.AutoScroll = true;
            this.AssessmentsPanel.Location = new System.Drawing.Point(12, 41);
            this.AssessmentsPanel.Name = "AssessmentsPanel";
            this.AssessmentsPanel.Size = new System.Drawing.Size(541, 261);
            this.AssessmentsPanel.TabIndex = 26;
            // 
            // CloseAsse
            // 
            this.CloseAsse.Location = new System.Drawing.Point(478, 308);
            this.CloseAsse.Name = "CloseAsse";
            this.CloseAsse.Size = new System.Drawing.Size(75, 23);
            this.CloseAsse.TabIndex = 29;
            this.CloseAsse.Text = "Submit";
            this.CloseAsse.UseVisualStyleBackColor = true;
            this.CloseAsse.Click += new System.EventHandler(this.CloseAsse_Click);
            // 
            // ListAssessments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 343);
            this.Controls.Add(this.CloseAsse);
            this.Controls.Add(this.AssessmentsPanel);
            this.Controls.Add(this.AddAsse);
            this.Name = "ListAssessments";
            this.Text = "Assessment";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddAsse;
        private System.Windows.Forms.Panel AssessmentsPanel;
        private System.Windows.Forms.Button CloseAsse;
    }
}