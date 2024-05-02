using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_SRP.Services
{
    public class NotificacaoServices
    {
        private Notificacao _notificacao;        
        public void NotificacaoRegistrar(Notificacao notificacao)
        {
            _notificacao = notificacao;

            NotificacaoDados.notificacoes.Add(_notificacao);
            
            NotificacaoEmailServices notificacaoEmailServices = new NotificacaoEmailServices(_notificacao);
            notificacaoEmailServices.ValidarEmail();
            notificacaoEmailServices.EnviarEmail();

        }
    }
}