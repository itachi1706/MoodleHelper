using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoodleHelper
{
    public partial class MoodleForm : Form
    {

        string phpPath, moodleDir;
        bool keepConsole = false;

        public MoodleForm()
        {
            InitializeComponent();
            loadSettings();
            checkForUpdates();
        }

        private async void checkForUpdates()
        {
            using (WebClient wc = new WebClient())
            {
                var versionString = wc.DownloadString("http://android.itachi1706.com/apps/updates/MoodleHelper");
                string[] versions = versionString.Split('.');
                int[] intver = new int[versions.Length];

                for (int i = 0; i < versions.Length; i++)
                {
                    string ver = versions[i];
                    int veri;
                    if (Int32.TryParse(ver, out veri))
                    {
                        intver[i] = veri;
                    }
                    else
                    {
                        intver[i] = 0;
                    }
                }
                newVersionAvailableToolStripMenuItem.Visible = compareVersionAndCheckIfNewer(intver);
            }
        }

        private bool compareVersionAndCheckIfNewer(int[] serverVersion)
        {
            if (serverVersion.Length != 4) return true; // Just make them update
            Version serverv = new Version(serverVersion[0], serverVersion[1], serverVersion[2], serverVersion[3]);
            Version version = Assembly.GetExecutingAssembly().GetName().Version;

            if (serverv.Major > version.Major) return true;
            if (serverv.Minor > version.Minor) return true;
            if (serverv.Build > version.Build) return true;
            if (serverv.Revision > version.Revision) return true;
            return false;
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

        private async void startCommandPrompt(string command)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = "cmd";
            processStartInfo.Arguments = command;
            processStartInfo.RedirectStandardError = true;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            processStartInfo.UseShellExecute = false;
            processStartInfo.CreateNoWindow = true;
            Process process = new Process();
            process.StartInfo = processStartInfo;
            StringBuilder output = new StringBuilder();
            StringBuilder error = new StringBuilder();
            Int32 timeout = 21600000;
            tbOutput.Clear();
            //progress.Visible = true;

            using (AutoResetEvent outputWaitHandle = new AutoResetEvent(false))
            using (AutoResetEvent errorWaitHandle = new AutoResetEvent(false))
            {
                process.OutputDataReceived += (sender, e) =>
                {
                    if (e.Data == null)
                    {
                        outputWaitHandle.Set();
                    }
                    else
                    {
                        output.AppendLine(e.Data + "\n");
                        // Print it to outputbox
                        tbOutput.AppendText(e.Data + "\n");
                    }
                };
                process.ErrorDataReceived += (sender, e) =>
                {
                    if (e.Data == null)
                    {
                        errorWaitHandle.Set();
                    }
                    else
                    {
                        error.AppendLine(e.Data + "\n");
                        // Print it to outputbox
                        tbOutput.AppendText(e.Data + "\n");
                    }
                };

                process.Start();

                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                if (process.WaitForExit(timeout) && outputWaitHandle.WaitOne(timeout) && errorWaitHandle.WaitOne(timeout))
                {
                    output.Append("The process finished with exit code: " + process.ExitCode + "\n");
                }
                else
                {
                    error.Append("Timed Out\n");
                }
            }
            //progress.Visible = false;
            string finalOutput = "Command Executed: " + command + "\nCommand Ran At: ";
            finalOutput += process.StartTime.ToString() + "\n";
            finalOutput += output.ToString();
            if (error.Length != 0)
            {
                finalOutput += "\nThe following errors are found: \n";
                finalOutput += error.ToString();
            }
            tbOutput.Lines = parseOutput(finalOutput);
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

        private void switchToFlywayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FlywayForm form = new FlywayForm();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            string text = String.Format("Moodle Helper \n Version: {0}.{1}.{2}.{3}", version.Major, version.Minor, version.Build, version.Revision);
            MessageBox.Show(text, "About");
        }

        private void newVersionAvailableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/itachi1706/MoodleHelper/releases/latest");

        }

        private void tbOutput_TextChanged(object sender, EventArgs e)
        {
            tbOutput.SelectionStart = tbOutput.Text.Length;
            tbOutput.ScrollToCaret();
        }
    }
}
