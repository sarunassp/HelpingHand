using System;
using System.Windows.Forms;
using GREEDY.refactor.DataManagers;
using GREEDY.refactor.OCRs;
using GREEDY.refactor.Services;
using GREEDY.refactor.View;

namespace GREEDY.refactor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main ()
        {
            Application.EnableVisualStyles ();
            Application.SetCompatibleTextRenderingDefault (false);
            Application.Run 
            (
                new Greedy 
                (
                    new ReceiptService 
                    (
                        new EmguOcr (new AppConfig ()),
                        new DataConverter (), 
                        new DataManager ()
                    )
                )
            );
        }
    }
}
