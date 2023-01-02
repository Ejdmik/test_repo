using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    internal class Department : IOrganizationUnit
        //composite
    {
        public string Name { get; set; }
        public Department(string name)
        {
            Name = name;
            oulist = new List<IOrganizationUnit>();
        }


        public void Add(IOrganizationUnit ou)
        {
            oulist.Add(ou);
        }
        
        private IList<IOrganizationUnit> oulist;
        public IEnumerable<IOrganizationUnit> Oulist()
        {
            foreach (IOrganizationUnit ou in oulist)
            {
                yield return ou;
            }
        }

        //public IOrganizationUnit AddEmployee(int salaryAmount)
        //{
        //    IOrganizationUnit ou = new Employee(salaryAmount);
        //    this.oulist.Add(ou);
        //    return ou;
        //}

    }
}
