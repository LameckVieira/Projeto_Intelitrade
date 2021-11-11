using Intelitrader.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelitrader.Dominio.Handlers.Autenticacao.VagaHandler
{
    class AtualizarVagaHandle
    {

        // injeção de dependência

        private readonly IVagaRepositorio _vagaRepositorio;

        public AtualizarVagaHandle(IVagaRepositorio vagaRepositorio)
        {
            _vagaRepositorio = vagaRepositorio;
        }



    }
}
