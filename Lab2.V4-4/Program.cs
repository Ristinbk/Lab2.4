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
      //      Demo.ShowMenu(U);

            UnivercityFormController controller = new UnivercityFormController(U);
       //     SessionsFormController controller1 = new SessionsFormController(U);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UnivercityForm(controller));
       //     Application.Run(new SessionForm(controller1));
        }       
    }
}
