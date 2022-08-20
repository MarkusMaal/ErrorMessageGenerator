namespace ErrorMessageGenerator
{
    internal static class Program
    {

        public static bool ShowGUI = false;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            if (args.Contains("-forcegui"))
            {
                ShowGUI = true;
            }
            if (args.Length == 0)
            {
                ShowGUI = true;
                Application.Run(new Form1(""));
            }
            else
            {
                Application.Run(new Form1(args[0]));
            }
        }
    }
}