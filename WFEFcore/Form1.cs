using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WFEFcore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<User> allUsers = new List<User>();

            using (var uDTO = new UsersDTO())
            {
                allUsers = uDTO.GetAllUsers();
            }

            string login = tbLogin.Text;
            string password = tbPassword.Text;

            if (allUsers.Where(l => l.user_login == login).Where(p => p.user_password == password).FirstOrDefault() != null)
            {
                MessageBox.Show("Успешный вход в систему!");
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Такого пользователя нет!");
            }
        }

        private void liLblRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Hide();
        }
    }
}
