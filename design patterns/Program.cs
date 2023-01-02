namespace design_patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DepartmentFactory f1 = new DepartmentFactory();

            //creating a tree structure
            Department twitter = f1.CreateDepartment("Twitter");
            //twitter.Add(new Employee(100000));
            //
            Department engineering = f1.CreateDepartment("Engineering");
            for (int i = 0; i < 10; i++)
            {
                engineering.Add(new Employee(20000));
            }
            for (int i = 0; i < 5; i++)
            {
                engineering.Add(new Employee(15000));
            }
            Department eng1 = f1.CreateDepartment("eng1");
            for (int i = 0; i < 100; i++)
            {
                eng1.Add(new Employee(10000));
            }
            Department eng2 = f1.CreateDepartment("eng2");
            for (int i = 0; i < 50; i++)
            {
                eng2.Add(new Employee(30000));
            }
            Department eng3 = f1.CreateDepartment("eng3");
            eng3.Add(new Employee(35000));
            engineering.Add(eng1);
            engineering.Add(eng2);
            engineering.Add(eng3);
            //
            Department hr = f1.CreateDepartment("hr");
            Department hr1 = f1.CreateDepartment("hr1");
            hr1.Add(new Employee(5000));
            Department hr2 = f1.CreateDepartment("hr2");
            hr2.Add(new Employee(7000));
            Department hr3 = f1.CreateDepartment("hr3");
            hr3.Add(new Employee(8000));
            hr.Add(hr1);
            hr.Add(hr2);
            hr.Add(hr3);
            //
            Department lawyers = f1.CreateDepartment("lawyers");
            lawyers.Add(new Employee(40000));
            Department lw1 = f1.CreateDepartment("lw1");
            for (int i = 0; i < 50; i++)
            {
                lw1.Add(new Employee(5000));
            }
            Department lw2 = f1.CreateDepartment("lw2");
            lw2.Add(new Employee(25000));
            //
            twitter.Add(engineering);
            twitter.Add(hr);
            twitter.Add(lawyers);
            //kolik twitter celkem peněz?

            int totalSalaryAmount = 0;
            foreach (Employee e in twitter.Oulist())
            {
                totalSalaryAmount += e.SalaryAmount;
            }
           
            Console.WriteLine(totalSalaryAmount);            

        }
    }
}