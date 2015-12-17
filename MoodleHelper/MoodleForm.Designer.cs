namespace MoodleHelper
{
    partial class MoodleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPhp = new System.Windows.Forms.TextBox();
            this.tbMoodle = new System.Windows.Forms.TextBox();
            this.btnSelectPhp = new System.Windows.Forms.Button();
            this.btlSelectMoodle = new System.Windows.Forms.Button();
            this.btnPurgeCache = new System.Windows.Forms.Button();
            this.btnCron = new System.Windows.Forms.Button();
            this.btnPhpUnit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.openPhpFile = new System.Windows.Forms.OpenFileDialog();
            this.openMoodleDir = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purgeCacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeCronToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runPHPUnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHPUnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defineFilePathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHPExecutablePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moodleDirectoryPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminateConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enabledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disabledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchToFlywayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moodleSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moodlePHPUnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHPUnitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pHPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchToFlywayToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPHPArgs = new System.Windows.Forms.TextBox();
            this.btnPhpUnitWithArgs = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOutput = new System.Windows.Forms.RichTextBox();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newVersionAvailableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHP Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Moodle Dir:";
            // 
            // tbPhp
            // 
            this.tbPhp.Enabled = false;
            this.tbPhp.Location = new System.Drawing.Point(76, 41);
            this.tbPhp.Name = "tbPhp";
            this.tbPhp.ReadOnly = true;
            this.tbPhp.ShortcutsEnabled = false;
            this.tbPhp.Size = new System.Drawing.Size(400, 20);
            this.tbPhp.TabIndex = 2;
            // 
            // tbMoodle
            // 
            this.tbMoodle.Enabled = false;
            this.tbMoodle.Location = new System.Drawing.Point(76, 68);
            this.tbMoodle.Name = "tbMoodle";
            this.tbMoodle.ReadOnly = true;
            this.tbMoodle.Size = new System.Drawing.Size(400, 20);
            this.tbMoodle.TabIndex = 3;
            // 
            // btnSelectPhp
            // 
            this.btnSelectPhp.Location = new System.Drawing.Point(483, 39);
            this.btnSelectPhp.Name = "btnSelectPhp";
            this.btnSelectPhp.Size = new System.Drawing.Size(22, 23);
            this.btnSelectPhp.TabIndex = 4;
            this.btnSelectPhp.Text = "..";
            this.btnSelectPhp.UseVisualStyleBackColor = true;
            this.btnSelectPhp.Click += new System.EventHandler(this.btnSelectPhp_Click);
            // 
            // btlSelectMoodle
            // 
            this.btlSelectMoodle.Location = new System.Drawing.Point(482, 68);
            this.btlSelectMoodle.Name = "btlSelectMoodle";
            this.btlSelectMoodle.Size = new System.Drawing.Size(23, 23);
            this.btlSelectMoodle.TabIndex = 5;
            this.btlSelectMoodle.Text = "...";
            this.btlSelectMoodle.UseVisualStyleBackColor = true;
            this.btlSelectMoodle.Click += new System.EventHandler(this.btlSelectMoodle_Click);
            // 
            // btnPurgeCache
            // 
            this.btnPurgeCache.Location = new System.Drawing.Point(15, 128);
            this.btnPurgeCache.Name = "btnPurgeCache";
            this.btnPurgeCache.Size = new System.Drawing.Size(111, 23);
            this.btnPurgeCache.TabIndex = 6;
            this.btnPurgeCache.Text = "Purge Cache";
            this.btnPurgeCache.UseVisualStyleBackColor = true;
            this.btnPurgeCache.Click += new System.EventHandler(this.btnPurgeCache_Click);
            // 
            // btnCron
            // 
            this.btnCron.Location = new System.Drawing.Point(15, 157);
            this.btnCron.Name = "btnCron";
            this.btnCron.Size = new System.Drawing.Size(111, 23);
            this.btnCron.TabIndex = 7;
            this.btnCron.Text = "Run Cron";
            this.btnCron.UseVisualStyleBackColor = true;
            this.btnCron.Click += new System.EventHandler(this.btnCron_Click);
            // 
            // btnPhpUnit
            // 
            this.btnPhpUnit.Location = new System.Drawing.Point(15, 186);
            this.btnPhpUnit.Name = "btnPhpUnit";
            this.btnPhpUnit.Size = new System.Drawing.Size(111, 23);
            this.btnPhpUnit.TabIndex = 8;
            this.btnPhpUnit.Text = "Full PHPUnit Tests";
            this.btnPhpUnit.UseVisualStyleBackColor = true;
            this.btnPhpUnit.Click += new System.EventHandler(this.btnPhpUnit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quick Moodle Actions";
            // 
            // openPhpFile
            // 
            this.openPhpFile.DefaultExt = "exe";
            this.openPhpFile.Filter = "PHP Executable Files (*.exe)|*.exe|All Files|*.*";
            this.openPhpFile.Title = "Select a PHP Executable";
            // 
            // openMoodleDir
            // 
            this.openMoodleDir.Description = "Select the root folder to your Moodle Code";
            this.openMoodleDir.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionsToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.switchToFlywayToolStripMenuItem1,
            this.newVersionAvailableToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(518, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Reset Settings";
            this.settingsToolStripMenuItem.ToolTipText = "Resets Settings to factory default";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.ToolTipText = "Exits the application";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purgeCacheToolStripMenuItem,
            this.executeCronToolStripMenuItem,
            this.runPHPUnitToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // purgeCacheToolStripMenuItem
            // 
            this.purgeCacheToolStripMenuItem.Name = "purgeCacheToolStripMenuItem";
            this.purgeCacheToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.purgeCacheToolStripMenuItem.Text = "Purge Cache";
            this.purgeCacheToolStripMenuItem.Click += new System.EventHandler(this.btnPurgeCache_Click);
            // 
            // executeCronToolStripMenuItem
            // 
            this.executeCronToolStripMenuItem.Name = "executeCronToolStripMenuItem";
            this.executeCronToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.executeCronToolStripMenuItem.Text = "Execute Cron";
            this.executeCronToolStripMenuItem.Click += new System.EventHandler(this.btnCron_Click);
            // 
            // runPHPUnitToolStripMenuItem
            // 
            this.runPHPUnitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.initToolStripMenuItem,
            this.pHPUnitToolStripMenuItem,
            this.fullToolStripMenuItem});
            this.runPHPUnitToolStripMenuItem.Name = "runPHPUnitToolStripMenuItem";
            this.runPHPUnitToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.runPHPUnitToolStripMenuItem.Text = "Run PHP Unit Tests";
            this.runPHPUnitToolStripMenuItem.Click += new System.EventHandler(this.btnPhpUnit_Click);
            // 
            // initToolStripMenuItem
            // 
            this.initToolStripMenuItem.Name = "initToolStripMenuItem";
            this.initToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.initToolStripMenuItem.Text = "Init Only";
            this.initToolStripMenuItem.ToolTipText = "Run the init command for preparing Moodle PHPUnit";
            this.initToolStripMenuItem.Click += new System.EventHandler(this.initToolStripMenuItem_Click);
            // 
            // pHPUnitToolStripMenuItem
            // 
            this.pHPUnitToolStripMenuItem.Name = "pHPUnitToolStripMenuItem";
            this.pHPUnitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.pHPUnitToolStripMenuItem.Text = "PHPUnit Only";
            this.pHPUnitToolStripMenuItem.ToolTipText = "Only run the PHPUnit Library";
            this.pHPUnitToolStripMenuItem.Click += new System.EventHandler(this.pHPUnitToolStripMenuItem_Click);
            // 
            // fullToolStripMenuItem
            // 
            this.fullToolStripMenuItem.Name = "fullToolStripMenuItem";
            this.fullToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.fullToolStripMenuItem.Text = "Both";
            this.fullToolStripMenuItem.ToolTipText = "Run the entire PHPUnit Test commands";
            this.fullToolStripMenuItem.Click += new System.EventHandler(this.btnPhpUnit_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defineFilePathsToolStripMenuItem,
            this.terminateConsoleToolStripMenuItem,
            this.switchToFlywayToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // defineFilePathsToolStripMenuItem
            // 
            this.defineFilePathsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pHPExecutablePathToolStripMenuItem,
            this.moodleDirectoryPathToolStripMenuItem});
            this.defineFilePathsToolStripMenuItem.Name = "defineFilePathsToolStripMenuItem";
            this.defineFilePathsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.defineFilePathsToolStripMenuItem.Text = "Define File Paths";
            this.defineFilePathsToolStripMenuItem.ToolTipText = "Defines file paths";
            // 
            // pHPExecutablePathToolStripMenuItem
            // 
            this.pHPExecutablePathToolStripMenuItem.Name = "pHPExecutablePathToolStripMenuItem";
            this.pHPExecutablePathToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.pHPExecutablePathToolStripMenuItem.Text = "PHP Executable Path";
            this.pHPExecutablePathToolStripMenuItem.ToolTipText = "Define PHP Executable File Path";
            this.pHPExecutablePathToolStripMenuItem.Click += new System.EventHandler(this.btnSelectPhp_Click);
            // 
            // moodleDirectoryPathToolStripMenuItem
            // 
            this.moodleDirectoryPathToolStripMenuItem.Name = "moodleDirectoryPathToolStripMenuItem";
            this.moodleDirectoryPathToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.moodleDirectoryPathToolStripMenuItem.Text = "Moodle Directory Path";
            this.moodleDirectoryPathToolStripMenuItem.ToolTipText = "Define Moodle Directory Folder Path";
            this.moodleDirectoryPathToolStripMenuItem.Click += new System.EventHandler(this.btlSelectMoodle_Click);
            // 
            // terminateConsoleToolStripMenuItem
            // 
            this.terminateConsoleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enabledToolStripMenuItem,
            this.disabledToolStripMenuItem});
            this.terminateConsoleToolStripMenuItem.Name = "terminateConsoleToolStripMenuItem";
            this.terminateConsoleToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.terminateConsoleToolStripMenuItem.Text = "Terminate Console";
            // 
            // enabledToolStripMenuItem
            // 
            this.enabledToolStripMenuItem.Name = "enabledToolStripMenuItem";
            this.enabledToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.enabledToolStripMenuItem.Text = "Enabled";
            this.enabledToolStripMenuItem.ToolTipText = "Kills the console when its finished its task";
            this.enabledToolStripMenuItem.Click += new System.EventHandler(this.enabledToolStripMenuItem_Click);
            // 
            // disabledToolStripMenuItem
            // 
            this.disabledToolStripMenuItem.Name = "disabledToolStripMenuItem";
            this.disabledToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.disabledToolStripMenuItem.Text = "Disabled";
            this.disabledToolStripMenuItem.ToolTipText = "Don\'t kill the console window when the task has been executed";
            this.disabledToolStripMenuItem.Click += new System.EventHandler(this.disabledToolStripMenuItem_Click);
            // 
            // switchToFlywayToolStripMenuItem
            // 
            this.switchToFlywayToolStripMenuItem.Name = "switchToFlywayToolStripMenuItem";
            this.switchToFlywayToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.switchToFlywayToolStripMenuItem.Text = "Switch to Flyway";
            this.switchToFlywayToolStripMenuItem.Click += new System.EventHandler(this.switchToFlywayToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moodleSiteToolStripMenuItem,
            this.moodlePHPUnitToolStripMenuItem,
            this.pHPUnitToolStripMenuItem1,
            this.pHPToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.helpToolStripMenuItem.Text = "Documentations";
            // 
            // moodleSiteToolStripMenuItem
            // 
            this.moodleSiteToolStripMenuItem.Name = "moodleSiteToolStripMenuItem";
            this.moodleSiteToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.moodleSiteToolStripMenuItem.Text = "Moodle Dev";
            this.moodleSiteToolStripMenuItem.Click += new System.EventHandler(this.moodleSiteToolStripMenuItem_Click);
            // 
            // moodlePHPUnitToolStripMenuItem
            // 
            this.moodlePHPUnitToolStripMenuItem.Name = "moodlePHPUnitToolStripMenuItem";
            this.moodlePHPUnitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.moodlePHPUnitToolStripMenuItem.Text = "Moodle PHPUnit";
            this.moodlePHPUnitToolStripMenuItem.Click += new System.EventHandler(this.moodlePHPUnitToolStripMenuItem_Click);
            // 
            // pHPUnitToolStripMenuItem1
            // 
            this.pHPUnitToolStripMenuItem1.Name = "pHPUnitToolStripMenuItem1";
            this.pHPUnitToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.pHPUnitToolStripMenuItem1.Text = "PHPUnit";
            this.pHPUnitToolStripMenuItem1.Click += new System.EventHandler(this.pHPUnitToolStripMenuItem1_Click);
            // 
            // pHPToolStripMenuItem
            // 
            this.pHPToolStripMenuItem.Name = "pHPToolStripMenuItem";
            this.pHPToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.pHPToolStripMenuItem.Text = "PHP Manual";
            this.pHPToolStripMenuItem.Click += new System.EventHandler(this.pHPToolStripMenuItem_Click);
            // 
            // switchToFlywayToolStripMenuItem1
            // 
            this.switchToFlywayToolStripMenuItem1.Name = "switchToFlywayToolStripMenuItem1";
            this.switchToFlywayToolStripMenuItem1.Size = new System.Drawing.Size(107, 20);
            this.switchToFlywayToolStripMenuItem1.Text = "Switch to Flyway";
            this.switchToFlywayToolStripMenuItem1.Click += new System.EventHandler(this.switchToFlywayToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Console Output";
            // 
            // tbPHPArgs
            // 
            this.tbPHPArgs.Location = new System.Drawing.Point(12, 245);
            this.tbPHPArgs.Name = "tbPHPArgs";
            this.tbPHPArgs.Size = new System.Drawing.Size(114, 20);
            this.tbPHPArgs.TabIndex = 14;
            // 
            // btnPhpUnitWithArgs
            // 
            this.btnPhpUnitWithArgs.Location = new System.Drawing.Point(15, 216);
            this.btnPhpUnitWithArgs.Name = "btnPhpUnitWithArgs";
            this.btnPhpUnitWithArgs.Size = new System.Drawing.Size(111, 23);
            this.btnPhpUnitWithArgs.TabIndex = 15;
            this.btnPhpUnitWithArgs.Text = "PHPUnit with Args";
            this.btnPhpUnitWithArgs.UseVisualStyleBackColor = true;
            this.btnPhpUnitWithArgs.Click += new System.EventHandler(this.btnPhpUnitWithArgs_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Enter Args Here";
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(135, 125);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.Size = new System.Drawing.Size(371, 156);
            this.tbOutput.TabIndex = 17;
            this.tbOutput.Text = "";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // newVersionAvailableToolStripMenuItem
            // 
            this.newVersionAvailableToolStripMenuItem.Name = "newVersionAvailableToolStripMenuItem";
            this.newVersionAvailableToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.newVersionAvailableToolStripMenuItem.Text = "New Version Available!";
            this.newVersionAvailableToolStripMenuItem.Visible = false;
            this.newVersionAvailableToolStripMenuItem.Click += new System.EventHandler(this.newVersionAvailableToolStripMenuItem_Click);
            // 
            // MoodleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 285);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPhpUnitWithArgs);
            this.Controls.Add(this.tbPHPArgs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPhpUnit);
            this.Controls.Add(this.btnCron);
            this.Controls.Add(this.btnPurgeCache);
            this.Controls.Add(this.btlSelectMoodle);
            this.Controls.Add(this.btnSelectPhp);
            this.Controls.Add(this.tbMoodle);
            this.Controls.Add(this.tbPhp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MoodleForm";
            this.Text = "Moodle Helper (Moodle)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPhp;
        private System.Windows.Forms.TextBox tbMoodle;
        private System.Windows.Forms.Button btnSelectPhp;
        private System.Windows.Forms.Button btlSelectMoodle;
        private System.Windows.Forms.Button btnPurgeCache;
        private System.Windows.Forms.Button btnCron;
        private System.Windows.Forms.Button btnPhpUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openPhpFile;
        private System.Windows.Forms.FolderBrowserDialog openMoodleDir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purgeCacheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeCronToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runPHPUnitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defineFilePathsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pHPExecutablePathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moodleDirectoryPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminateConsoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enabledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disabledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem initToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pHPUnitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPHPArgs;
        private System.Windows.Forms.Button btnPhpUnitWithArgs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moodleSiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pHPUnitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem moodlePHPUnitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pHPToolStripMenuItem;
        private System.Windows.Forms.RichTextBox tbOutput;
        private System.Windows.Forms.ToolStripMenuItem switchToFlywayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem switchToFlywayToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newVersionAvailableToolStripMenuItem;
    }
}

