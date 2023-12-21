using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFEFcore.DB;

namespace WFEFcore
{
    public partial class AddIncome : Form
    {
        public AddIncome()
        {
            InitializeComponent();
        }

        private void AddIncome_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            //Инициализация переменных для добавления дохода
            string salary = tbxSalary.Text;
            string advancePay = tbxAdvancePay.Text;
            DateTime incomeDate = DateTime.UtcNow;

            if (salary != "" && advancePay != "")
            {
                decimal dSalary = decimal.Parse(salary);
                decimal dAdvancePay = decimal.Parse(advancePay);

                using (var iDTO = new IncomeDTO())
                {
                    iDTO.AddNewIncome(dSalary, dAdvancePay, incomeDate);
                }
            }
            else
            {
                MessageBox.Show("Введите значения");
            }
        }

        
    }
}
