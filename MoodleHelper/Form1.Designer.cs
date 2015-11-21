namespace MoodleHelper
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.label4 = new System.Windows.Forms.Label();
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
            this.tbPhp.Size = new System.Drawing.Size(389, 20);
            this.tbPhp.TabIndex = 2;
            // 
            // tbMoodle
            // 
            this.tbMoodle.Enabled = false;
            this.tbMoodle.Location = new System.Drawing.Point(76, 68);
            this.tbMoodle.Name = "tbMoodle";
            this.tbMoodle.Size = new System.Drawing.Size(389, 20);
            this.tbMoodle.TabIndex = 3;
            // 
            // btnSelectPhp
            // 
            this.btnSelectPhp.Location = new System.Drawing.Point(471, 36);
            this.btnSelectPhp.Name = "btnSelectPhp";
            this.btnSelectPhp.Size = new System.Drawing.Size(22, 23);
            this.btnSelectPhp.TabIndex = 4;
            this.btnSelectPhp.Text = "..";
            this.btnSelectPhp.UseVisualStyleBackColor = true;
            this.btnSelectPhp.Click += new System.EventHandler(this.btnSelectPhp_Click);
            // 
            // btlSelectMoodle
            // 
            this.btlSelectMoodle.Location = new System.Drawing.Point(470, 65);
            this.btlSelectMoodle.Name = "btlSelectMoodle";
            this.btlSelectMoodle.Size = new System.Drawing.Size(23, 23);
            this.btlSelectMoodle.TabIndex = 5;
            this.btlSelectMoodle.Text = "...";
            this.btlSelectMoodle.UseVisualStyleBackColor = true;
            this.btlSelectMoodle.Click += new System.EventHandler(this.btlSelectMoodle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Purge Cache";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Run Cron";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Run PHPUnit Tests";
            this.button3.UseVisualStyleBackColor = true;
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(505, 24);
            this.menuStrip1.TabIndex = 10;
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
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
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
            // runPHPUnitToolStripMenuItem
            // 
            this.runPHPUnitToolStripMenuItem.Name = "runPHPUnitToolStripMenuItem";
            this.runPHPUnitToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.runPHPUnitToolStripMenuItem.Text = "Run PHP Unit Tests";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "COMING SOON. CONSOLE VIEW";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btlSelectMoodle);
            this.Controls.Add(this.btnSelectPhp);
            this.Controls.Add(this.tbMoodle);
            this.Controls.Add(this.tbPhp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Moodle Helper";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
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
        private System.Windows.Forms.Label label4;
    }
}

