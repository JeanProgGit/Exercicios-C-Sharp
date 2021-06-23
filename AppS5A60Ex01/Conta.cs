using System;
using System.Collections.Generic;
using System.Text;

namespace AppS5A60Ex01 {
    class Conta {

        public int Numero { get; private set; }
        public string Titulo { get; private set; }
        public string Escolha { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titulo){
            Numero = numero;
            Titulo = titulo;         
     
        }

        public void Deposito (double quantia) {
            Saldo += quantia;
            
        }



    }
}
