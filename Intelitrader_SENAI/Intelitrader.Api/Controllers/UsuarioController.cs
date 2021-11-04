using Intelitrader.Comum.Comandos;
using Intelitrader.Dominio.Comandos.Usuario;
using Intelitrader.Dominio.Handlers.Usuarios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intelitrader.Api.Controllers
{
    [Route("vi/account")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [Route("signup")]
        [HttpPost]
        public ResultadosComandosGenericos Signup(CriarContaComandos comandos, [FromServices] CriarContaHandle handle)
        {
            return (ResultadosComandosGenericos)handle.Handler(comandos);

        }

    }
}
