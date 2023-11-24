using System;
using System.Windows.Forms;

namespace AdmissionCommitteeLabs.View
{
    public partial class FormPersonalFile : Form
    {
        private static FormPersonalFile _formPersonalFile;

        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            if (personalFiletoolStripTextBoxFind.Text is "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int indexPos;
            try
            {
                indexPos = personalFileBindingSource.Find(GetSelectedFieldName(),
                        personalFiletoolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos != -1)
                personalFileBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких id нет", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                personalFileBindingSource.Position = 0;
            }
        }

        private string GetSelectedFieldName()
        {
            return
                personalFileDataGridView.Columns[personalFileDataGridView.CurrentCell.ColumnIndex]
                    .DataPropertyName;
        }

        private void FormPersonalFile_Load(object sender, EventArgs e)
        {
            applicantsRankingListsTableAdapter.Fill(admissionCommitteeDataSet.ApplicantsRankingLists);
            applicantsRankingListsTableAdapter.Fill(admissionCommitteeDataSet.ApplicantsRankingLists);
            applicantsRankingListsTableAdapter.Fill(admissionCommitteeDataSet.ApplicantsRankingLists);
            personalFileTableAdapter.Fill(admissionCommitteeDataSet.PersonalFile);
            personalFileTableAdapter.Fill(admissionCommitteeDataSet.PersonalFile);
        }

        private void checkBoxFind_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFind.Checked)
            {
                if (personalFiletoolStripTextBoxFind.Text is "")
                    MessageBox.Show("Вы ничего не задали", "Внимание",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    try
                    {
                        personalFileBindingSource.Filter =
                            GetSelectedFieldName() + "='" + personalFiletoolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                                        err.Message);
                    }
                }
            }
            else
            {
                personalFileBindingSource.Filter = "";
            }

            if (personalFileBindingSource.Count != 0) return;
            MessageBox.Show("Нет таких");
            personalFileBindingSource.Filter = "";
            checkBoxFind.Checked = false;
        }

        private void personalFileBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
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

        public static FormPersonalFile FormPersonalsFile
        {
            get
            {
                if (_formPersonalFile is null || _formPersonalFile.IsDisposed)
                {
                    _formPersonalFile = new FormPersonalFile();
                }
                return _formPersonalFile;
            }
        }

        public FormPersonalFile()
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