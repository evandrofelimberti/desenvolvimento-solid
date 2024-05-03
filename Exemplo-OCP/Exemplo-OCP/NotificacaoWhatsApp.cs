using Exemplo_OCP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_OCP
{
    public class NotificacaoWhatsApp : NotificacaoImpl
    {
        public void Enviar(Usuario usuario)
        {
            Console.WriteLine($"WhatsApp {usuario.Tefefone} enviado com sucesso!!!");  
        }

        public bool Validar(Usuario usuario)
        {
            if (String.IsNullOrEmpty(usuario.Tefefone))
            {
                return false;
            }
            return true;


        }
    }
}
