using CompanyLibrary.Models;
using System;

namespace CompanyApp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Employee[] company = new Employee[]
            {
               new Contractor("Bob", "Bobert"),
               new Contractor("Rick","Rickert"),
               new Manager("Mona","Monalisa"),
               new Manager("Igor","Igorsky"),
               new SalesPerson("Lea","Leova"),
            };
      
            CEO ceoName = new CEO("Ron", "Ronsky", company);
            Console.WriteLine("CEO:");
            ceoName.PrintInfo();
            ceoName.AddSharesPrice(1400);
            var getSalary = ceoName.GetSalary();
            Console.WriteLine($"Salary of CEO is:{getSalary}");
            ceoName.PrintEmployees(company);
           

            Console.WriteLine("------------------------------------------------");

            Manager manager = new Manager("Bob", "Bobsky");
            manager.PrintInfo();
            var bonusF = manager.AddBonus(1500);
            Console.WriteLine($"The bonus is: {bonusF}");
            var mSalary = manager.GetSalary();
            Console.WriteLine($"The salary with bonus is: {mSalary}");

            Console.WriteLine("------------------------------------------------");

            SalesPerson salesPer = new SalesPerson("Radmila", "Sokolovska");
            salesPer.PrintInfo();
            Console.WriteLine(salesPer.GetSalary());

            Console.WriteLine("------------------------------------------------");

            Contractor contractor = new Contractor("Petre", "Petreski");
            contractor.PrintInfo();
            Console.Write("Salary is: ");
            Console.WriteLine(contractor.GetSalary());

            Console.ReadLine();
        }
        
    }
}
