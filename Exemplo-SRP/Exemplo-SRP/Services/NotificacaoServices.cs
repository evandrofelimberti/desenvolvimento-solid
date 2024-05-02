using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_SRP.Services
{
    public class NotificacaoServices
    {
        public void NotificacaoRegistrar(Notificacao notificacao)
        {
            NotificacaoDados.notificacoes.Add(notificacao);
            
            NotificacaoEmailServices notificacaoEmailServices = new NotificacaoEmailServices(notificacao);
            notificacaoEmailServices.ValidarEmail();
            notificacaoEmailServices.EnviarEmail();

        }
    }
}