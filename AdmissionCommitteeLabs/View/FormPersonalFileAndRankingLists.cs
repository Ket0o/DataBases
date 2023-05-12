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
    public partial class FormPersonalFileAndRankingLists : Form
    {
        private static FormPersonalFileAndRankingLists _formPersonalFileAndRankingLists;


        private void personalFileBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.personalFileBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.selection_committeeDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FormPersonalFileAndRankingLists_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "selection_committeeDataSet.ApplicantsRankingLists". При необходимости она может быть перемещена или удалена.
            this.applicantsRankingListsTableAdapter.Fill(this.selection_committeeDataSet.ApplicantsRankingLists);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "selection_committeeDataSet.ApplicantsRankingLists". При необходимости она может быть перемещена или удалена.
            this.applicantsRankingListsTableAdapter.Fill(this.selection_committeeDataSet.ApplicantsRankingLists);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "selection_committeeDataSet.PersonalFile". При необходимости она может быть перемещена или удалена.
            this.personalFileTableAdapter.Fill(this.selection_committeeDataSet.PersonalFile);

        }

        private void applicantsRankingListsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
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

        public static FormPersonalFileAndRankingLists FormPersonalsFileAndRankingLists
        {
            get
            {
                if (_formPersonalFileAndRankingLists == null || _formPersonalFileAndRankingLists.IsDisposed)
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
