using Flunt.Notifications;
using Intelitrader.Comum.Comandos;
using Intelitrader.Comum.Handlers;
using Intelitrader.Dominio.Comandos.Usuario;
using Intelitrader.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelitrader.Dominio.Handlers.UsuariosHandler
{
    public class AtualizarContaHandle : Notifiable<Notification>, IHandlerComandos<AtualizarContaComandos>
    {
        // injeção de dependência

        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public AtualizarContaHandle(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public IResultadosComandos Handler(AtualizarContaComandos comandos)
        {
            //Fail Fast Validation
            //Aplicar as validações
            comandos.Validar();

            if (comandos.IsValid)
                return new ResultadosComandosGenericos(false, "Dados inválidos", comandos.Notifications);

            //Verifica se a conta existe
            var contas = _usuarioRepositorio.BuscarPorId(comandos.IdConta);

            if (contas == null)
                return new ResultadosComandosGenericos(false, "Conta não encontrada", null);

            //Verifica se titulo conta existe
            var contaExiste = _usuarioRepositorio.BuscarPorEmail(comandos.Email);

            if (contaExiste != null)
                return new ResultadosComandosGenericos(false, "Conta já cadastrado", null);

            //Altera titulo e descricao do conta
            contas.AtualizaUsuario(comandos.Nome, comandos.Email, comandos.Telefone, comandos.CPF);

            if (contas.IsValid)
                return new ResultadosComandosGenericos(false, "Dados inválidos", contas.Notifications);

            //Salvar usuario banco
            _usuarioRepositorio.Alterar(contas);

            //Enviar email de boas vindas

            return new ResultadosComandosGenericos(true, "Conta alterada", null);
        }
    }
}
