using System;
using System.Windows.Forms;

namespace AdmissionCommitteeLabs.View
{
    public partial class FormApplicantsRankingLists : Form
    {
        private static FormApplicantsRankingLists _formApplicantRankingList;

        private void FormApplicantsRankingLists_Load(object sender, EventArgs e)
        {
            enrollmentOrdersTableAdapter.Fill(admissionCommitteeDataSet.EnrollmentOrders);
            applicantsRankingListsTableAdapter.Fill(admissionCommitteeDataSet.ApplicantsRankingLists);
            applicantsRankingListsTableAdapter.Fill(admissionCommitteeDataSet.ApplicantsRankingLists);
        }

        private void applicantsRankingListsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
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

        public static FormApplicantsRankingLists FormApplicantRankingList
        {
            get
            {
                if (_formApplicantRankingList is null || _formApplicantRankingList.IsDisposed)
                {
                    _formApplicantRankingList = new FormApplicantsRankingLists();
                }
                return _formApplicantRankingList;
            }
        }

        public FormApplicantsRankingLists()
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