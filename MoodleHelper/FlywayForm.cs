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
    public partial class FlywayForm : Form
    {

        string flywayPath;
        bool keepConsole = false;

        public FlywayForm()
        {
            InitializeComponent();
            loadSettings();
        }

        private void loadSettings()
        {
            // Load any settings if found
            this.flywayPath = Properties.Settings.Default.flywayPath;
            this.keepConsole = Properties.Settings.Default.keepConsole;

            // Place into textbox
            updateForm();
        }

        private void updateForm()
        {
            tbFlyway.Text = this.flywayPath;
            enabledToolStripMenuItem.Checked = this.keepConsole ? false : true;
            disabledToolStripMenuItem.Checked = this.keepConsole ? true : false;
        }

        private void saveSettings()
        {
            Properties.Settings.Default.Save();
        }

        private void selectFlywayExe()
        {
            // Launch Option to select PHP File location
            DialogResult result = flywayOpen.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Handle and save it
                this.flywayPath = flywayOpen.FileName;
                Properties.Settings.Default.flywayPath = this.flywayPath;
                updateForm();
                saveSettings();
            }
        }

        private bool checkForFlyway()
        {
            if (this.flywayPath != null && this.flywayPath != "")
                return true;
            return false;
        }

        private bool checkForFlywayExist()
        {
            if (!checkForFlyway())
            {
                //No PHP Executable located
                DialogResult result = MessageBox.Show("No Flyway Executable Defined! Please OK to define the Flyway Executable.", "No Flyway Executable Defined!", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    selectFlywayExe();
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
            processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            processStartInfo.UseShellExecute = false;
            processStartInfo.CreateNoWindow = true;
            Process process = Process.Start(processStartInfo);
            string output = string.Empty;
            string error = string.Empty;
            progress.Visible = true;
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
            progress.Visible = false;
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

        private void runFlywayClean()
        {
            string cmd = getCommandStringStart();
            cmd += "\"\"" + this.flywayPath + "\" \"clean";
            startCommandPrompt(cmd);
        }

        private void runFlywayInfo()
        {
            string cmd = getCommandStringStart();
            cmd += "\"\"" + this.flywayPath + "\" \"info";
            startCommandPrompt(cmd);
        }

        private void runFlywayInfo(string args)
        {
            string cmd = getCommandStringStart();
            // TODO: Handle Args
            cmd += "\"\"" + this.flywayPath + "\" \"info";
            startCommandPrompt(cmd);
        }

        private void runFlywayMigrate()
        {
            string cmd = getCommandStringStart();
            cmd += "\"\"" + this.flywayPath + "\" \"migrate";
            startCommandPrompt(cmd);
        }

        private void runFlywayMigrate(string args)
        {
            string cmd = getCommandStringStart();
            // TODO: Handle Args
            cmd += "\"\"" + this.flywayPath + "\" \"migrate";
            startCommandPrompt(cmd);
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

        private void switchToMoodleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MoodleForm form = new MoodleForm();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void btnSelectFlyway_Click(object sender, EventArgs e)
        {
            selectFlywayExe();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (!checkForFlywayExist())
                return;
            runFlywayInfo();
        }

        private void btnMigrate_Click(object sender, EventArgs e)
        {
            if (!checkForFlywayExist())
                return;
            runFlywayMigrate();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            if (!checkForFlywayExist())
                return;
            runFlywayClean();
        }
    }
}
