using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CW2_OOD
{
    class ModuleControlGroup
    {
        public Label modCodeLabel;
        public Label modName;
        public Label modCerdits;
        public Button modAssessments;
        public Button modEdit;
        public Button modDelete;
        public Label modAvg;
        public Label modStatus;

        public Panel root;
        public Course course;
        public Level level;
        public Module module;

        public int maxcredit;

        public FormClosedEventHandler updateTabFCEH;
        public EventHandler updateTabEH;

        public ModuleControlGroup(FormClosedEventHandler updateTabFCEH, EventHandler updateTabEH, Course course, Level level, int maxcredit, Module module, Panel root)
        {
            this.root = root;
            this.course = course;
            this.level = level;
            this.module = module;
            this.maxcredit = maxcredit;

            this.updateTabFCEH = updateTabFCEH;
            this.updateTabEH = updateTabEH;

            modCodeLabel = new Label();
            modName = new Label();
            modCerdits = new Label();

            modAssessments = new Button();
            modEdit = new Button();
            modDelete = new Button();

            modAvg = new Label();
            modStatus = new Label();
        }

        public void addControls(Point point, out Point next)
        {
            bool failed;
            int weight = module.sumAssessmentWeight();
            double moduleScore = module.score(out failed);

            Point curpoint = new Point(point.X, point.Y);
            modCodeLabel.Text = "Code: "+module.getCode() ;
            modCodeLabel.Location = curpoint;
            curpoint = new Point(curpoint.X + modCodeLabel.Width + 5, curpoint.Y);

            modName.Text = "Name: " + module.getName();
            modName.Location = curpoint;
            modName.Width += 120;
            curpoint = new Point(curpoint.X + modName.Width + 5, curpoint.Y);

            modCerdits.Text = "Credits " + module.getCredit().ToString();
            modCerdits.Location = curpoint;
            modCerdits.Width -= 30;
            curpoint = new Point(curpoint.X + modCerdits.Width + 5, curpoint.Y);
            

            modAssessments.Text = "Assessments";
            modAssessments.Location = curpoint;
            modAssessments.Click += new EventHandler(moduleAssessments_Click);
            curpoint = new Point(curpoint.X + modAssessments.Width + 5, curpoint.Y);

            modEdit.Text = "Edit";
            modEdit.Location = curpoint;
            modEdit.Click += new EventHandler(moduleEdit_Click);
            curpoint = new Point(curpoint.X + modEdit.Width + 5, curpoint.Y);

            modDelete.Text = "Delete";
            modDelete.Location = curpoint;
            modDelete.Click += new EventHandler(moduleDelete_Click);
            modDelete.Click += updateTabEH;
            curpoint = new Point(curpoint.X + modDelete.Width + 5, curpoint.Y);

            modAvg.Text = "Average: " + moduleScore + "%" + (weight < 100 ? " (incomplete)" : "");
            modAvg.Location = curpoint;
            modAvg.Width += 50;
            if (moduleScore <= 30)
            {
                modAvg.ForeColor = System.Drawing.Color.Red;
            }
            else if (moduleScore >= 30 && moduleScore < 60)
            {
                modAvg.ForeColor = System.Drawing.Color.Green;
            }
            else if (moduleScore >= 60)
            {
                modAvg.ForeColor = System.Drawing.Color.Blue;
            }
            curpoint = new Point(curpoint.X + modAvg.Width + 5, curpoint.Y);

            modStatus.Text = moduleScore >= 40.0 && !failed ? "Pass" : (moduleScore >= 30.0 && !failed ? "Reffered" : "Fail");
            modStatus.Location = curpoint;
            curpoint = new Point(curpoint.X + modStatus.Width + 5, curpoint.Y);

            root.Controls.Add(modCodeLabel);
            root.Controls.Add(modName);
            root.Controls.Add(modCerdits);
            root.Controls.Add(modAssessments);
            root.Controls.Add(modEdit);
            root.Controls.Add(modDelete);
            root.Controls.Add(modAvg);
            root.Controls.Add(modStatus);

            next = new Point(point.X, point.Y + modAssessments.Height);
        }

        public void removeControls()
        {
            root.Controls.Remove(modCodeLabel);
            root.Controls.Remove(modName);
            root.Controls.Remove(modCerdits);
            root.Controls.Remove(modAssessments);
            root.Controls.Remove(modEdit);
            root.Controls.Remove(modDelete);
            root.Controls.Remove(modAvg);
            root.Controls.Remove(modStatus);
        }

        public void moduleAssessments_Click(object sender, EventArgs args)
        {
            ListAssessments form = new ListAssessments(updateTabFCEH, module);
            form.Show();
        }

        public void moduleEdit_Click(object sender, EventArgs args)
        {
            AddModule form = new AddModule(updateTabFCEH, course, level, maxcredit, module);
            form.Show();
        }

        public void moduleDelete_Click(object sender, EventArgs args)
        {
            course.delModule(level, module);
        }
    }
}
