using Exemplo_LSP.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_LSP.Services
{
    public class BancoService
    {
        public void TransacaoBancaria(Conta conta, decimal valor, bool ehDeposito)
        {
            try
            {
                if (ehDeposito)
                {
                    conta.Deposito(valor);
                    Console.WriteLine($"Conta {conta.Numero.ToString("0.##")} \nDepósito {valor} efetuado com sucesso!\nNovo Saldo {conta.Saldo.ToString("0.##")}");
                }
                else
                {
                    conta.Saque(valor);
                    Console.WriteLine($"Conta {conta.Numero.ToString("0.##")} \nSaque {valor} efetuado com sucesso!\nNovo Saldo {conta.Saldo.ToString("0.##")}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
