﻿using AdmissionCommitteeLabs.Properties;
using System;
using System.Windows.Forms;

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
            MessageBox.Show("(C)TUSUR, FVS, Viugin Kirill Vadimovich, 571-2, " +
                            $"{DateTimeOffset.Now.Year}",
                "About program",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }

        private void applicantsDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormApplicantsData.FormApplicantData.ShowForm();
        }

        private void personalFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPersonalFile.FormPersonalsFile.ShowForm();
        }

        private void applicantsRankingListsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormApplicantsRankingLists.FormApplicantRankingList.ShowForm();
        }

        private void enrollmentOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEnrollmentOrders.FormEnrollmentOrder.ShowForm();
        }

        private void personalFileToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormPersonalFileAndRankingLists.FormPersonalsFileAndRankingLists.ShowForm();
        }

        private void sQLRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSQL.FormSql.ShowForm();
        }
    }
}
