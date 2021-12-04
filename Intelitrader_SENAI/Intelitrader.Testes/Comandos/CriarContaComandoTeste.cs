using Intelitrader.Dominio.Comandos.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Intelitrader.Testes.Comandos
{
    public class CriarContaComandoTeste
    {
        
        [Fact]

        public void DeveRetornarSuceesoSeDadosForemValidados()
        {
            var comandos = new CriarContaComandos();
            comandos.Nome = "Lameck";
            comandos.Email = "lameck.v.barbosa@gmail.com";
            comandos.Senha = "123456789";
            comandos.CPF = "08866677713";
            comandos.Foto = "https://www.horadecodar.com.br/wp-content/uploads/2020/04/imagem-ao-lado-de-texto-ex1.png";
            comandos.RG = "https://www.horadecodar.com.br/wp-content/uploads/2020/04/imagem-ao-lado-de-texto-ex1.png";
            comandos.Curriculo = "https://www.horadecodar.com.br/wp-content/uploads/2020/04/imagem-ao-lado-de-texto-ex1.png";
            comandos.Telefone = "11993785259";
            comandos.TipoUsuario = Intelitrader.Comum.Enum.EnTipoUsuario.Funcionario;

            comandos.Validar();

            string erros = "";
            foreach (var item in comandos.Notifications)
            {
                erros += item + " \n";
            }

            Assert.True(comandos.IsValid, "Os dados foram preenchidos corretamente");

        }

    }
}
