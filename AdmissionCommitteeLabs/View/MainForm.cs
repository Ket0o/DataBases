using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdmissionCommitteeLabs.Properties;

namespace AdmissionCommitteeLabs.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Do you want to close the program?",
                           "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                       DialogResult.Yes;
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)TUSUR, FVS, Viugin Kirill Vadimovich, 571-2, 2023", 
                "About program",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }
    }
}
