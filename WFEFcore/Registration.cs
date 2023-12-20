using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFEFcore
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {

            string login = tbLogin.Text;
            string password = tbPassword.Text;

            using(var uDTO = new UsersDTO())
            {
                try
                {
                    uDTO.CreateNewUser(login, password);
                    tbLogin.Text = "";
                    tbPassword.Text = "";
                }
                catch(Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
