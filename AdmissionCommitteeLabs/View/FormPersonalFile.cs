﻿using System;
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
    public partial class FormPersonalFile : Form
    {
        private static FormPersonalFile _formPersonalFile;


        private void FormPersonalFile_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "selection_committeeDataSet.ApplicantsRankingLists". При необходимости она может быть перемещена или удалена.
            this.applicantsRankingListsTableAdapter.Fill(this.selection_committeeDataSet.ApplicantsRankingLists);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "selection_committeeDataSet.ApplicantsRankingLists". При необходимости она может быть перемещена или удалена.
            this.applicantsRankingListsTableAdapter.Fill(this.selection_committeeDataSet.ApplicantsRankingLists);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "selection_committeeDataSet.ApplicantsRankingLists". При необходимости она может быть перемещена или удалена.
            this.applicantsRankingListsTableAdapter.Fill(this.selection_committeeDataSet.ApplicantsRankingLists);
            // TODO: данная строка кода позволяет загрузить данные в таблицу
            // "selection_committeeDataSet.PersonalFile".
            // При необходимости она может быть перемещена или удалена.
            this.personalFileTableAdapter.Fill(this.selection_committeeDataSet.PersonalFile);
            // TODO: данная строка кода позволяет загрузить данные в таблицу
            // "selection_committeeDataSet.PersonalFile".
            // При необходимости она может быть перемещена или удалена.
            this.personalFileTableAdapter.Fill(this.selection_committeeDataSet.PersonalFile);

        }

        private void personalFileBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
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

        public static FormPersonalFile FormPersonalsFile
        {
            get
            {
                if (_formPersonalFile == null || _formPersonalFile.IsDisposed)
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
