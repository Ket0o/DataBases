using System;
using System.Windows.Forms;

namespace AdmissionCommitteeLabs.View
{
    public partial class FormPersonalFileAndRankingLists : Form
    {
        private static FormPersonalFileAndRankingLists _formPersonalFileAndRankingLists;

        private void personalFileBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                personalFileBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(admissionCommitteeDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FormPersonalFileAndRankingLists_Load(object sender, EventArgs e)
        {
            applicantsRankingListsTableAdapter.Fill(admissionCommitteeDataSet.ApplicantsRankingLists);
            applicantsRankingListsTableAdapter.Fill(admissionCommitteeDataSet.ApplicantsRankingLists);
            personalFileTableAdapter.Fill(admissionCommitteeDataSet.PersonalFile);
        }

        private void applicantsRankingListsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                applicantsRankingListsBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(admissionCommitteeDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static FormPersonalFileAndRankingLists FormPersonalsFileAndRankingLists
        {
            get
            {
                if (_formPersonalFileAndRankingLists is null
                    || _formPersonalFileAndRankingLists.IsDisposed)
                {
                    _formPersonalFileAndRankingLists = new FormPersonalFileAndRankingLists();
                }
                return _formPersonalFileAndRankingLists;
            }
        }

        public FormPersonalFileAndRankingLists()
        {
            InitializeComponent();
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }
    }
}