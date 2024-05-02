using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exemplo_SRP.Services;

namespace Exemplo_SRP
{
    public class ExemploSRP
    {
        public static void CriarNotificacao()
        {
            try
            {
                Notificacao notificacao = new Notificacao
                {
                    Codigo = 1,
                    Descricao = "Promoção camisa 30% avista",
                    TipoNotificacao = EnumTipoNotificacao.Informativo,
                };

                NotificacaoServices notificacaoServices = new NotificacaoServices();
                notificacaoServices.NotificacaoRegistrar(notificacao);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}