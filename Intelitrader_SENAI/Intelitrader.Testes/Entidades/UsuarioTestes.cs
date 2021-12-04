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
                "https://www.horadecodar.com.br/wp-content/uploads/2020/04/imagem-ao-lado-de-texto-ex1.png",
                "https://www.horadecodar.com.br/wp-content/uploads/2020/04/imagem-ao-lado-de-texto-ex1.png",
                "https://www.horadecodar.com.br/wp-content/uploads/2020/04/imagem-ao-lado-de-texto-ex1.png",
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
                "https://www.horadecodar.com.br/wp-content/uploads/2020/04/imagem-ao-lado-de-texto-ex1.png",
                "https://www.horadecodar.com.br/wp-content/uploads/2020/04/imagem-ao-lado-de-texto-ex1.png",
                "https://www.horadecodar.com.br/wp-content/uploads/2020/04/imagem-ao-lado-de-texto-ex1.png",
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
                "https://www.horadecodar.com.br/wp-content/uploads/2020/04/imagem-ao-lado-de-texto-ex1.png",
                "https://www.horadecodar.com.br/wp-content/uploads/2020/04/imagem-ao-lado-de-texto-ex1.png",
                "https://www.horadecodar.com.br/wp-content/uploads/2020/04/imagem-ao-lado-de-texto-ex1.png",
                Intelitrader.Comum.Enum.EnTipoUsuario.Funcionario

            );

            Assert.True(!usuario.IsValid, "Usuário invalido senha fraca");

        }

        [Fact]

        public void DeveRetornarSeUsuarioForinvalidoCPFVazio()
        {
            Usuario usuario = new Usuario(
                "Lameck",
                "lameck.v.barbosa@gmail.com",
                "",
                "119937852",
                "123456789",
                "https://www.horadecodar.com.br/wp-content/uploads/2020/04/imagem-ao-lado-de-texto-ex1.png",
                "https://www.horadecodar.com.br/wp-content/uploads/2020/04/imagem-ao-lado-de-texto-ex1.png",
                "https://www.horadecodar.com.br/wp-content/uploads/2020/04/imagem-ao-lado-de-texto-ex1.png",
                Intelitrader.Comum.Enum.EnTipoUsuario.Funcionario

            );

            Assert.True(!usuario.IsValid, "Usuário invalido CPF invalido");

        }

        [Fact]

        public void DeveRetornarSeUsuarioForinvalidoTelefoneVazio()
        {
            Usuario usuario = new Usuario(
                "Lameck",
                "lameck.v.barbosa@gmail.com",
                "08866677713",
                "",
                "123456789",
                "https://www.horadecodar.com.br/wp-content/uploads/2020/04/imagem-ao-lado-de-texto-ex1.png",
                "https://www.horadecodar.com.br/wp-content/uploads/2020/04/imagem-ao-lado-de-texto-ex1.png",
                "https://www.horadecodar.com.br/wp-content/uploads/2020/04/imagem-ao-lado-de-texto-ex1.png",
                Intelitrader.Comum.Enum.EnTipoUsuario.Funcionario

            );

            Assert.True(!usuario.IsValid, "Usuário invalido telefone incompleto");

        }

    }
}
