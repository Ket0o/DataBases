using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmissionCommitteeLabs.View
{
    public partial class FormApplicantsRankingLists : Form
    {
        private static FormApplicantsRankingLists _formApplicantRankingList;

        private void FormApplicantsRankingLists_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "selection_committeeDataSet.ApplicantsRankingLists". При необходимости она может быть перемещена или удалена.
            this.applicantsRankingListsTableAdapter.Fill(this.selection_committeeDataSet.ApplicantsRankingLists);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "selection_committeeDataSet.ApplicantsRankingLists". При необходимости она может быть перемещена или удалена.
            this.applicantsRankingListsTableAdapter.Fill(this.selection_committeeDataSet.ApplicantsRankingLists);

        }

        private void applicantsRankingListsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.applicantsRankingListsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.selection_committeeDataSet);
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
                if (_formApplicantRankingList == null || _formApplicantRankingList.IsDisposed)
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
