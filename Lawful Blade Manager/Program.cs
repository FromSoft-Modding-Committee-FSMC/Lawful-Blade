using LawfulBladeManager.Networking;
using LawfulBladeManager.Packages;
using LawfulBladeManager.Projects;

namespace LawfulBladeManager
{
    public static class Program
    {
        // Properties
        public readonly static DownloadManager? DownloadManager = new();
        public readonly static ProjectManager? ProjectManager   = new();
        public readonly static ProgramContext? Context          = new();
        public readonly static PackageManager? PackageManager   = new();

        // Entry Point
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(Context);
        }
    }
}