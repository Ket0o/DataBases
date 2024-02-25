using System;
using System.Windows.Forms;

namespace AdmissionCommitteeLabs.View
{
    public partial class FormApplicantsData : Form
    {
        private static FormApplicantsData _formApplicantData;

        private void applicantsDataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                applicantsDataBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(admissionCommitteeDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FormApplicantsData_Load(object sender, EventArgs e)
        {
            applicantsDataTableAdapter.Fill(admissionCommitteeDataSet.ApplicantsData);
        }

        public static FormApplicantsData FormApplicantData
        {
            get
            {
                if (_formApplicantData is null || _formApplicantData.IsDisposed)
                {
                    _formApplicantData = new FormApplicantsData();
                }
                return _formApplicantData;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        public FormApplicantsData()
        {
            InitializeComponent();
        }
    }
}