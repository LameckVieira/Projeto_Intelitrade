using Flunt.Notifications;
using Intelitrader.Comum.Comandos;
using Intelitrader.Comum.Handlers;
using Intelitrader.Comum.Utils;
using Intelitrader.Dominio.Comandos.Autenticacao;
using Intelitrader.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelitrader.Dominio.Handlers.Autenticacao
{
    public class LogarHandle : Notifiable<Notification>, IHandler<LogarComandos>
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public LogarHandle(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public IResultadosComandos Handler(LogarComandos comandos)
        {
            // Validar nosso comandos
            comandos.Validar();

            if (!comandos.IsValid)
            {
                return new ResultadosComandosGenericos
                (
                    false,
                    "Informe os dados do usuário corretamente",
                    comandos.Notifications
                );
            }

            // Buscar usuário por email

            var usuario = _usuarioRepositorio.BuscarPorEmail(comandos.Email);

            // Usuario existe?

            if (usuario == null)
            {
                return new ResultadosComandosGenericos(false, "Dados de acesso inválidos", null);
            }

            // Validar hashes
            if (!Senha.ValidarHashes(comandos.Senha, usuario.Senha))
                return new ResultadosComandosGenericos(false, "dados de acesso inválidos", null);

            return new ResultadosComandosGenericos(true, "Logado com sucesso!", usuario);
        }
    }
}
