using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdmissionCommitteeLabs.View
{
    public partial class FormSQL : Form
    {
        private static FormSQL _formSql;

        private static DateTime _date = DateTime.Parse("10.08.2023");

        public FormSQL()
        {
            InitializeComponent();
        }

        DataTable FillDataGridView(string sqlSelect)
        {
            SqlConnection connection = new
                SqlConnection(Properties.Settings.Default.Selection_committeeConnectionString);

            SqlCommand command = connection.CreateCommand();

            command.CommandText = sqlSelect;

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;

            DataTable table = new DataTable();

            adapter.Fill(table);
            return table;       
        }

        private void radioButtonApplicantsData_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM ApplicantsData"); 
        }

        private void radioButtonPersonalFile_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView($"SELECT Document_submission_date," +
                                                             $" applicant_ID FROM PersonalFile");
        }

        private void radioButtonApplicantsRankingLists_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * " +
                                                             "FROM ApplicantsRankingLists");
        }
        public static FormSQL FormSql
        {
            get
            {
                if (_formSql == null || _formSql.IsDisposed)
                {
                    _formSql = new FormSQL();
                }
                return _formSql;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void buttonF_select_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxApplicant.Text))
            {
                MessageBox.Show("Обязательно укажите id необходимого" +
                                "абитуриента.\nДопустим ввод первых символов.", 
                    "Внимание", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            if (checkBoxMore.Checked && String.IsNullOrEmpty(textBoxMore.Text))
            {
                MessageBox.Show("Не указан балл в условии", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkBoxMore.Checked = false;
                return;
            }
            string sqlSelect = "";
            if (radioButtonDet_Date.Checked)
            {
                sqlSelect = @""
            }
        }
    }
}
