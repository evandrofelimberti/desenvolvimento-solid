using Exemplo_SRP;

namespace TestExemplo_SRP
{
    public class UnitTest1
    {
        [Fact]
        public void ValidarNotificacaoEmail()
        {
            Notificacao notificacao = new Notificacao { Codigo = 1, Descricao = "", TipoNotificacao = EnumTipoNotificacao.Alerta };
            string exceptMessagem = "E-mail sem descri��o";

            NotificacaoEmailServices notificacaoEmailServices = new NotificacaoEmailServices(notificacao);
            var ex = Assert.Throws<Exception>(() => notificacaoEmailServices.ValidarEmail());
            Assert.Equal(exceptMessagem, ex.Message);
        }
    }
}