using System;
using System.Windows.Forms;

namespace AdmissionCommitteeLabs.View
{
    public partial class FormEnrollmentOrders : Form
    {
        private static FormEnrollmentOrders _formEnrollmentOrder;

        private void enrollmentOrdersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                enrollmentOrdersBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(admissionCommitteeDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FormEnrollmentOrders_Load(object sender, EventArgs e)
        {
            enrollmentOrdersTableAdapter.Fill(admissionCommitteeDataSet.EnrollmentOrders);
        }

        public static FormEnrollmentOrders FormEnrollmentOrder
        {
            get
            {
                if (_formEnrollmentOrder is null || _formEnrollmentOrder.IsDisposed)
                {
                    _formEnrollmentOrder = new FormEnrollmentOrders();
                }
                return _formEnrollmentOrder;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        public FormEnrollmentOrders()
        {
            InitializeComponent();
        }
    }
}