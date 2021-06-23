using System;

namespace AppS4A40Ex01 {
    class Program {
        static void Main(string[] args) {

            Dados x, y;

            x = new Dados();
            y = new Dados();

            Console.WriteLine("Entre com os dados da primeira pessoa: ");
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            x.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com os dados da segunda pessoa: ");
            Console.Write("Nome: ");
            y.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            y.Idade = int.Parse(Console.ReadLine());

            if (x.Idade > y.Idade) {

                Console.WriteLine("Dados da primeira pessoa: ");
                Console.WriteLine("Nome: " + x.Nome);
                Console.WriteLine("Idade " + x.Idade);

                Console.WriteLine("Dados da segunda pessoa: ");
                Console.WriteLine("Nome: " + y.Nome);
                Console.WriteLine("Idade " + y.Idade);

            }

            else {

                Console.WriteLine("Dados da primeira pessoa: ");
                Console.WriteLine("Nome: " + y.Nome);
                Console.WriteLine("Idade " + y.Idade);

                Console.WriteLine("Dados da segunda pessoa: ");
                Console.Write("Nome: " + x.Nome);
                Console.Write("Idade " + x.Idade);

            }



        }
    }
}
