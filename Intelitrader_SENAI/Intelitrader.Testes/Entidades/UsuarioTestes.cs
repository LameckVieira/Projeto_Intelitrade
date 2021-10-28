using Intelitrader.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Intelitrader.Testes.Entidades
{
    public class UsuarioTestes
    {

        [Fact]

        public void DeveRetornarSuceesoSeUsuarioForValido()
        {
            Usuario usuario = new Usuario(
                "Lameck",
                "lameck.v.barbosa@gmail.com",
                "08866677713",
                "11993785259",
                "123456789",
                Intelitrader.Comum.Enum.EnTipoUsuario.Funcionario
            );

            Assert.True(usuario.IsValid, "Usuário valido");
        }

        [Fact]

        public void DeveRetornarSeUsuarioForinvalidoSemEmail()
        {
            Usuario usuario = new Usuario(
                "Lameck",
                "lameck.v.barbosa",
                "08866677713",
                "11993785259",
                "123456789",
                Intelitrader.Comum.Enum.EnTipoUsuario.Funcionario
            );

            Assert.True(!usuario.IsValid, "Usuário invalido sem email");

        }

        [Fact]

        public void DeveRetornarSeUsuarioForinvalidoSenhaFraca()
        {
            Usuario usuario = new Usuario(
                "Lameck",
                "lameck.v.barbosa@gmail.com",
                "08866677713",
                "119937852",
                "123",
                Intelitrader.Comum.Enum.EnTipoUsuario.Funcionario

            );

            Assert.True(!usuario.IsValid, "Usuário invalido senha fraca");

        }

        [Fact]

        public void DeveRetornarSeUsuarioForinvalidoCPFIncompleto()
        {
            Usuario usuario = new Usuario(
                "Lameck",
                "lameck.v.barbosa@gmail.com",
                "08866677713",
                "119937852",
                "123456789",
                Intelitrader.Comum.Enum.EnTipoUsuario.Funcionario

            );

            Assert.True(!usuario.IsValid, "Usuário invalido CPF invalido");

        }

        [Fact]

        public void DeveRetornarSeUsuarioForinvalidoTelefoneIncompleto()
        {
            Usuario usuario = new Usuario(
                "Lameck",
                "lameck.v.barbosa@gmail.com",
                "08866677713",
                "11993",
                "123456789",
                Intelitrader.Comum.Enum.EnTipoUsuario.Funcionario

            );

            Assert.True(!usuario.IsValid, "Usuário invalido telefone incompleto");

        }

    }
}
