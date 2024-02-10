// See https://aka.ms/new-console-template for more information
using Employees;

Console.WriteLine("Hello, World!");

Manager manager1 = new()
{
    Name = "Ivan",
    Rank = 1000,
    VolumeSales = 100000,
    Bonus = 2
};

Manager manager2 = new()
{
    Name = "Petro",
    Rank = 700,
    VolumeSales = 150000,
    Bonus = 2
};

Sequrity sequrity = new()
{
    Name = "Vasyl Vasyliovych",
    Rank = 350
};

Seo seo = new()
{
    Name = "Mykola Leonidovych",
    Rank = 2000
};
seo.Managers.Add(manager1);
seo.Managers.Add(manager2);

List<Employee> employees = new()
{
    manager1, manager2, seo, sequrity
};

foreach (var employe in employees)
{
    Console.WriteLine($"{employe.Name} gets {employe.GetSalary(30)} for 30 days");
}