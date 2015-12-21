using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading;
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
                //No Flyway Executable located
                DialogResult result = MessageBox.Show("No Flyway Executable Defined! Please OK to define the Flyway Executable.", "No Flyway Executable Defined!", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    selectFlywayExe();
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
            progress.Visible = true;

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
            progress.Visible = false;
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
