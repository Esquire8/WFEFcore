using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WFEFcore.DB
{
    internal class IncomeDTO : IDisposable
    {
        public List<Income> GetAllIncomes()
        {
            List<Income> allIncomes = new List<Income>();

            using (var context = new ApplicationContext())
            {
                allIncomes = context.income.ToList();
            }
            return allIncomes;
        }

        public void AddNewIncome(decimal salary, decimal advancePay)
        {
            Income income = new Income();

            income.Salary = salary;
            income.AdvancePay = advancePay;

            using (var context = new ApplicationContext())
            {
                if(salary == 0 & advancePay == 0)
                {
                    MessageBox.Show("Введите сумму!");
                }
                else
                {
                    context.Add(income);
                    context.SaveChanges();
                }
            }
        }

        public void Dispose()
        {
            // throw new NotImplementedException();
        }
    }
}
