using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFEFcore.DB;

namespace WFEFcore
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            string salaryRuName = "Зарплата";
            string AdvancePayRuName = "Аванс";

            //Список всех доходов
            List<Income> allIncomes = new List<Income>();


            using(var iDTO = new IncomeDTO())
            {
                allIncomes = iDTO.GetAllIncomes();
            }

            //Вывод в DataGridView
            dgvIncome.DataSource = allIncomes;
            dgvIncome.Columns[1].HeaderText = salaryRuName;
            dgvIncome.Columns[2].HeaderText = AdvancePayRuName;
        }

        //Кнопка Добавить доход
        private void btnIncome_Click(object sender, EventArgs e)
        {
            AddIncome addIncome = new AddIncome();
            addIncome.Show();
        }

        //Кнопка Обновить
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string salaryRuName = "Зарплата";
            string AdvancePayRuName = "Аванс";

            List<Income> allIncomes = new List<Income>();

            using (var iDTO = new IncomeDTO())
            {
                allIncomes = iDTO.GetAllIncomes();
            }

            dgvIncome.DataSource = allIncomes;
            dgvIncome.Columns[1].HeaderText = salaryRuName;
            dgvIncome.Columns[2].HeaderText = AdvancePayRuName;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
