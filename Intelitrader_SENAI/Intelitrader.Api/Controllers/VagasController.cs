using Intelitrader.Comum.Comandos;
using Intelitrader.Comum.Enum;
using Intelitrader.Comum.Queries;
using Intelitrader.Dominio.Comandos.Vaga;
using Intelitrader.Dominio.Comandos.VagaCommands;
using Intelitrader.Dominio.Handlers.Autenticacao.VagaHandler;
using Intelitrader.Dominio.Queries.QueriesVaga;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Intelitrader.Api.Controllers
{
    [Route("v1/vagas")]
    [ApiController]
    public class VagasController : ControllerBase
    {
        [Route("v1/criarvaga")]
        [HttpPost]
        [Authorize(Roles = "Funcionario")]

        public ResultadosComandosGenericos Create(CriarVagaComandos comandos, [FromServices] CriarVagaHandle handle)
        {
            return (ResultadosComandosGenericos)handle.Handler(comandos);
        }

        [Route("v1/listarvaga")]
        [HttpGet]
        public GenericQueryResult GetAll([FromServices] ListarVagaHandle handle)
        {
            // Ciramos uma instancia nova para a query
            LIstarVagaQuery query = new LIstarVagaQuery();

            var tipoUsuario = HttpContext.User.Claims.FirstOrDefault(t => t.Type == ClaimTypes.Role);

            if (tipoUsuario.Value.ToString() == EnTipoUsuario.Funcionario.ToString())
            {
                query.Ativo = EnStatusVaga.Ativo;
            }
            return (GenericQueryResult)handle.Handler(query);


        }
    }
}
