using Exemplo_OCP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_OCP
{

    public class NotificacaoEmail : NotificacaoImpl
    {
        public void Enviar(Usuario usuario)
        {
            Console.WriteLine($"Email {usuario.Email} enviado com sucesso!!!");
        }

        public bool Validar(Usuario usuario)
        {
            if (String.IsNullOrEmpty(usuario.Email))
            {
                return false;
            }
            return true;
        }
    }
}
