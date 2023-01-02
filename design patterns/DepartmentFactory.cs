using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    internal class DepartmentFactory
    {
        public Department CreateDepartment(string name)
        {
            return new Department(name);
        }
    }
}
