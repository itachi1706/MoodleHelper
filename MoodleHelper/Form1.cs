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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectPhp_Click(object sender, EventArgs e)
        {
            // Launch Option to select PHP File location
            DialogResult result = openPhpFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Handle and save it
                string filename = openPhpFile.FileName;
                tbPhp.Text = filename;
            }
        }

        private void btlSelectMoodle_Click(object sender, EventArgs e)
        {
            // Launch Option to select Moodle Directory Location
            DialogResult result = openMoodleDir.ShowDialog();
            if (result == DialogResult.OK)
            {
                //Handle and save it
                string filename = openMoodleDir.SelectedPath;
                tbMoodle.Text = filename;
            }
        }
    }
}
