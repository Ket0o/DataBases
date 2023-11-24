using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace AdmissionCommitteeLabs.View
{
    public partial class FormSQL : Form
    {
        private static FormSQL _formSql;

        public FormSQL()
        {
            InitializeComponent();
        }

        private DataTable FillDataGridView(string sqlSelect)
        {
            var connection = new
                SqlConnection(Properties.Settings.Default.Selection_committeeConnectionString);
            var command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            var adapter = new SqlDataAdapter { SelectCommand = command };
            var table = new DataTable();
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
                if (_formSql is null || _formSql.IsDisposed)
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
            if (string.IsNullOrEmpty(textBoxApplicant.Text))
            {
                MessageBox.Show("Обязательно укажите id необходимого" +
                                "абитуриента.\nДопустим ввод первых символов.",
                    "Внимание", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            if (checkBoxMore.Checked && string.IsNullOrEmpty(textBoxMore.Text))
            {
                MessageBox.Show("Не указан балл в условии", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkBoxMore.Checked = false;
                return;
            }
            string sqlSelect;
            if (radioButtonDet_Date.Checked)
            {
                sqlSelect = @"SELECT pf.personal_file_ID, pf.Document_submission_date,
                            arl.scores_with_all_achievements_considered, eo.full_name
                            FROM PersonalFile pf
                            JOIN ApplicantsRankingLists arl
                            ON pf.personal_file_ID = arl.personal_file_ID
                            JOIN EnrollmentOrders eo ON arl.ranking_list_ID = eo.ranking_list_ID
                            WHERE pf.personal_file_ID LIKE @ID
                            GROUP BY pf.Document_submission_date,
                            arl.scores_with_all_achievements_considered, pf.personal_file_ID,
                            eo.full_name";
            }
            else
            {
                sqlSelect = radioButtonDet_RankPosition.Checked ? @"SELECT pf.personal_file_ID,
                                arl.scores_with_all_achievements_considered,
                                arl.rank_position, eo.full_name
                                FROM PersonalFile pf
                                JOIN ApplicantsRankingLists arl
                                ON pf.personal_file_ID = arl.personal_file_ID
                                JOIN EnrollmentOrders eo
                                ON arl.ranking_list_ID = eo.ranking_list_ID
                                WHERE pf.personal_file_ID LIKE @ID
                                GROUP BY arl.rank_position,
                                arl.scores_with_all_achievements_considered,
                                pf.personal_file_ID, eo.full_name" : @"SELECT pf.personal_file_ID,
                                arl.scores_with_all_achievements_considered,
                                eo.full_name
                                FROM PersonalFile pf
                                JOIN ApplicantsRankingLists arl
                                ON pf.personal_file_ID = arl.personal_file_ID
                                JOIN EnrollmentOrders eo
                                ON arl.ranking_list_ID = eo.ranking_list_ID
                                WHERE pf.personal_file_ID LIKE @ID
                                GROUP BY arl.scores_with_all_achievements_considered,
                                pf.personal_file_ID, eo.full_name";
            }
            if (checkBoxMore.Checked)
            {
                sqlSelect += " HAVING (scores_with_all_achievements_considered) > @amount";
            }

            if (checkBoxOrder.Checked)
            {
                sqlSelect += " ORDER BY (scores_with_all_achievements_considered) desc";
            }

            var connection = new
                SqlConnection(Properties.Settings.Default.Selection_committeeConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            command.Parameters.AddWithValue("@ID", textBoxApplicant.Text + "%");

            if (checkBoxMore.Checked)
            {
                try
                {
                    command.Parameters.Add("@amount", SqlDbType.Int).Value =
                        double.Parse(textBoxMore.Text);
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

            var adapter = new SqlDataAdapter { SelectCommand = command };
            var table = new DataTable();
            adapter.Fill(table);
            dataGridViewFSelect.DataSource = table;
            if (table.Rows.Count is 0) MessageBox.Show("Нет значений!",
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSubquery_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPersonalFileID.Text))
            {
                MessageBox.Show("Обязательно укажите id необходимого личного дела",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlSelect;
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
            var connection = new
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
            var adapter = new SqlDataAdapter { SelectCommand = command };
            var table = new DataTable();
            adapter.Fill(table);
            dataGridViewSubquery.DataSource = table;
            if (table.Rows.Count is 0) MessageBox.Show("Нет значений!",
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string _fileImage = "";

        private void buttonOpenPhoto_Applicant_Click(object sender, EventArgs e)
        {
            openFileDialogApplicant.Title = "Укажите файл для фото";
            if (openFileDialogApplicant.ShowDialog() is DialogResult.OK)
            {
                _fileImage = openFileDialogApplicant.FileName;
                try
                {
                    pictureBoxPhoto_Applicant.Load(openFileDialogApplicant.FileName);
                }
                catch
                {
                    MessageBox.Show("Выбран не тот формат файла", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else _fileImage = "";
        }

        private void InsertDish()
        {
            if (string.IsNullOrEmpty(textBoxId_applicant.Text) ||
           (string.IsNullOrEmpty(textBoxl_identity.Text) ||
           (string.IsNullOrEmpty(textBoxPersonal_dp.Text) ||
           (string.IsNullOrEmpty(textBoxAdmission.Text) ||
           (string.IsNullOrEmpty(textBoxPrevious_education.Text) ||
            (string.IsNullOrEmpty(textBoxScores.Text)))))))
            {
                MessageBox.Show("Обязательно заполните все поля!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBoxId_applicant.Text, out var id))
            {
                MessageBox.Show("Некоректное значение id абитуриента!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(textBoxl_identity.Text, out var identify))
            {
                MessageBox.Show("Некоректное значение номера документа!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(textBoxPrevious_education.Text, out var previousEducation))
            {
                MessageBox.Show("Некоректное значение номера аттестата!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(textBoxPersonal_dp.Text, out var personalDp))
            {
                MessageBox.Show("Некоректное значение номера заявления!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(textBoxAdmission.Text, out var admission))
            {
                MessageBox.Show("Некоректное значение номера заявления!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(textBoxScores.Text, out var scores))
            {
                MessageBox.Show("Некоректное значение баллов!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            const string sqlInsert = @"INSERT INTO ApplicantsData (applicant_ID,
                                Identity_and_citizenship_document_code,
                                Previous_education_document_code,
                                Admission_application_and_personal_data_processing_consent_code,
                                Enrollment_application_code, Unified_State_Exam_scores, Photo)
                                VALUES (@id, @identify, @previousEducation, @personalDp,
                                @admission, @scores, @Photo)";

            var connection = new
                SqlConnection(Properties.Settings.Default.Selection_committeeConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlInsert;
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@identify", identify);
            command.Parameters.AddWithValue("@previousEducation", previousEducation);
            command.Parameters.AddWithValue("@personalDp", personalDp);
            command.Parameters.AddWithValue("@admission", admission);
            command.Parameters.AddWithValue("@scores", scores);

            if (!string.IsNullOrEmpty(_fileImage))
                command.Parameters.AddWithValue("@Photo",
               File.ReadAllBytes(_fileImage));
            else
            {
                command.Parameters.Add("@Photo", SqlDbType.VarBinary);
                command.Parameters["@Photo"].Value = DBNull.Value;
            }
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса.\n" + err.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            connection.Close();
            buttonSelectApplicants_Click(this, EventArgs.Empty);
        }

        private void UpdateDish()
        {
            if (string.IsNullOrEmpty(textBoxId_applicant.Text))
            {
                MessageBox.Show("Обязательно укажите id абитуриента, для которого " +
                                "будете менять данные", "Внимание", MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(textBoxId_applicant.Text, out var id))
            {
                MessageBox.Show("Некоректное значение id абитуриента!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(textBoxl_identity.Text, out var identify))
            {
                MessageBox.Show("Некоректное значение номера документа!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(textBoxPrevious_education.Text, out var previousEducation))
            {
                MessageBox.Show("Некоректное значение номера аттестата!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(textBoxPersonal_dp.Text, out var personalDp))
            {
                MessageBox.Show("Некоректное значение номера заявления!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(textBoxAdmission.Text, out var admission))
            {
                MessageBox.Show("Некоректное значение номера заявления!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(textBoxScores.Text, out var scores))
            {
                MessageBox.Show("Некоректное значение баллов!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            const string sqlUpdate = "UPDATE ApplicantsData " +
                                     "SET Identity_and_citizenship_document_code = @identify, " +
                                     "Previous_education_document_code = @previousEducation, " +
                                     "Admission_application_and_personal_data_processing_consent_code = " +
                                     "@personalDp, " +
                                     "Enrollment_application_code = @admission, " +
                                     "Unifield_State_Exam_scores = @scores, " +
                                     "Photo = @Photo " +
                                     "WHERE applicant_ID = @id";
            var connection = new
                SqlConnection(Properties.Settings.Default.Selection_committeeConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            var sqlValues = "";
            if (!string.IsNullOrEmpty(textBoxl_identity.Text))
                sqlValues += "Документ удостоверяющий личность=@identify,";
            if (!string.IsNullOrEmpty(textBoxPrevious_education.Text))
                sqlValues += "Документ о предыдущем образовании=@previousEducation,";
            if (!string.IsNullOrEmpty(textBoxPersonal_dp.Text))
                sqlValues += "Заявление на прием и согласие на обработку персональных данных=" +
                             "@personalDp,";
            if (!string.IsNullOrEmpty(textBoxAdmission.Text))
                sqlValues += "Заявление на поступление=@admission,";
            if (!string.IsNullOrEmpty(textBoxScores.Text))
                sqlValues += "Информация о результатах ЕГЭ=@scores,";
            if (!string.IsNullOrEmpty(_fileImage))
                sqlValues += "Фото=@Photo,";

            command.CommandText = string.Format(sqlUpdate);
            if (!string.IsNullOrEmpty(textBoxl_identity.Text))
                command.Parameters.AddWithValue("@identify", identify);
            if (!string.IsNullOrEmpty(textBoxPrevious_education.Text))
                command.Parameters.AddWithValue("@previousEducation", previousEducation);
            if (!string.IsNullOrEmpty(textBoxPersonal_dp.Text))
                command.Parameters.AddWithValue("@personalDp", personalDp);
            if (!string.IsNullOrEmpty(textBoxAdmission.Text))
                command.Parameters.AddWithValue("@admission", admission);
            if (!string.IsNullOrEmpty(textBoxScores.Text))
                command.Parameters.AddWithValue("@scores", scores);
            if (!string.IsNullOrEmpty(_fileImage))
                command.Parameters.AddWithValue("@Photo",
               File.ReadAllBytes(_fileImage));

            command.Parameters.AddWithValue("@id", id);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса:\n" + err.Message,
               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            buttonSelectApplicants_Click(this, EventArgs.Empty);
        }

        private void DeleteDish()
        {
            if (string.IsNullOrEmpty(textBoxId_applicant.Text))
            {
                MessageBox.Show("Обязательно укажите id абитуриента данные которого " +
                                "необходимо удалить", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(textBoxId_applicant.Text, out var id))
            {
                MessageBox.Show("Некоректное значение id абитуриента!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            const string sqlDelete = @"DELETE FROM ApplicantsData WHERE applicant_ID=@id";
            var connection = new
                SqlConnection(Properties.Settings.Default.Selection_committeeConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlDelete;
            command.Parameters.AddWithValue("@id", id);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка удаления");
            }
            connection.Close();
            buttonSelectApplicants_Click(this, EventArgs.Empty);
        }

        private void radioButtonDelete_applicant_CheckedChanged(object sender, EventArgs e)
        {
            panelApplicant.Visible = !radioButtonDelete_applicant.Checked;
        }

        private void buttonSelectApplicants_Click(object sender, EventArgs e)
        {
            dataGridViewApplicants.DataSource = FillDataGridView("SELECT * " +
                                                                 "FROM ApplicantsData");

            var column = (DataGridViewImageColumn)
                dataGridViewApplicants.Columns["Photo"];
            if (column != null)
                column.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void buttonExecuteDML_Click(object sender, EventArgs e)
        {
            if (radioButtonInsert_applicant.Checked)
            {
                InsertDish();
            }
            else
            {
                if (radioButtonUpdate_applicant.Checked)
                {
                    UpdateDish();
                }
                else
                {
                    if (radioButtonDelete_applicant.Checked)
                    {
                        DeleteDish();
                    }
                    else
                    {
                        MessageBox.Show("Вы не выбрали действие", "Внимание",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void FormSQL_Load(object sender, EventArgs e)
        {
            applicantsDataTableAdapter.Fill(admissionCommitteeDataSet.ApplicantsData);
        }
    }
}