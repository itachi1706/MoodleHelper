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
        bool showConsole = false;

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
            this.showConsole = Properties.Settings.Default.keepConsole;

            // Place into textbox
            updateForm();
        }

        private void updateForm()
        {
            tbMoodle.Text = this.moodleDir;
            tbPhp.Text = this.phpPath;
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
                MessageBox.Show("No PHP Executable Found, Please define a PHP Executable", "No PHP Executable Found!");
                return false;
            }
            if (!checkForMoodleDir())
            {
                //No Moodle Directory Found
                MessageBox.Show("No Moodle Directory is Found. Please define a Moodle Directory!", "No Moodle Dir Found!");
                return false;
            }
            
            return true;
        }

        private void btnSelectPhp_Click(object sender, EventArgs e)
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
        }

        private void btnCron_Click(object sender, EventArgs e)
        {
            if (!checkForPhpAndMoodle())
                return;
        }

        private void btnPhpUnit_Click(object sender, EventArgs e)
        {
            if (!checkForPhpAndMoodle())
                return;
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
    }
}
