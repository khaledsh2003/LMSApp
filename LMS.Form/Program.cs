using LMS.Bl.file;
using LMS.BL.Interface;

namespace LMS.From
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            IUserManager userManager = new UserFile();
            IBookManager bookManager = new Bookfile();
            Application.Run(new Form1(userManager,bookManager));
        }
    }
}