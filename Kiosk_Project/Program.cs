namespace Kiosk_Project
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
            Application.Run(new Kiosk_Front());
            //Application.Run(new Ticket_Buy());
            //Application.Run(new Seet_Select());
            //Application.Run(new Select_Person());
            //Application.Run(new Ticket_Pay());
        }
    }
}