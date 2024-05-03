using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_OCP
{
    public class NotificacaoEnvioUsuario
    {
        private static void ValidareEnviarEmail(Usuario usuario)
        {
            NotificacaoEmail notificacaoEmail = new NotificacaoEmail();
            bool podeEnviar = notificacaoEmail.Validar(usuario);
            if (podeEnviar)
            {
                notificacaoEmail.Enviar(usuario);
            }           
        }

        private static void ValidareEnviarWhatsApp(Usuario usuario)
        {
            NotificacaoWhatsApp notificacaoWhatsApp = new NotificacaoWhatsApp();
            bool podeEnviar = notificacaoWhatsApp.Validar(usuario);
            if (podeEnviar)
            {
                notificacaoWhatsApp.Enviar(usuario);
            }
           
        }

        public static void EnviarNotificacao()
        {
            Usuario usuario = new Usuario { Codigo = 1, 
                Nome = "Jose Silva", Email = "josesilvar@teste.com", Tefefone = "47912341234" };

            ValidareEnviarEmail(usuario);
            ValidareEnviarWhatsApp(usuario);

        }
    }
}

