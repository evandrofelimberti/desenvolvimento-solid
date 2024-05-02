using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_SRP
{
    public class Notificacao
    {
        public string Descricao { get; set; }
        public int Codigo { get; set; }
        public EnumTipoNotificacao TipoNotificacao { get; set; }
    }
}
