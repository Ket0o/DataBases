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
    public partial class FormEnrollmentOrders : Form
    {
        private static FormEnrollmentOrders _formEnrollmentOrder;

        private void enrollmentOrdersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.enrollmentOrdersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.selection_committeeDataSet);

        }

        private void FormEnrollmentOrders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу
            // "selection_committeeDataSet.EnrollmentOrders".
            // При необходимости она может быть перемещена или удалена.
            this.enrollmentOrdersTableAdapter.Fill
                (this.selection_committeeDataSet.EnrollmentOrders);

        }

        public static FormEnrollmentOrders FormEnrollmentOrder
        {
            get
            {
                if (_formEnrollmentOrder == null || _formEnrollmentOrder.IsDisposed)
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