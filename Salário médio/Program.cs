using System;

namespace AppS4A40Ex02 {
    class Program {
        static void Main(string[] args) {

            Funcionarios x, y;

            x = new Funcionarios();
            y = new Funcionarios();


            Console.WriteLine("Digite os dados do funcionário: ");
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            x.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite os dados do funcionário: ");
            Console.Write("Nome: ");
            y.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            y.Salario = double.Parse(Console.ReadLine());


            double m = (x.Salario + y.Salario) / 2;

            Console.WriteLine("Salário médio = " + m);
                




        }
    }
}
