using System;
using System.Windows.Forms;
using Lab2;
using Lab4.Controllers;
using Lab4.View;

namespace Lab2
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Univercity U = new Univercity("test"); 
            Demo.InitializeUnivercity(U);
            Demo.ShowMenu(U);

            GroupsFormController controller = new GroupsFormController(U);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GroupsForm(controller));
        }       
    }
}
