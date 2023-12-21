using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WFEFcore.DB
{
    internal class Income
    {
        [Key] public int Income_id { get; set; }
        public decimal Salary { get; set; }
        public decimal AdvancePay { get; set; }
        public DateTime IncomeDate { get; set; }
    }
}
