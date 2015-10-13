using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW2_OOD
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainPage());

            /* Small code example of using the GPAState object(s) */
            /*
            GPAState state = new GPAState();
            Course course;
            Module mod;
            Assessment ass;

            state.load("state.xml");
            course = state.getCourse();
            mod = course.addModule(Level.LEVEL_5, "Object Oriented Development");
            mod.addAssessment("Coursework 2", 100);
            state.save("state.xml");
            */
        }
    }
}
