using Intelitrader.Comum.Comandos;
using Intelitrader.Dominio.Comandos.Usuario;
using Intelitrader.Dominio.Handlers.Usuarios;
using Intelitrader.Testes.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Intelitrader.Testes.Handlers
{
    public class CriarContaHandlerTeste
    {

        [Fact]
        public void DeveRetornarCasoDadosDoHandleSejamValidos()
        {
            // Criar um um Comando
            var command = new CriarContaComandos();
            command.Nome = "Lameck";
            command.Email = "lmk@email.com";
            command.Senha = "1234567890";
            command.TipoUsuario = Intelitrader.Comum.Enum.EnTipoUsuario.Funcionario;

            // Criar um manipulador
            var handle = new CriarContaHandle(new FakeUsuarioRepositorio());

            // Pegar o resultado
            var resultado = (ResultadosComandosGenericos)handle.Handler(command);

            // Validar Condição
            Assert.True(resultado.Sucesso, "Usuário válidado");


        }

    }
}
