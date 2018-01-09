using StuQuery.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuQuery
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ESRI.ArcGIS.RuntimeManager.Bind(ESRI.ArcGIS.ProductCode.Engine);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //loginForm lg = new loginForm();
            //lg.ShowDialog();

            //if (lg.DialogResult == DialogResult.OK)
            //{
                Application.Run(new Form1());
            //}
            //else
            //{
            //    return;
            //}
        }
    }
}
