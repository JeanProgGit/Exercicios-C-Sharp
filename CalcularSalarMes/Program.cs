using System;
using AppS9A119Ex1.Entities.Enums;
using AppS9A119Ex1.Entities;

namespace AppS9A119Ex1 {
    class Program {
        static void Main(string[] args) {
            
            Console.Write("Digite o nome do departamento: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Dados do trabalhador");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine());

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("Quantos contratos para o trabalhador: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i<= n; i++) {
                
                Console.WriteLine($"Entre #{i} data de contrato");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duraçao (horas): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }
            Console.WriteLine();
            Console.Write("Entre com mes e ano (MM/YYYY)");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Nome: " + worker.Name);
            Console.WriteLine("Departamento: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month));
        }
    }
}
