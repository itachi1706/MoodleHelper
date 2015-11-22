using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoodleHelper
{
    public partial class Form1 : Form
    {

        string phpPath, moodleDir;
        bool keepConsole = false;

        public Form1()
        {
            InitializeComponent();
            loadSettings();
        }

        private void loadSettings()
        {
            // Load any settings if found
            this.phpPath = Properties.Settings.Default.phpPath;
            this.moodleDir = Properties.Settings.Default.moodleDir;
            this.keepConsole = Properties.Settings.Default.keepConsole;

            // Place into textbox
            updateForm();
        }

        private void updateForm()
        {
            tbMoodle.Text = this.moodleDir;
            tbPhp.Text = this.phpPath;
            enabledToolStripMenuItem.Checked = this.keepConsole ? false : true;
            disabledToolStripMenuItem.Checked = this.keepConsole ? true : false;
        }

        private void saveSettings()
        {
            Properties.Settings.Default.Save();
        }

        private bool checkForMoodleDir()
        {
            if (this.moodleDir != null && this.moodleDir != "")
                return true;
            return false;
        }

        private bool checkForPhp()
        {
            if (this.phpPath != null && this.phpPath != "")
                return true;
            return false;
        }

        private bool checkForPhpAndMoodle()
        {
            if (!checkForPhp())
            {
                //No PHP Executable located
                DialogResult result = MessageBox.Show("No PHP Executable Found! Please OK to define a PHP Executable.", "No PHP Executable Found!", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    selectPHPDir();
                }
                return false;
            }
            if (!checkForMoodleDir())
            {
                //No Moodle Directory Found
                DialogResult result = MessageBox.Show("No Moodle Directory Found! Please OK to define a Moodle Directory.", "No Moodle Dir Found!", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    selectMoodleDir();
                }
                return false;
            }
            
            return true;
        }

        private void startCommandPrompt(string command)
        {
            System.Diagnostics.Process.Start("cmd.exe", command);
        }

        private string getCommandStringStart()
        {
            if (!this.keepConsole)
            {
                return "/C ";
            }
            return "/K ";
        }

        private void btnSelectPhp_Click(object sender, EventArgs e)
        {
            selectPHPDir();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to clear your settings? This action cannot be undone!", "Clear Settings", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Clear Settings
                Properties.Settings.Default.Reset();
                MessageBox.Show("Settings have been cleared!", "Cleared Settings");
            }  else if (result != DialogResult.No)
            {
                MessageBox.Show("An Unknown Error has occurred!", "Unknown Error");
            }
            loadSettings();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btlSelectMoodle_Click(object sender, EventArgs e)
        {
            selectMoodleDir();
        }

        private void selectMoodleDir()
        {
            // Launch Option to select Moodle Directory Location
            DialogResult result = openMoodleDir.ShowDialog();
            if (result == DialogResult.OK)
            {
                //Handle and save it
                this.moodleDir = openMoodleDir.SelectedPath;
                Properties.Settings.Default.moodleDir = this.moodleDir;
                updateForm();
                saveSettings();
            }
        }

        private void selectPHPDir()
        {
            // Launch Option to select PHP File location
            DialogResult result = openPhpFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Handle and save it
                this.phpPath = openPhpFile.FileName;
                Properties.Settings.Default.phpPath = this.phpPath;
                updateForm();
                saveSettings();
            }
        }

        private void btnPurgeCache_Click(object sender, EventArgs e)
        {
            if (!checkForPhpAndMoodle())
                return;
            string cmd = getCommandStringStart();
            cmd += "\"" + this.phpPath + "\" \"" + this.moodleDir + "\\admin\\cli\\purgecaches.php\"";
            startCommandPrompt(cmd);
        }

        private void btnCron_Click(object sender, EventArgs e)
        {
            if (!checkForPhpAndMoodle())
                return;
            string cmd = getCommandStringStart();
            cmd += "\"" + this.phpPath + "\" \"" + this.moodleDir + "\\admin\\cli\\cron.php\"";
            startCommandPrompt(cmd);
        }

        private void enabledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.keepConsole = false;
            Properties.Settings.Default.Save();
            loadSettings();
        }

        private void disabledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.keepConsole = true;
            Properties.Settings.Default.Save();
            loadSettings();
        }

        private void btnPhpUnit_Click(object sender, EventArgs e)
        {
            if (!checkForPhpAndMoodle())
                return;
            MessageBox.Show("COMING SOON", "COMING SOON");
        }
    }
}
