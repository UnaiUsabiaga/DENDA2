namespace ERRONKA7
{
    internal static class Program
    {
        public static login loginForm;
        public static AdminLogin adminLoginForm;
        public static langileaLogin langileaLoginForm;
        public static bErregistroBerria datuakForm;
        public static adminMenu adminMenuForm;
        public static datuakBistaratu datuakBistaratuForm;


        /// <summary>
        ///  The main entry point for the application
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            loginForm = new login();
            adminLoginForm = new AdminLogin();
            langileaLoginForm = new langileaLogin();
            datuakForm = new bErregistroBerria();
            adminMenuForm = new adminMenu();
            datuakBistaratuForm = new datuakBistaratu();


            Application.Run(loginForm);

        }
    }
}