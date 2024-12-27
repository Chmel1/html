namespace Exam
{
    internal static class Program
    {
        public static int VariantNumber = 17;
        private static DB.User? _currentUser;
        internal static bool _isAuth = false;
        public static bool isAuth { get => _isAuth; } 
        public static DB.User? CurrentUser { get =>_currentUser; set { Program._isAuth = true; _currentUser = value; } }
        
        public static string applicationName = Helpers.getApplicationName.getName(Program.VariantNumber);
        public static DB.ApplicationContext DBContext = new();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

       
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();

            DB.DataFixtures.loadFixtures();

            Application.Run(new AuthForm());

            if (Program.isAuth)
            {
                Application.Run(new MainForm());
            }

        }
    }
}