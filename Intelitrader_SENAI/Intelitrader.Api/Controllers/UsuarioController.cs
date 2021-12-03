using Intelitrader.Comum.Comandos;
using Intelitrader.Comum.Queries;
using Intelitrader.Dominio.Comandos.Autenticacao;
using Intelitrader.Dominio.Comandos.Usuario;
using Intelitrader.Dominio.Entidades;
using Intelitrader.Dominio.Handlers.Autenticacao;
using Intelitrader.Dominio.Handlers.Usuarios;
using Intelitrader.Dominio.Handlers.UsuariosHandler;
using Intelitrader.Dominio.Repositorios;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Intelitrader.Api.Controllers
{
    [Route("v1/conta")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private IUsuarioRepositorio _usuarioRepositorio { get; set; }

        [Route("criarconta")]
        [HttpPost]
        public ResultadosComandosGenericos Signup(CriarContaComandos comandos, [FromServices] CriarContaHandle handle)
        {
            return (ResultadosComandosGenericos)handle.Handler(comandos);

        }


        [Route("entrar")]
        [HttpPost]
        public ResultadosComandosGenericos Signin(LogarComandos comandos, [FromServices] LogarHandle handle)
        {
            var resultado = (ResultadosComandosGenericos)handle.Handler(comandos);

            if (resultado.Sucesso)
            {
                var token = GenerateJSONWebToken((Usuario)resultado.Data);
                return new ResultadosComandosGenericos(resultado.Sucesso, resultado.Mensagem, new { Token = token });
            }
            return new ResultadosComandosGenericos(false, resultado.Mensagem, resultado.Data);
        }




        // Criamos nosso método que vai gerar nosso Token
        private string GenerateJSONWebToken(Usuario userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("ChaveSecretaIntelitraderSenai132"));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            // Definimos nossas Claims (dados da sessão) para poderem ser capturadas
            // a qualquer momento enquanto o Token for ativo
            var claims = new[] {
            new Claim(JwtRegisteredClaimNames.FamilyName, userInfo.Nome),
            new Claim(JwtRegisteredClaimNames.Email, userInfo.Email),
            new Claim(ClaimTypes.Role, userInfo.TipoUsuario.ToString()),
            new Claim("role", userInfo.TipoUsuario.ToString()),
            new Claim(JwtRegisteredClaimNames.Jti, userInfo.Id.ToString())
    };

            // Configuramos nosso Token e seu tempo de vida
            var token = new JwtSecurityToken
                (
                    "Intelitreder",
                    "Intelitreder",
                    claims,
                    expires: DateTime.Now.AddMinutes(120),
                    signingCredentials: credentials
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        [Route("AttConta")]
        [Authorize(Roles = "Funcionario")]
        [HttpPut]
        public ResultadosComandosGenericos UpdateAccount(
           [FromBody] AtualizarContaComandos command,
           [FromServices] AtualizarContaHandle handler
       )
        {
            var IdConta = HttpContext.User.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Jti);
            command.IdConta = new Guid(IdConta.Value);

            return (ResultadosComandosGenericos)handler.Handler(command);
        }

        [Authorize(Roles = "Funcionario")]
        [HttpDelete("{id}")]
        public ResultadosComandosGenericos Delete(Guid id)
        {
            try
            {
                _usuarioRepositorio.BuscarPorId(id);

                return new ResultadosComandosGenericos(true, "Usuario excluída com sucesso", id);
            }
            catch (Exception erro)
            {
                return new ResultadosComandosGenericos(false, "Insira um Id válido", erro);
            }
        }
    }
}
