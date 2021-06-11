using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using demo1.Model;
namespace demo1
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
            AppDBContext appDBContext = new AppDBContext();
            appDBContext.Accounts.ToList();
            Application.Run(new Form_MNG());
        }
    }
}
