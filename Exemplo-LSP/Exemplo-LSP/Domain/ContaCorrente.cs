using Exemplo_LSP.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_LSP.Domain
{
    public class ContaCorrente : Conta
    {
        public decimal Limite { get; set; }

        public override void Deposito(decimal valor)
        {
            Saldo += valor;
        }

        public override void Saque(decimal valor)
        {
            if((Saldo + Limite) < valor)
            {
                throw new Exception("Valor de saque ulrapassou o limite.");
            }
            Saldo -= valor;
        }
    }
}
