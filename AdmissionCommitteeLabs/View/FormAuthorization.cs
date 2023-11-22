﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdmissionCommitteeLabs.Model;
using AdmissionCommitteeLabs.Properties;

namespace AdmissionCommitteeLabs.View
{
    public partial class FormAuthorization : Form
    {
        static bool IsConnectionEstablished(string connectionString)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
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
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        MessageBox.Show("Успешное подключение!");
                        this.Hide();
                        MainForm mainForm = new MainForm();
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

        public FormAuthorization()
        {
            InitializeComponent();
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
    }
}
