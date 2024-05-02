using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_SRP.Interfaces
{
    public interface NotificacaoEmailImpl
    {
        void EnviarEmail();
        void ValidarEmail();
    }

    public interface NotificacaoWhatsAppImpl
    {
        void EnviarWhatsApp();
        void ValidarWhatsApp();
    }    
}