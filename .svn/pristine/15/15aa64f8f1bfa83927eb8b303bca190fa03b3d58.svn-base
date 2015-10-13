using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CW2_OOD
{
    class SummaryModuleGroup
    {
        public Label modCode;
        public Label modName;
        public Label modCerdits;
        public Label modAvg;
        public Label modStatus;

        public Panel root;
        public Level level;
        public Module module;

        public SummaryModuleGroup(Level level, Module module, Panel root)
        {
            this.root = root;
            this.level = level;
            this.module = module;
            
            modCode = new Label();
            modName = new Label();
            modCerdits = new Label();
            modAvg = new Label();
            modStatus = new Label();
        }

        public void addControls(Point point, out Point next)
        {
            bool failed;
            int weight = module.sumAssessmentWeight();
            double moduleScore = module.score(out failed);

            Point curpoint = new Point(point.X, point.Y);
            modCode.Text = module.getCode() ;
            modCode.Location = curpoint;
            modCode.Width -= 40;
            curpoint = new Point(curpoint.X + modCode.Width + 5, curpoint.Y);

            modName.Text =  module.getName();
            modName.Location = curpoint;
            modName.Width += 120;
            curpoint = new Point(curpoint.X + modName.Width, curpoint.Y);

            modCerdits.Text = "Credits " + module.getCredit().ToString();
            modCerdits.Location = curpoint;
            modCerdits.Width -= 30;
            curpoint = new Point(curpoint.X + modCerdits.Width + 5, curpoint.Y);
            
            modAvg.Text = "Overall: " + moduleScore + "%" + (weight < 100 ? " (incomplete)" : "");
            modAvg.Location = curpoint;
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
            modAvg.Width += 50;
            curpoint = new Point(curpoint.X + modAvg.Width + 5, curpoint.Y);

            modStatus.Text = moduleScore >= 40.0 && !failed ? "Pass" : (moduleScore >= 30.0 && !failed ? "Reffered" : "Fail");
            modStatus.Location = curpoint;
            curpoint = new Point(curpoint.X + modStatus.Width + 5, curpoint.Y);

            root.Controls.Add(modCode);
            root.Controls.Add(modName);
            root.Controls.Add(modCerdits);
            root.Controls.Add(modAvg);
            root.Controls.Add(modStatus);

            next = new Point(point.X, curpoint.Y + modCerdits.Height);
        }

        public void removeControls()
        {
            root.Controls.Remove(modCode);
            root.Controls.Remove(modName);
            root.Controls.Remove(modCerdits);
            root.Controls.Remove(modAvg);
            root.Controls.Remove(modStatus);
        }
    }
}
