namespace NHSCapacityAndDemandPlanner
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

            var splash = new SplashWindow();
            splash.Show();
            splash.Refresh(); // Ensure it paints

            // Simulate work (or use a timer here)
            System.Threading.Thread.Sleep(3000);

            splash.Close();
            Application.Run(new HomeWindow());
        }
    }
}