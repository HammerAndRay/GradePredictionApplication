﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW2_OOD
{
    public partial class AddAssessment : Form
    {
        Module module;
        Assessment assessment;
        int maxweight;

        public AddAssessment(FormClosedEventHandler onClose, Module module, int maxweight, Assessment assessment = null)
        {
            this.module = module;
            this.assessment = assessment;
            this.maxweight = maxweight;

            InitializeComponent();

            if (this.assessment != null)
            {
                this.AssessmentNameText.Text = assessment.getName();
                this.AssessmentMarkNUD.Value = (decimal)assessment.getMark();
                this.AssessmentWeightNUD.Value = (decimal)assessment.getWeight();
                this.maxweight += this.assessment.getWeight();
            }

            this.FormClosed += onClose;
            this.Focus();
        }

        private void AssessmentSubmitButton_Click(object sender, EventArgs e)
        {
            string Name = AssessmentNameText.Text.Trim();
            int Mark = (int)AssessmentMarkNUD.Value;
            int Weight = (int)AssessmentWeightNUD.Value;

            if(Name.Equals(""))
            {
				MessageBox.Show("Enter Name for Assessment.", "Error?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Weight > maxweight)
            {
				MessageBox.Show("Assessment weight is greater then maximum (" + maxweight + "%).", "Error?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (Weight == 0) 
            {
				MessageBox.Show("Weight cant not be 0.", "Error?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (assessment == null)
            {
                module.addAssessment(Name, Mark, Weight);
            }
            else
            {
                assessment.setName(Name);
                assessment.setMark(Mark);
                assessment.setWeight(Weight);
            }

            this.Close();
        }


    }
}
