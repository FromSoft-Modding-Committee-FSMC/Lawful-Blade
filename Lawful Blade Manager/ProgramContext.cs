﻿using LawfulBladeManager.Forms;

namespace LawfulBladeManager
{
    public class ProgramContext : ApplicationContext
    {
        // Private Data
        static readonly string pathAppData = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FSMC", "LawfulBlade");
        static readonly string pathProgram = Application.StartupPath;
        readonly FormMain mainWindow;

        // Properties
        public static string AppDataPath => pathAppData;
        public static string ProgramPath => pathProgram;

        // Constructors
        public ProgramContext()
        {
            // Event Binding
            //Application.ApplicationExit += OnApplicationExit;

            // Basic Initialization
            InitializeFirstTime();

            mainWindow = new FormMain();
            mainWindow.FormClosing += OnApplicationExit;    // Yeah... The other one isn't firing?
            mainWindow.Show();
        }

        /// <summary>
        /// Initializes data on the first run.
        /// </summary>
        static void InitializeFirstTime()
        {
            // We exit early if the appdata path already exists.
            if (Directory.Exists(AppDataPath))
                return;

            // Recursively create all application data paths.
            Directory.CreateDirectory(AppDataPath);
        }

        // Event Callbacks
        void OnApplicationExit(object? sender, EventArgs e)
        {
            // Save program data
            if (Program.ProjectManager == null)
                return;

            Program.ProjectManager.SaveProjectInfo();
        }
    }
}
