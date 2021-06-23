using System;

namespace AppS3A33Ex01 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite senha: ");
            int x = int.Parse(Console.ReadLine());

            while (x != 2002) {
                Console.WriteLine("Senha invalida ");
                Console.Write("Digite a senha: ");
                x = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}
