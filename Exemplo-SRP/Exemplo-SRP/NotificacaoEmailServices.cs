using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exemplo_SRP.Interfaces;
using Exemplo_SRP.Services;

namespace Exemplo_SRP
{
    public class NotificacaoEmailServices : NotificacaoEmailImpl
    {
        private Notificacao _notificacao; 
        public NotificacaoEmailServices(Notificacao notificacao){
            _notificacao = notificacao;
        }
        public void EnviarEmail()
        {
            Console.WriteLine("Enviando e-mail ...");                        
            Console.WriteLine($" Codigo: {_notificacao.Codigo} \n Descrição: {_notificacao.Descricao} \n E-mail enviado com sucesso!");
        }

        public void ValidarEmail()
        {
            Console.WriteLine("Validando e-mail...");

            if (String.IsNullOrEmpty(_notificacao.Descricao)){
                throw new Exception("E-mail sem descrição");
            }            
            Console.WriteLine($" Codigo: {_notificacao.Codigo} \n Descrição: {_notificacao.Descricao} \n Sem Nenhuma restrição!");
        }
    }
}