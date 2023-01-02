using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    internal class Employee : IOrganizationUnit
        //leaf
    {
        public int SalaryAmount { get; set; }
        public Employee(int salaryAmount)
        {
            SalaryAmount = salaryAmount;
        }

        public void Add(IOrganizationUnit io)
        {
            Console.WriteLine("Cannot add to a leaf.");
        }

    }
}
