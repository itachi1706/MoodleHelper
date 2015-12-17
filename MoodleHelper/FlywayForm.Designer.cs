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
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defineFlywayExecutableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminateConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enabledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disabledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchToMoodleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moodleSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moodlePHPUnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHPUnitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pHPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbPHPArgs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbOutput = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnMigrate = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnSelectFlyway = new System.Windows.Forms.Button();
            this.tbFlyway = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flywayOpen = new System.Windows.Forms.OpenFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.migrateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchToMoodleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newVersionAvailableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defineFlywayExecutableToolStripMenuItem,
            this.terminateConsoleToolStripMenuItem,
            this.switchToMoodleToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // defineFlywayExecutableToolStripMenuItem
            // 
            this.defineFlywayExecutableToolStripMenuItem.Name = "defineFlywayExecutableToolStripMenuItem";
            this.defineFlywayExecutableToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.defineFlywayExecutableToolStripMenuItem.Text = "Define Flyway Executable";
            this.defineFlywayExecutableToolStripMenuItem.Click += new System.EventHandler(this.btnSelectFlyway_Click);
            // 
            // terminateConsoleToolStripMenuItem
            // 
            this.terminateConsoleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enabledToolStripMenuItem,
            this.disabledToolStripMenuItem});
            this.terminateConsoleToolStripMenuItem.Name = "terminateConsoleToolStripMenuItem";
            this.terminateConsoleToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.terminateConsoleToolStripMenuItem.Text = "Terminate Console";
            // 
            // enabledToolStripMenuItem
            // 
            this.enabledToolStripMenuItem.Name = "enabledToolStripMenuItem";
            this.enabledToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.enabledToolStripMenuItem.Text = "Enabled";
            this.enabledToolStripMenuItem.ToolTipText = "Kills the console when its finished its task";
            this.enabledToolStripMenuItem.Click += new System.EventHandler(this.enabledToolStripMenuItem_Click);
            // 
            // disabledToolStripMenuItem
            // 
            this.disabledToolStripMenuItem.Name = "disabledToolStripMenuItem";
            this.disabledToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.disabledToolStripMenuItem.Text = "Disabled";
            this.disabledToolStripMenuItem.ToolTipText = "Don\'t kill the console window when the task has been executed";
            this.disabledToolStripMenuItem.Click += new System.EventHandler(this.disabledToolStripMenuItem_Click);
            // 
            // switchToMoodleToolStripMenuItem
            // 
            this.switchToMoodleToolStripMenuItem.Name = "switchToMoodleToolStripMenuItem";
            this.switchToMoodleToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.switchToMoodleToolStripMenuItem.Text = "Switch to Moodle";
            this.switchToMoodleToolStripMenuItem.Click += new System.EventHandler(this.switchToMoodleToolStripMenuItem_Click);
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
            // tbPHPArgs
            // 
            this.tbPHPArgs.Enabled = false;
            this.tbPHPArgs.Location = new System.Drawing.Point(624, 73);
            this.tbPHPArgs.Name = "tbPHPArgs";
            this.tbPHPArgs.ReadOnly = true;
            this.tbPHPArgs.Size = new System.Drawing.Size(114, 20);
            this.tbPHPArgs.TabIndex = 30;
            this.tbPHPArgs.Text = "Coming Soon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 93);
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
            this.tbOutput.Location = new System.Drawing.Point(18, 109);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.Size = new System.Drawing.Size(753, 313);
            this.tbOutput.TabIndex = 33;
            this.tbOutput.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(621, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Custom Prefix";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Actions";
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(310, 67);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(111, 23);
            this.btnClean.TabIndex = 26;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnMigrate
            // 
            this.btnMigrate.Location = new System.Drawing.Point(193, 67);
            this.btnMigrate.Name = "btnMigrate";
            this.btnMigrate.Size = new System.Drawing.Size(111, 23);
            this.btnMigrate.TabIndex = 25;
            this.btnMigrate.Text = "Migrate";
            this.btnMigrate.UseVisualStyleBackColor = true;
            this.btnMigrate.Click += new System.EventHandler(this.btnMigrate_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(76, 67);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(111, 23);
            this.btnInfo.TabIndex = 24;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnSelectFlyway
            // 
            this.btnSelectFlyway.Location = new System.Drawing.Point(471, 41);
            this.btnSelectFlyway.Name = "btnSelectFlyway";
            this.btnSelectFlyway.Size = new System.Drawing.Size(22, 23);
            this.btnSelectFlyway.TabIndex = 22;
            this.btnSelectFlyway.Text = "..";
            this.btnSelectFlyway.UseVisualStyleBackColor = true;
            this.btnSelectFlyway.Click += new System.EventHandler(this.btnSelectFlyway_Click);
            // 
            // tbFlyway
            // 
            this.tbFlyway.Enabled = false;
            this.tbFlyway.Location = new System.Drawing.Point(76, 41);
            this.tbFlyway.Name = "tbFlyway";
            this.tbFlyway.ReadOnly = true;
            this.tbFlyway.ShortcutsEnabled = false;
            this.tbFlyway.Size = new System.Drawing.Size(389, 20);
            this.tbFlyway.TabIndex = 20;
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
            this.helpToolStripMenuItem,
            this.switchToMoodleToolStripMenuItem1,
            this.newVersionAvailableToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 24);
            this.menuStrip1.TabIndex = 28;
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
            this.infoToolStripMenuItem,
            this.migrateToolStripMenuItem,
            this.cleanToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // flywayOpen
            // 
            this.flywayOpen.DefaultExt = "exe";
            this.flywayOpen.Filter = "Flyway Executable (*.exe)|*.exe|All Files|*.*";
            this.flywayOpen.Title = "Select the Flyway Executable";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Coming Soon"});
            this.comboBox1.Location = new System.Drawing.Point(507, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(111, 21);
            this.comboBox1.TabIndex = 34;
            this.comboBox1.Text = "Coming Soon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Select Branch";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // migrateToolStripMenuItem
            // 
            this.migrateToolStripMenuItem.Name = "migrateToolStripMenuItem";
            this.migrateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.migrateToolStripMenuItem.Text = "Migrate";
            this.migrateToolStripMenuItem.Click += new System.EventHandler(this.btnMigrate_Click);
            // 
            // cleanToolStripMenuItem
            // 
            this.cleanToolStripMenuItem.Name = "cleanToolStripMenuItem";
            this.cleanToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cleanToolStripMenuItem.Text = "Clean";
            this.cleanToolStripMenuItem.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // switchToMoodleToolStripMenuItem1
            // 
            this.switchToMoodleToolStripMenuItem1.Name = "switchToMoodleToolStripMenuItem1";
            this.switchToMoodleToolStripMenuItem1.Size = new System.Drawing.Size(112, 20);
            this.switchToMoodleToolStripMenuItem1.Text = "Switch to Moodle";
            this.switchToMoodleToolStripMenuItem1.Click += new System.EventHandler(this.switchToMoodleToolStripMenuItem_Click);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(507, 25);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(276, 23);
            this.progress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progress.TabIndex = 36;
            this.progress.Visible = false;
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
            // FlywayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 434);
            this.Controls.Add(this.progress);
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
            this.Controls.Add(this.btnSelectFlyway);
            this.Controls.Add(this.tbFlyway);
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

        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminateConsoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enabledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disabledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moodleSiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moodlePHPUnitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pHPUnitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pHPToolStripMenuItem;
        private System.Windows.Forms.TextBox tbPHPArgs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.RichTextBox tbOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnMigrate;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnSelectFlyway;
        private System.Windows.Forms.TextBox tbFlyway;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog flywayOpen;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem switchToMoodleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defineFlywayExecutableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem migrateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cleanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem switchToMoodleToolStripMenuItem1;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newVersionAvailableToolStripMenuItem;

    }
}