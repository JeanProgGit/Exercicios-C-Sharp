using System;
using System.Collections.Generic;

namespace AppS6A71Ex02 {
    class Program {
        static void Main(string[] args) {
          
            Console.Write("Quantos funcioários serao registrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <= n; i++) {
                Console.WriteLine("Funcionário#" + i + ":");
                Console.Write("Digite o ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Digite o Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o salário: ");
                double salario = double.Parse(Console.ReadLine());
                list.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();

            }

            Console.WriteLine("Entre com o ID do funcionário que terá o salário aumentado");
            int procId = int.Parse(Console.ReadLine());

            Funcionario func = list.Find(x => x.Id == procId);
            
            if (func != null) {
                Console.WriteLine("Entre com a porcentagem");
                double porcentagem = double.Parse(Console.ReadLine());
                func.AumentoSalario(porcentagem);
            }
            else {
                Console.WriteLine("Este ID nao existe");
            }
            Console.WriteLine();
            Console.WriteLine("Lista dos funcionarios atualizada");
            foreach (Funcionario obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}
