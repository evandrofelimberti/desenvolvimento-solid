using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_LSP.Abstracts
{
    public abstract class Conta
    {
        public int Numero { get; set; }
        public decimal Saldo { get; set; }

        public abstract void Deposito(decimal valor);
        public abstract void Saque(decimal valor);
    }
}
