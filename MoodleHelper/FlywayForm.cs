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
    public partial class FlywayForm : Form
    {
        public FlywayForm()
        {
            InitializeComponent();
        }

        private void switchToMoodleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MoodleForm form = new MoodleForm();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
