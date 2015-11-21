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
            tbMoodle.Text = this.moodleDir;
            tbPhp.Text = this.phpPath;
        }

        private void saveSettings()
        {
            Properties.Settings.Default.Save();
        }

        private void btnSelectPhp_Click(object sender, EventArgs e)
        {
            // Launch Option to select PHP File location
            DialogResult result = openPhpFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Handle and save it
                this.phpPath = openPhpFile.FileName;
                tbPhp.Text = this.phpPath;
                Properties.Settings.Default.phpPath = this.phpPath;
                saveSettings();
            }
        }

        private void btlSelectMoodle_Click(object sender, EventArgs e)
        {
            // Launch Option to select Moodle Directory Location
            DialogResult result = openMoodleDir.ShowDialog();
            if (result == DialogResult.OK)
            {
                //Handle and save it
                this.moodleDir = openMoodleDir.SelectedPath;
                tbMoodle.Text = this.moodleDir;
                Properties.Settings.Default.moodleDir = this.moodleDir;
                saveSettings();
            }
        }
    }
}
