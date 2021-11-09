using Flunt.Notifications;
using Intelitrader.Comum.Comandos;
using Intelitrader.Comum.Handlers;
using Intelitrader.Comum.Utils;
using Intelitrader.Dominio.Comandos.Usuario;
using Intelitrader.Dominio.Entidades;
using Intelitrader.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelitrader.Dominio.Handlers.Usuarios
{
    public class CriarContaHandle : Notifiable<Notification>, IHandlerComandos<CriarContaComandos>
    {

        // Injeção de dependência

        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public CriarContaHandle(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public IResultadosComandos Handler(CriarContaComandos comandos)
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

            // Validar se o email existe
            var usuarioExiste = _usuarioRepositorio.BuscarPorEmail(comandos.Email);

            if (usuarioExiste != null)
                return new ResultadosComandosGenericos (false, "Email já cadastrado", "informe outro email");

            // Criptografar minha senha
            comandos.Senha = Senha.Criptografar(comandos.Senha);
            // Salvar no banco -> repositorio.Adicionar(usuario)

            Usuario usuario = new Usuario
                (
                    comandos.Nome,
                    comandos.Email,
                    comandos.Senha,
                    comandos.CPF,
                    comandos.Telefone,
                    comandos.RG,
                    comandos.Foto,
                    comandos.Curriculo,
                    comandos.TipoUsuario
                );

            if (!usuario.IsValid)
                return new ResultadosComandosGenericos(false, "Dados de usuário inválidos", usuario.Notifications);

            _usuarioRepositorio.Adicionar(usuario);

            return new ResultadosComandosGenericos(true, "Usuario criado", "Token");

        }
    }
}
