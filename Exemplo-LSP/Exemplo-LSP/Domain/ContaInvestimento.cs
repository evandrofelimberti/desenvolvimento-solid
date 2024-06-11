using Exemplo_LSP.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_LSP.Domain
{
    public class ContaInvestimento : Conta
    {
        public override void Deposito(decimal valor)
        {
            Saldo += valor;
        }

        public override void Saque(decimal valor)
        {
            if(Saldo < valor)
            {
                throw new Exception("Saldo insuficiente");
            }
            Saldo -= valor;
        }
    }
}
