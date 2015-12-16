namespace MoodleHelper
{
    partial class FlywayForm
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
            this.initToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defineFilePathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHPExecutablePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moodleDirectoryPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminateConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enabledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disabledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHPUnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moodleSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moodlePHPUnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHPUnitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pHPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbPHPArgs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbOutput = new System.Windows.Forms.RichTextBox();
            this.runPHPUnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnMigrate = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnSelectPhp = new System.Windows.Forms.Button();
            this.tbPhp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purgeCacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeCronToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flywayOpen = new System.Windows.Forms.OpenFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.switchToMoodleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // initToolStripMenuItem
            // 
            this.initToolStripMenuItem.Name = "initToolStripMenuItem";
            this.initToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.initToolStripMenuItem.Text = "Init Only";
            this.initToolStripMenuItem.ToolTipText = "Run the init command for preparing Moodle PHPUnit";
            // 
            // fullToolStripMenuItem
            // 
            this.fullToolStripMenuItem.Name = "fullToolStripMenuItem";
            this.fullToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.fullToolStripMenuItem.Text = "Both";
            this.fullToolStripMenuItem.ToolTipText = "Run the entire PHPUnit Test commands";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defineFilePathsToolStripMenuItem,
            this.terminateConsoleToolStripMenuItem,
            this.switchToMoodleToolStripMenuItem});
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
            // 
            // moodleDirectoryPathToolStripMenuItem
            // 
            this.moodleDirectoryPathToolStripMenuItem.Name = "moodleDirectoryPathToolStripMenuItem";
            this.moodleDirectoryPathToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.moodleDirectoryPathToolStripMenuItem.Text = "Moodle Directory Path";
            this.moodleDirectoryPathToolStripMenuItem.ToolTipText = "Define Moodle Directory Folder Path";
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
            // 
            // disabledToolStripMenuItem
            // 
            this.disabledToolStripMenuItem.Name = "disabledToolStripMenuItem";
            this.disabledToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.disabledToolStripMenuItem.Text = "Disabled";
            this.disabledToolStripMenuItem.ToolTipText = "Don\'t kill the console window when the task has been executed";
            // 
            // pHPUnitToolStripMenuItem
            // 
            this.pHPUnitToolStripMenuItem.Name = "pHPUnitToolStripMenuItem";
            this.pHPUnitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.pHPUnitToolStripMenuItem.Text = "PHPUnit Only";
            this.pHPUnitToolStripMenuItem.ToolTipText = "Only run the PHPUnit Library";
            // 
            // moodleSiteToolStripMenuItem
            // 
            this.moodleSiteToolStripMenuItem.Name = "moodleSiteToolStripMenuItem";
            this.moodleSiteToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.moodleSiteToolStripMenuItem.Text = "Moodle Dev";
            // 
            // moodlePHPUnitToolStripMenuItem
            // 
            this.moodlePHPUnitToolStripMenuItem.Name = "moodlePHPUnitToolStripMenuItem";
            this.moodlePHPUnitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.moodlePHPUnitToolStripMenuItem.Text = "Moodle PHPUnit";
            // 
            // pHPUnitToolStripMenuItem1
            // 
            this.pHPUnitToolStripMenuItem1.Name = "pHPUnitToolStripMenuItem1";
            this.pHPUnitToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.pHPUnitToolStripMenuItem1.Text = "PHPUnit";
            // 
            // pHPToolStripMenuItem
            // 
            this.pHPToolStripMenuItem.Name = "pHPToolStripMenuItem";
            this.pHPToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.pHPToolStripMenuItem.Text = "PHP Manual";
            // 
            // tbPHPArgs
            // 
            this.tbPHPArgs.Location = new System.Drawing.Point(12, 262);
            this.tbPHPArgs.Name = "tbPHPArgs";
            this.tbPHPArgs.Size = new System.Drawing.Size(114, 20);
            this.tbPHPArgs.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Console Output";
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
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(135, 80);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.Size = new System.Drawing.Size(358, 218);
            this.tbOutput.TabIndex = 33;
            this.tbOutput.Text = "";
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
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Custom Prefix";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Actions";
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(12, 138);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(111, 23);
            this.btnClean.TabIndex = 26;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            // 
            // btnMigrate
            // 
            this.btnMigrate.Location = new System.Drawing.Point(12, 109);
            this.btnMigrate.Name = "btnMigrate";
            this.btnMigrate.Size = new System.Drawing.Size(111, 23);
            this.btnMigrate.TabIndex = 25;
            this.btnMigrate.Text = "Migrate";
            this.btnMigrate.UseVisualStyleBackColor = true;
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(12, 80);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(111, 23);
            this.btnInfo.TabIndex = 24;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // btnSelectPhp
            // 
            this.btnSelectPhp.Location = new System.Drawing.Point(471, 41);
            this.btnSelectPhp.Name = "btnSelectPhp";
            this.btnSelectPhp.Size = new System.Drawing.Size(22, 23);
            this.btnSelectPhp.TabIndex = 22;
            this.btnSelectPhp.Text = "..";
            this.btnSelectPhp.UseVisualStyleBackColor = true;
            // 
            // tbPhp
            // 
            this.tbPhp.Enabled = false;
            this.tbPhp.Location = new System.Drawing.Point(76, 41);
            this.tbPhp.Name = "tbPhp";
            this.tbPhp.ReadOnly = true;
            this.tbPhp.ShortcutsEnabled = false;
            this.tbPhp.Size = new System.Drawing.Size(389, 20);
            this.tbPhp.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Flyway Exe:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionsToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(509, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.settingsToolStripMenuItem.Text = "Reset Settings";
            this.settingsToolStripMenuItem.ToolTipText = "Resets Settings to factory default";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.ToolTipText = "Exits the application";
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
            // 
            // executeCronToolStripMenuItem
            // 
            this.executeCronToolStripMenuItem.Name = "executeCronToolStripMenuItem";
            this.executeCronToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.executeCronToolStripMenuItem.Text = "Execute Cron";
            // 
            // flywayOpen
            // 
            this.flywayOpen.DefaultExt = "exe";
            this.flywayOpen.Filter = "PHP Executable Files (*.exe)|*.exe|All Files|*.*";
            this.flywayOpen.Title = "Select a PHP Executable";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 201);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(111, 21);
            this.comboBox1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Select Stuff";
            // 
            // switchToMoodleToolStripMenuItem
            // 
            this.switchToMoodleToolStripMenuItem.Name = "switchToMoodleToolStripMenuItem";
            this.switchToMoodleToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.switchToMoodleToolStripMenuItem.Text = "Switch to Moodle";
            this.switchToMoodleToolStripMenuItem.Click += new System.EventHandler(this.switchToMoodleToolStripMenuItem_Click);
            // 
            // FlywayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 314);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbPHPArgs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnMigrate);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnSelectPhp);
            this.Controls.Add(this.tbPhp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FlywayForm";
            this.Text = "Moodle Helper (Flyway)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem initToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defineFilePathsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pHPExecutablePathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moodleDirectoryPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminateConsoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enabledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disabledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pHPUnitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moodleSiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moodlePHPUnitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pHPUnitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pHPToolStripMenuItem;
        private System.Windows.Forms.TextBox tbPHPArgs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.RichTextBox tbOutput;
        private System.Windows.Forms.ToolStripMenuItem runPHPUnitToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnMigrate;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnSelectPhp;
        private System.Windows.Forms.TextBox tbPhp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purgeCacheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeCronToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog flywayOpen;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem switchToMoodleToolStripMenuItem;

    }
}