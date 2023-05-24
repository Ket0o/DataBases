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
                sqlSelect = @"SELECT d.personal_file_ID, Document_submission_date, 
                            s.scores_with_all_achievements_considered, w.full_name
                            FROM PersonalFile d, ApplicantsRankingLists s, EnrollmentOrders w
                            WHERE d.personal_file_ID = s.personal_file_ID AND
                            s.ranking_list_ID = w.ranking_list_ID
                            GROUP BY d.Document_submission_date, 
                            s.scores_with_all_achievements_considered, d.personal_file_ID, 
                            w.full_name";
            }
            else
            {
                if (radioButtonDet_RankPosition.Checked)
                {
                    sqlSelect = @"SELECT d.personal_file_ID, 
                            s.scores_with_all_achievements_considered, rank_position, w.full_name
                            FROM PersonalFile d, ApplicantsRankingLists s, EnrollmentOrders w
                            WHERE d.personal_file_ID = s.personal_file_ID AND
                            s.ranking_list_ID = w.ranking_list_ID
                            GROUP BY s.rank_position, scores_with_all_achievements_considered,
                            d.personal_file_ID, w.full_name";
                }
                else
                {
                    sqlSelect = @"SELECT d.personal_file_ID, 
                            s.scores_with_all_achievements_considered, w.full_name
                            FROM PersonalFile d, ApplicantsRankingLists s, EnrollmentOrders w
                            WHERE d.personal_file_ID = s.personal_file_ID AND
                            s.ranking_list_ID = w.ranking_list_ID
                            GROUP BY s.scores_with_all_achievements_considered, 
                            d.personal_file_ID, w.full_name";
                }
            }

            if (checkBoxMore.Checked)
            {
                sqlSelect += " HAVING (scores_with_all_achievements_considered) > @amount";
            }

            if (checkBoxOrder.Checked)
            {
                sqlSelect += " ORDER BY (scores_with_all_achievements_considered) desc";
            }

            SqlConnection connection = new
                SqlConnection(Properties.Settings.Default.Selection_committeeConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;

            if (checkBoxMore.Checked)
            {
                try
                {
                    command.Parameters.Add("@amount", SqlDbType.Int).Value =
                        Double.Parse(textBoxMore.Text);
                }
                catch
                {
                    MessageBox.Show("Баллы в условии должны быть заданы " +
                                    "числом", "ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    checkBoxMore.Checked = false;
                    return;
                }
            }

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewFSelect.DataSource = table;
            if (table.Rows.Count == 0) MessageBox.Show("Нет значений!",
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonSubquery_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxPersonalFileID.Text))
            {
                MessageBox.Show("Обязательно укажите id необходимого личного дела",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlSelect = "";

            if (radioButtonCorrelated.Checked)
            {
                sqlSelect = @"SELECT pf.personal_file_ID, a.applicant_ID,
                              CONCAT(
                                (SELECT eo.full_name FROM EnrollmentOrders eo 
                                WHERE eo.ranking_list_ID = arl.ranking_list_ID),
                                ' - ',
                                (SELECT eo.university_group FROM EnrollmentOrders eo 
                                WHERE eo.ranking_list_ID = arl.ranking_list_ID)
                              ) AS Student
                            FROM PersonalFile pf
                            JOIN ApplicantsData a ON pf.applicant_ID = a.applicant_ID
                            JOIN ApplicantsRankingLists arl ON arl.personal_file_ID = pf.personal_file_ID
                            WHERE pf.personal_file_ID = @number";
            }
            else
            {
                if (radioButtonNoCorrelated.Checked)
                {
                    sqlSelect = @"SELECT pf.personal_file_ID, a.applicant_ID, CONCAT(eo.full_name,
                                ' - ', eo.university_group) AS Student, 
                                arl.scores_with_all_achievements_considered AS Scores
                                FROM PersonalFile pf
                                JOIN ApplicantsData a ON pf.applicant_ID = a.applicant_ID
                                JOIN ApplicantsRankingLists arl ON arl.personal_file_ID = pf.personal_file_ID
                                JOIN EnrollmentOrders eo ON eo.ranking_list_ID = arl.ranking_list_ID
                                WHERE pf.personal_file_ID = @number";
                }
                else
                {
                    MessageBox.Show("Не выбрали вид подзапроса", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            SqlConnection connection = new
                SqlConnection(Properties.Settings.Default.Selection_committeeConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;

            try
            {
                command.Parameters.Add("@number", SqlDbType.Int).Value =
                    int.Parse(textBoxPersonalFileID.Text);
            }
            catch
            {
                MessageBox.Show("Номер продажи в условии должен быть задан " +
                                "числом", "Ошибка", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewSubquery.DataSource = table;
            if (table.Rows.Count == 0) MessageBox.Show("Нет значений!",
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
