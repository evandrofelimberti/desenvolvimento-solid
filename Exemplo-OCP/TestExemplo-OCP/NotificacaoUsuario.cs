using Exemplo_OCP;
namespace TestExemplo_OCP
{
    public class NotificacaoUsuario
    {
        [Fact]
        public void ValidaEmailPreenchido()
        {
            Usuario usuario = new Usuario
            {
                Codigo = 1,
                Nome = "Jose Silva",
                Email = "josesilvar@teste.com",
                Tefefone = "47912341234"
            };
            NotificacaoEmail notificacaoEmail = new NotificacaoEmail();
            bool podeEnviar = notificacaoEmail.Validar(usuario);
            Assert.True(podeEnviar);

        }

        [Fact]
        public void ValidaEmailVazio()
        {
            Usuario usuario = new Usuario
            {
                Codigo = 1,
                Nome = "Jose Silva",
                Email = "",
                Tefefone = "47912341234"
            };
            NotificacaoEmail notificacaoEmail = new NotificacaoEmail();
            bool podeEnviar = notificacaoEmail.Validar(usuario);
            Assert.False(podeEnviar);

        }

        [Fact]
        public void ValidaWhatsAppPreenchido()
        {
            Usuario usuario = new Usuario
            {
                Codigo = 1,
                Nome = "Jose Silva",
                Email = "josesilvar@teste.com",
                Tefefone = "47912341234"
            };
            NotificacaoWhatsApp notificacaoWhatsApp = new NotificacaoWhatsApp();
            bool podeEnviar = notificacaoWhatsApp.Validar(usuario);
            Assert.True(podeEnviar);

        }

        [Fact]
        public void ValidaWhatsAppVazio()
        {
            Usuario usuario = new Usuario
            {
                Codigo = 1,
                Nome = "Jose Silva",
                Email = "josesilvar@teste.com",
                Tefefone = ""
            };
            NotificacaoWhatsApp notificacaoWhatsApp = new NotificacaoWhatsApp();
            bool podeEnviar = notificacaoWhatsApp.Validar(usuario);
            Assert.False(podeEnviar);

        }
    }
}