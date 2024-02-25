using AdmissionCommitteeLabs.Model;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AdmissionCommitteeLabs.View
{
    public partial class FormAuthorization : Form
    {
        private static bool IsConnectionEstablished(string connectionString)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string connectionString;
            do
            {
                connectionString = ConnectionStringBuilder.GetConnectionString(userNameTextBox.Text,
                    passwordTextBox.Text);
                try
                {
                    using (var connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        MessageBox.Show("Успешное подключение!");
                        this.Hide();
                        var mainForm = new MainForm();
                        mainForm.ShowDialog();
                        Application.Exit();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString() + "\r\n\r\n Введите корректные данные");
                    break;
                }
            } while (!IsConnectionEstablished(connectionString));
        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (userNameTextBox.Text.Length > 0 && passwordTextBox.Text.Length > 0)
            {
                enterButton.Enabled = true;
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordTextBox.Text.Length > 0 && userNameTextBox.Text.Length > 0)
            {
                enterButton.Enabled = true;
            }
        }

        public FormAuthorization()
        {
            InitializeComponent();
        }
    }
}
