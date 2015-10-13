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
    public partial class AddModule : Form
    {
        protected Course course;
        protected Level level;
        protected Module module;
        protected int maxcredit;
        protected FormClosedEventHandler updateOnCloseHandler;

        public AddModule(FormClosedEventHandler onClose, Course course, Level level, int maxcredit, Module module = null)
        {
            this.course = course;
            this.level = level;
            this.module = module;
            this.maxcredit = maxcredit;
            this.updateOnCloseHandler = onClose;
            InitializeComponent();

            if (this.module != null)
            {
                this.ModuleCodeText.Text = module.getCode();
                this.ModuleTitleText.Text = module.getName();
                if(module.getCredit() == 15)
                {
                    Credit15.Checked = true;
                }
                else
                {
                    Credit30.Checked = true;
                }

                this.maxcredit += module.getCredit();
            }

            this.FormClosed += onClose;
            this.Focus();
        }

        private void ModuleSaveButton_Click(object sender, EventArgs e)
        {
            String Code = ModuleCodeText.Text.Trim();
            String Name = ModuleTitleText.Text.Trim();

            if (Name.Equals("") || Code.Equals(""))
            {
				MessageBox.Show("Module Name/Code is empty.", "Error?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            int cred;
            if (Credit15.Checked)
            {
                cred = 15;
            }
            else
            {
                cred = 30;
            }

            if(cred > maxcredit)
            {
				MessageBox.Show("Credit limit exceeded.", "Error?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (module == null)
            {
                module = course.addModule(level, Code, Name, cred);
            }
            else
            {
                module.setCode(Code);
                module.setName(Name);
                module.setCredit(cred);
            }
            
            ListAssessments form = new ListAssessments(updateOnCloseHandler, module);
            this.Close();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
