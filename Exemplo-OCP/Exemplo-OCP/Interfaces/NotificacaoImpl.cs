using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_OCP.Interfaces
{
    public interface NotificacaoImpl
    {
        public bool Validar(Usuario usuario);
        public void Enviar(Usuario usuario);
    }
}
