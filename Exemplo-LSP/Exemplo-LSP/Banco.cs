using Exemplo_LSP.Abstracts;
using Exemplo_LSP.Domain;
using Exemplo_LSP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_LSP
{
    public class Banco
    {
        public static void Transacao()
        {
            Conta contaCorrente = new ContaCorrente { Numero = 001, Saldo = 00 };
            Conta contaInvestimento = new ContaCorrente { Numero = 002, Saldo = 500 };

            BancoService bancoService = new BancoService();

            bancoService.TransacaoBancaria(contaCorrente, 200, false);
            bancoService.TransacaoBancaria(contaInvestimento, 200, false);
        }
    }
}
