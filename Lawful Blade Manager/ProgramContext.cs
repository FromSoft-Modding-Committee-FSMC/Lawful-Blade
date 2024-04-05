﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawfulBladeManager.Project;

namespace LawfulBladeManager
{
    public class ProgramContext : ApplicationContext
    {
        // Private Data
        static readonly string pathAppData = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FSMC", "LawfulBlade");

        readonly FormMain mainWindow;

        // Public Data
        public ProjectManager projectManager;

        // Properties
        public static string AppDataPath => pathAppData;

        // Constructors
        public ProgramContext()
        {
            // Event Binding
            //Application.ApplicationExit += OnApplicationExit;

            // Basic Initialization
            InitializeFirstTime();

            // Load Application Data
            projectManager = new ProjectManager();

            // Construct Main Window Form
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
            projectManager.SaveProjectInfo();

            Console.WriteLine("Allo?");
        }
    }
}