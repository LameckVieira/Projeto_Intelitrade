using Intelitrader.Comum.Handlers.Contracts;
using Intelitrader.Comum.Queries;
using Intelitrader.Dominio.Queries.QueriesVaga;
using Intelitrader.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Intelitrader.Dominio.Queries.QueriesVaga.LIstarVagaQuery;

namespace Intelitrader.Dominio.Handlers.Autenticacao.VagaHandler
{
    public class ListarVagaHandle : IHandlerQuery<LIstarVagaQuery>
    {

        // injeção de dependência

        private readonly IVagaRepositorio _vagaRepositorio;

        public ListarVagaHandle(IVagaRepositorio vagaRepositorio)
        {
            _vagaRepositorio = vagaRepositorio;
        }

        public IQueryResult Handler(LIstarVagaQuery query)
        {
            var vagas = _vagaRepositorio.Listar(query.Ativo);

            var retornaVaga = vagas.Select(
                x =>
                {
                    return new ListarVagaResult()
                    {
                        Id = x.Id,
                        Nome = x.Nome,
                        Descricao = x.Descricao,
                        DataCriacao = x.DataCriacao,
                        Quanidade = x.Quantidade
                    };

                }
            );


            return new GenericQueryResult(true, "Vaga encontrada", retornaVaga);
        }
    }
}
