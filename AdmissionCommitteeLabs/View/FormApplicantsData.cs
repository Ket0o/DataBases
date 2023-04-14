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
    public partial class FormApplicantsData : Form
    {
        private static FormApplicantsData _formApplicantData;


        private void applicantsDataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.applicantsDataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.selection_committeeDataSet);

        }

        private void FormApplicantsData_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу
            // "selection_committeeDataSet.ApplicantsData".
            // При необходимости она может быть перемещена или удалена.
            this.applicantsDataTableAdapter.Fill(this.selection_committeeDataSet.ApplicantsData);

        }

        public static FormApplicantsData FormApplicantData
        {
            get
            {
                if (_formApplicantData == null || _formApplicantData.IsDisposed)
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
