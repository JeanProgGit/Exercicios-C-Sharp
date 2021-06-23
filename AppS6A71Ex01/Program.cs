using System;

namespace AppS6A71Ex01 {
    class Program {
        static void Main(string[] args) {
           
            Quarto[] vect = new Quarto[10];

            Console.Write("Quantos quartos serao alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <=n; i++) {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome do hóspede: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Numero do quarto: ");
                int numero = int.Parse(Console.ReadLine());
                vect[numero] = new Quarto(nome, email);

            }

            Console.WriteLine();
            Console.WriteLine("Quartos Ocupados");
            for(int i = 0; i < 10; i++) {

                if (vect[i] != null) {

                    Console.WriteLine(i + ":" + vect[i]);
                }

            }
          
            
        }
    }
}
