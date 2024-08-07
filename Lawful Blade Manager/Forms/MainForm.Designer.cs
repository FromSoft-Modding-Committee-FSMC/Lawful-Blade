﻿namespace LawfulBladeManager.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            msMain = new MenuStrip();
            msMainFile = new ToolStripMenuItem();
            preferencesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            msMainExit = new ToolStripMenuItem();
            msMainPackages = new ToolStripMenuItem();
            msPackagesManageRepositories = new ToolStripMenuItem();
            msPackagesCreateRepository = new ToolStripMenuItem();
            msPackagesCreateRepositoryNew = new ToolStripMenuItem();
            msPackagesCreateRepositoryFromExisting = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            msPackagesCreatePackage = new ToolStripMenuItem();
            msPackagesCreatePackageNew = new ToolStripMenuItem();
            msPackagesCreatePackageFromExisting = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            generateDeltaDirectoryToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            checkForUpdatesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            reportAProblemToolStripMenuItem = new ToolStripMenuItem();
            releaseNotesToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            tcMain = new TabControl();
            tpWelcome = new TabPage();
            lbPlaceholder = new Label();
            tpInstances = new TabPage();
            pcInstanceList = new Panel();
            pcInstanceButtons = new Panel();
            btInstLegacy = new Button();
            btInstNew = new Button();
            tpProjects = new TabPage();
            pcProjectList = new Panel();
            pcProjectButtons = new Panel();
            btLocalProject = new Button();
            btNewProject = new Button();
            msMain.SuspendLayout();
            tcMain.SuspendLayout();
            tpWelcome.SuspendLayout();
            tpInstances.SuspendLayout();
            pcInstanceButtons.SuspendLayout();
            tpProjects.SuspendLayout();
            pcProjectButtons.SuspendLayout();
            SuspendLayout();
            // 
            // msMain
            // 
            msMain.Items.AddRange(new ToolStripItem[] { msMainFile, msMainPackages, helpToolStripMenuItem });
            msMain.Location = new Point(0, 0);
            msMain.Name = "msMain";
            msMain.Size = new Size(944, 24);
            msMain.TabIndex = 0;
            msMain.Text = "menuStrip1";
            // 
            // msMainFile
            // 
            msMainFile.DropDownItems.AddRange(new ToolStripItem[] { preferencesToolStripMenuItem, toolStripSeparator3, msMainExit });
            msMainFile.Name = "msMainFile";
            msMainFile.Size = new Size(37, 20);
            msMainFile.Text = "File";
            // 
            // preferencesToolStripMenuItem
            // 
            preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            preferencesToolStripMenuItem.Size = new Size(135, 22);
            preferencesToolStripMenuItem.Text = "Preferences";
            preferencesToolStripMenuItem.Click += OnFileMenuPreferences;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(132, 6);
            // 
            // msMainExit
            // 
            msMainExit.Name = "msMainExit";
            msMainExit.Size = new Size(135, 22);
            msMainExit.Text = "Exit";
            msMainExit.Click += OnFileMenuExit;
            // 
            // msMainPackages
            // 
            msMainPackages.DropDownItems.AddRange(new ToolStripItem[] { msPackagesManageRepositories, msPackagesCreateRepository, toolStripSeparator1, msPackagesCreatePackage });
            msMainPackages.Name = "msMainPackages";
            msMainPackages.Size = new Size(68, 20);
            msMainPackages.Text = "Packages";
            // 
            // msPackagesManageRepositories
            // 
            msPackagesManageRepositories.Name = "msPackagesManageRepositories";
            msPackagesManageRepositories.Size = new Size(184, 22);
            msPackagesManageRepositories.Text = "Manage Repositories";
            msPackagesManageRepositories.Click += OnPackagesMenuManageRepositories;
            // 
            // msPackagesCreateRepository
            // 
            msPackagesCreateRepository.DropDownItems.AddRange(new ToolStripItem[] { msPackagesCreateRepositoryNew, msPackagesCreateRepositoryFromExisting });
            msPackagesCreateRepository.Name = "msPackagesCreateRepository";
            msPackagesCreateRepository.Size = new Size(184, 22);
            msPackagesCreateRepository.Text = "Create Repository...";
            // 
            // msPackagesCreateRepositoryNew
            // 
            msPackagesCreateRepositoryNew.Name = "msPackagesCreateRepositoryNew";
            msPackagesCreateRepositoryNew.Size = new Size(146, 22);
            msPackagesCreateRepositoryNew.Text = "New";
            msPackagesCreateRepositoryNew.Click += OnPackagesMenuCreateRepository;
            // 
            // msPackagesCreateRepositoryFromExisting
            // 
            msPackagesCreateRepositoryFromExisting.Name = "msPackagesCreateRepositoryFromExisting";
            msPackagesCreateRepositoryFromExisting.Size = new Size(146, 22);
            msPackagesCreateRepositoryFromExisting.Text = "From Existing";
            msPackagesCreateRepositoryFromExisting.Click += OnPackagesMenuCreateRepository;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(181, 6);
            // 
            // msPackagesCreatePackage
            // 
            msPackagesCreatePackage.DropDownItems.AddRange(new ToolStripItem[] { msPackagesCreatePackageNew, msPackagesCreatePackageFromExisting, toolStripSeparator2, toolsToolStripMenuItem });
            msPackagesCreatePackage.Name = "msPackagesCreatePackage";
            msPackagesCreatePackage.Size = new Size(184, 22);
            msPackagesCreatePackage.Text = "Create Package...";
            // 
            // msPackagesCreatePackageNew
            // 
            msPackagesCreatePackageNew.Name = "msPackagesCreatePackageNew";
            msPackagesCreatePackageNew.Size = new Size(146, 22);
            msPackagesCreatePackageNew.Text = "New";
            msPackagesCreatePackageNew.Click += OnPackagesMenuCreatePackage;
            // 
            // msPackagesCreatePackageFromExisting
            // 
            msPackagesCreatePackageFromExisting.Name = "msPackagesCreatePackageFromExisting";
            msPackagesCreatePackageFromExisting.Size = new Size(146, 22);
            msPackagesCreatePackageFromExisting.Text = "From Existing";
            msPackagesCreatePackageFromExisting.Click += OnPackagesMenuCreatePackage;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(143, 6);
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generateDeltaDirectoryToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(146, 22);
            toolsToolStripMenuItem.Text = "Tools...";
            // 
            // generateDeltaDirectoryToolStripMenuItem
            // 
            generateDeltaDirectoryToolStripMenuItem.Name = "generateDeltaDirectoryToolStripMenuItem";
            generateDeltaDirectoryToolStripMenuItem.Size = new Size(152, 22);
            generateDeltaDirectoryToolStripMenuItem.Text = "Delta Directory";
            generateDeltaDirectoryToolStripMenuItem.Click += OnPackagesMenuDeltaDirectoryTool;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { checkForUpdatesToolStripMenuItem, toolStripSeparator4, reportAProblemToolStripMenuItem, releaseNotesToolStripMenuItem, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            checkForUpdatesToolStripMenuItem.Size = new Size(171, 22);
            checkForUpdatesToolStripMenuItem.Text = "Check for Updates";
            checkForUpdatesToolStripMenuItem.Click += OnHelpMenuCheckForUpdates;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(168, 6);
            // 
            // reportAProblemToolStripMenuItem
            // 
            reportAProblemToolStripMenuItem.Name = "reportAProblemToolStripMenuItem";
            reportAProblemToolStripMenuItem.Size = new Size(171, 22);
            reportAProblemToolStripMenuItem.Text = "Report a Problem ";
            reportAProblemToolStripMenuItem.Click += OnHelpMenuReportAProblem;
            // 
            // releaseNotesToolStripMenuItem
            // 
            releaseNotesToolStripMenuItem.Name = "releaseNotesToolStripMenuItem";
            releaseNotesToolStripMenuItem.Size = new Size(171, 22);
            releaseNotesToolStripMenuItem.Text = "Release Notes";
            releaseNotesToolStripMenuItem.Click += OnHelpMenuReleaseNotes;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(171, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += OnHelpMenuAbout;
            // 
            // tcMain
            // 
            tcMain.Controls.Add(tpWelcome);
            tcMain.Controls.Add(tpInstances);
            tcMain.Controls.Add(tpProjects);
            tcMain.Dock = DockStyle.Fill;
            tcMain.Location = new Point(0, 24);
            tcMain.Name = "tcMain";
            tcMain.SelectedIndex = 0;
            tcMain.Size = new Size(944, 477);
            tcMain.TabIndex = 1;
            tcMain.SelectedIndexChanged += OnTabChange;
            // 
            // tpWelcome
            // 
            tpWelcome.BackColor = Color.FromArgb(16, 16, 16);
            tpWelcome.Controls.Add(lbPlaceholder);
            tpWelcome.ForeColor = SystemColors.ButtonFace;
            tpWelcome.Location = new Point(4, 24);
            tpWelcome.Name = "tpWelcome";
            tpWelcome.Size = new Size(936, 449);
            tpWelcome.TabIndex = 2;
            tpWelcome.Text = "Welcome";
            // 
            // lbPlaceholder
            // 
            lbPlaceholder.AutoSize = true;
            lbPlaceholder.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lbPlaceholder.Location = new Point(3, 402);
            lbPlaceholder.Name = "lbPlaceholder";
            lbPlaceholder.Size = new Size(319, 42);
            lbPlaceholder.TabIndex = 0;
            lbPlaceholder.Text = "No secret doors here!\r\n(Placeholder, check back in a future update!)\r\n";
            // 
            // tpInstances
            // 
            tpInstances.BackColor = Color.FromArgb(16, 16, 16);
            tpInstances.Controls.Add(pcInstanceList);
            tpInstances.Controls.Add(pcInstanceButtons);
            tpInstances.ForeColor = SystemColors.ButtonFace;
            tpInstances.Location = new Point(4, 24);
            tpInstances.Name = "tpInstances";
            tpInstances.Padding = new Padding(3);
            tpInstances.Size = new Size(936, 449);
            tpInstances.TabIndex = 1;
            tpInstances.Text = "Instances";
            // 
            // pcInstanceList
            // 
            pcInstanceList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pcInstanceList.BackColor = Color.FromArgb(8, 8, 8);
            pcInstanceList.Location = new Point(236, 3);
            pcInstanceList.Name = "pcInstanceList";
            pcInstanceList.Size = new Size(697, 443);
            pcInstanceList.TabIndex = 1;
            // 
            // pcInstanceButtons
            // 
            pcInstanceButtons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pcInstanceButtons.BackColor = Color.FromArgb(8, 8, 8);
            pcInstanceButtons.BorderStyle = BorderStyle.FixedSingle;
            pcInstanceButtons.Controls.Add(btInstLegacy);
            pcInstanceButtons.Controls.Add(btInstNew);
            pcInstanceButtons.Location = new Point(3, 3);
            pcInstanceButtons.Name = "pcInstanceButtons";
            pcInstanceButtons.Padding = new Padding(2);
            pcInstanceButtons.Size = new Size(230, 443);
            pcInstanceButtons.TabIndex = 0;
            // 
            // btInstLegacy
            // 
            btInstLegacy.BackColor = Color.FromArgb(48, 48, 48);
            btInstLegacy.Dock = DockStyle.Top;
            btInstLegacy.FlatAppearance.BorderColor = Color.Black;
            btInstLegacy.FlatStyle = FlatStyle.Flat;
            btInstLegacy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btInstLegacy.ForeColor = SystemColors.ButtonFace;
            btInstLegacy.Image = Properties.Resources.browsefolder_lb;
            btInstLegacy.ImageAlign = ContentAlignment.MiddleLeft;
            btInstLegacy.Location = new Point(2, 48);
            btInstLegacy.Margin = new Padding(3, 3, 3, 10);
            btInstLegacy.Name = "btInstLegacy";
            btInstLegacy.Padding = new Padding(10, 0, 0, 0);
            btInstLegacy.Size = new Size(224, 46);
            btInstLegacy.TabIndex = 2;
            btInstLegacy.Text = "    &Import Instance";
            btInstLegacy.TextImageRelation = TextImageRelation.ImageBeforeText;
            btInstLegacy.UseVisualStyleBackColor = false;
            btInstLegacy.Click += OnInstanceImport;
            // 
            // btInstNew
            // 
            btInstNew.BackColor = Color.FromArgb(48, 48, 48);
            btInstNew.Dock = DockStyle.Top;
            btInstNew.FlatAppearance.BorderColor = Color.Black;
            btInstNew.FlatStyle = FlatStyle.Flat;
            btInstNew.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btInstNew.ForeColor = SystemColors.ButtonFace;
            btInstNew.Image = Properties.Resources.newfile_lb;
            btInstNew.ImageAlign = ContentAlignment.MiddleLeft;
            btInstNew.Location = new Point(2, 2);
            btInstNew.Margin = new Padding(3, 3, 3, 10);
            btInstNew.Name = "btInstNew";
            btInstNew.Padding = new Padding(10, 0, 0, 0);
            btInstNew.Size = new Size(224, 46);
            btInstNew.TabIndex = 1;
            btInstNew.Text = "    &Create New Instance";
            btInstNew.TextImageRelation = TextImageRelation.ImageBeforeText;
            btInstNew.UseVisualStyleBackColor = false;
            btInstNew.Click += OnInstanceNew;
            // 
            // tpProjects
            // 
            tpProjects.BackColor = Color.FromArgb(16, 16, 16);
            tpProjects.Controls.Add(pcProjectList);
            tpProjects.Controls.Add(pcProjectButtons);
            tpProjects.ForeColor = SystemColors.ButtonFace;
            tpProjects.Location = new Point(4, 24);
            tpProjects.Name = "tpProjects";
            tpProjects.Padding = new Padding(3);
            tpProjects.Size = new Size(936, 449);
            tpProjects.TabIndex = 0;
            tpProjects.Text = "Projects";
            // 
            // pcProjectList
            // 
            pcProjectList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pcProjectList.BackColor = Color.FromArgb(8, 8, 8);
            pcProjectList.Location = new Point(236, 3);
            pcProjectList.Name = "pcProjectList";
            pcProjectList.Size = new Size(697, 443);
            pcProjectList.TabIndex = 1;
            // 
            // pcProjectButtons
            // 
            pcProjectButtons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pcProjectButtons.BackColor = Color.FromArgb(8, 8, 8);
            pcProjectButtons.BorderStyle = BorderStyle.FixedSingle;
            pcProjectButtons.Controls.Add(btLocalProject);
            pcProjectButtons.Controls.Add(btNewProject);
            pcProjectButtons.Location = new Point(3, 3);
            pcProjectButtons.Name = "pcProjectButtons";
            pcProjectButtons.Padding = new Padding(2);
            pcProjectButtons.Size = new Size(230, 443);
            pcProjectButtons.TabIndex = 0;
            // 
            // btLocalProject
            // 
            btLocalProject.BackColor = Color.FromArgb(48, 48, 48);
            btLocalProject.Dock = DockStyle.Top;
            btLocalProject.FlatAppearance.BorderColor = Color.Black;
            btLocalProject.FlatStyle = FlatStyle.Flat;
            btLocalProject.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btLocalProject.ForeColor = SystemColors.ButtonFace;
            btLocalProject.Image = Properties.Resources.browsefolder_lb;
            btLocalProject.ImageAlign = ContentAlignment.MiddleLeft;
            btLocalProject.Location = new Point(2, 48);
            btLocalProject.Margin = new Padding(3, 3, 3, 10);
            btLocalProject.Name = "btLocalProject";
            btLocalProject.Padding = new Padding(10, 0, 0, 0);
            btLocalProject.Size = new Size(224, 46);
            btLocalProject.TabIndex = 1;
            btLocalProject.Text = "    &Import Project";
            btLocalProject.TextImageRelation = TextImageRelation.ImageBeforeText;
            btLocalProject.UseVisualStyleBackColor = false;
            btLocalProject.Click += OnProjectImport;
            // 
            // btNewProject
            // 
            btNewProject.BackColor = Color.FromArgb(48, 48, 48);
            btNewProject.Dock = DockStyle.Top;
            btNewProject.FlatAppearance.BorderColor = Color.Black;
            btNewProject.FlatStyle = FlatStyle.Flat;
            btNewProject.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btNewProject.ForeColor = SystemColors.ButtonFace;
            btNewProject.Image = Properties.Resources.newfile_lb;
            btNewProject.ImageAlign = ContentAlignment.MiddleLeft;
            btNewProject.Location = new Point(2, 2);
            btNewProject.Margin = new Padding(3, 3, 3, 10);
            btNewProject.Name = "btNewProject";
            btNewProject.Padding = new Padding(10, 0, 0, 0);
            btNewProject.Size = new Size(224, 46);
            btNewProject.TabIndex = 0;
            btNewProject.Text = "    &Create New Project";
            btNewProject.TextImageRelation = TextImageRelation.ImageBeforeText;
            btNewProject.UseVisualStyleBackColor = false;
            btNewProject.Click += OnProjectNew;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(944, 501);
            Controls.Add(tcMain);
            Controls.Add(msMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = msMain;
            MinimumSize = new Size(960, 540);
            Name = "MainForm";
            Text = "Lawful Blade";
            Load += OnFormLoad;
            msMain.ResumeLayout(false);
            msMain.PerformLayout();
            tcMain.ResumeLayout(false);
            tpWelcome.ResumeLayout(false);
            tpWelcome.PerformLayout();
            tpInstances.ResumeLayout(false);
            pcInstanceButtons.ResumeLayout(false);
            tpProjects.ResumeLayout(false);
            pcProjectButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msMain;
        private TabControl tcMain;
        private TabPage tpProjects;
        private TabPage tpInstances;
        private Panel pcProjectButtons;
        private Button btNewProject;
        private Button btLocalProject;

        private ToolStripMenuItem msMainFile;
        private ToolStripMenuItem msMainExit;
        private ToolStripMenuItem msMainPackages;
        private ToolStripMenuItem msPackagesCreatePackage;
        private Panel pcProjectList;
        private Panel pcInstanceButtons;
        private Button btInstLegacy;
        private Button btInstNew;
        private Panel pcInstanceList;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem msPackagesManageRepositories;
        private ToolStripMenuItem msPackagesCreateRepository;
        private ToolStripMenuItem preferencesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem msPackagesCreatePackageNew;
        private ToolStripMenuItem msPackagesCreatePackageFromExisting;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem generateDeltaDirectoryToolStripMenuItem;
        private ToolStripMenuItem msPackagesCreateRepositoryNew;
        private ToolStripMenuItem msPackagesCreateRepositoryFromExisting;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem reportAProblemToolStripMenuItem;
        private ToolStripMenuItem releaseNotesToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private TabPage tpWelcome;
        private Label lbPlaceholder;
    }
}