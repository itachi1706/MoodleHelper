using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

        private string startCommandPrompt(string command)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = "cmd";
            processStartInfo.Arguments = command;
            processStartInfo.RedirectStandardError = true;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
            processStartInfo.UseShellExecute = false;
            Process process = Process.Start(processStartInfo);
            string output = string.Empty;
            string error = string.Empty;
            using (StreamReader streamreader = process.StandardOutput)
            {
                output = streamreader.ReadToEnd();
            }
            using (StreamReader streamReader = process.StandardError)
            {
                error = streamReader.ReadToEnd();
            }

            string finalOutput = "Command Executed: " + command + "\nCommand Ran At: ";
            finalOutput += process.StartTime.ToString() + "\n";
            finalOutput += output;
            if (!string.IsNullOrEmpty(error))
            {
                finalOutput += "\nThe following errors are found: \n";
                finalOutput += error;
            }
            tbOutput.Lines = parseOutput(finalOutput);
            return finalOutput;
        }

        private string[] parseOutput(string output)
        {
            return output.Split('\n');
        }

        private string getCommandStringStart()
        {
            if (!this.keepConsole)
            {
                return "/c ";
            }
            return "/K ";
        }

        private void initPHPUnitTests()
        {
            string cmd = getCommandStringStart();
            cmd += "\"\"" + this.phpPath + "\" \"" + this.moodleDir + "\\admin\\tool\\phpunit\\cli\\init.php\"\"";
            startCommandPrompt(cmd);
        }

        private void runFullPHPUnitTests()
        {
            string cmd = getCommandStringStart();
            cmd += "\"\"" + this.moodleDir + "\\vendor\\bin\\phpunit\"\"";
            startCommandPrompt(cmd);
        }

        private void runFullPHPUnitTests(string args)
        {
            string cmd = getCommandStringStart();
            cmd += "\"\"" + this.moodleDir + "\\vendor\\bin\\phpunit\" " + args + "\"";
            startCommandPrompt(cmd);
        }

        private void runBothInitAndPhpUnitTests()
        {
            string cmd = getCommandStringStart();
            cmd += "\"\"" + this.phpPath + "\" \"" + this.moodleDir + "\\admin\\tool\\phpunit\\cli\\init.php\" ";
            cmd += "& \"" + this.moodleDir + "\\vendor\\bin\\phpunit\"\"";
            startCommandPrompt(cmd);
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

        /* Menu Items On Click */
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to clear your settings? This action cannot be undone!", "Clear Settings", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Clear Settings
                Properties.Settings.Default.Reset();
                MessageBox.Show("Settings have been cleared!", "Cleared Settings");
            }
            else if (result != DialogResult.No)
            {
                MessageBox.Show("An Unknown Error has occurred!", "Unknown Error");
            }
            loadSettings();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void initToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkForPhpAndMoodle())
            {
                return;
            }
            initPHPUnitTests();
        }
        private void pHPUnitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkForPhpAndMoodle())
            {
                return;
            }
            runFullPHPUnitTests();
        }
        private void moodleSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.moodle.org/dev/Main_Page");
        }

        private void pHPUnitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://phpunit.de/manual/current/en/index.html");
        }

        private void moodlePHPUnitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.moodle.org/dev/PHPUnit");
        }

        private void pHPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://php.net/manual/en/index.php");
        }

        /* Buttons Click Listeners */
        private void btnPhpUnit_Click(object sender, EventArgs e)
        {
            if (!checkForPhpAndMoodle())
                return;
            runBothInitAndPhpUnitTests();
        }
        private void btnPhpUnitWithArgs_Click(object sender, EventArgs e)
        {
            if (!checkForPhpAndMoodle())
            {
                return;
            }
            string args = tbPHPArgs.Text;
            if (args != null && args != "")
            {
                runFullPHPUnitTests(args);
            }
            else
            {
                runFullPHPUnitTests();
            }
        }
        private void btnPurgeCache_Click(object sender, EventArgs e)
        {
            if (!checkForPhpAndMoodle())
                return;
            string cmd = getCommandStringStart();
            cmd += "\"\"" + this.phpPath + "\" \"" + this.moodleDir + "\\admin\\cli\\purge_caches.php\"\"";
            startCommandPrompt(cmd);
        }
        private void btnCron_Click(object sender, EventArgs e)
        {
            if (!checkForPhpAndMoodle())
                return;
            string cmd = getCommandStringStart();
            cmd += "\"\"" + this.phpPath + "\" \"" + this.moodleDir + "\\admin\\cli\\cron.php\"\"";
            startCommandPrompt(cmd);
        }
        private void btnSelectPhp_Click(object sender, EventArgs e)
        {
            selectPHPDir();
        }
        private void btlSelectMoodle_Click(object sender, EventArgs e)
        {
            selectMoodleDir();
        }
    }
}
