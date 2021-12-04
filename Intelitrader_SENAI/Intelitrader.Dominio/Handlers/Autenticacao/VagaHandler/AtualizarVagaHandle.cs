using Flunt.Notifications;
using Intelitrader.Comum.Comandos;
using Intelitrader.Comum.Handlers;
using Intelitrader.Dominio.Comandos.ComandosVaga;
using Intelitrader.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelitrader.Dominio.Handlers.Autenticacao.VagaHandler
{
    public class AtualizarVagaHandle : Notifiable<Notification>, IHandlerComandos<AtualizarVagaComandos>
    {

        // injeção de dependência

        private readonly IVagaRepositorio _vagaRepositorio;

        public AtualizarVagaHandle(IVagaRepositorio vagaRepositorio)
        {
            _vagaRepositorio = vagaRepositorio;
        }


        public IResultadosComandos Handler(AtualizarVagaComandos comandos)
        {
            //Fail Fast Validation
            //Aplicar as validações
            comandos.Validar();

            if (comandos.IsValid)
                return new ResultadosComandosGenericos(false, "Dados inválidos", comandos.Notifications);

            //Verifica se a vaga existe
            var vagas = _vagaRepositorio.BuscarPorID(comandos.IdVaga);

            if (vagas == null)
                return new ResultadosComandosGenericos(false, "vaga não encontrada", null);

            //Verifica se titulo vaga existe
            var vagaExiste = _vagaRepositorio.BuscarVagaPorNome(comandos.Nome);

            if (vagaExiste != null)
                return new ResultadosComandosGenericos(false, "vaga já cadastrado", null);

            //Altera titulo e descricao do vaga
            vagas.AtualizaVaga(comandos.Nome, comandos.Descricao, comandos.Quantidade,comandos.StatusVaga);

            if (vagas.IsValid)
                return new ResultadosComandosGenericos(false, "Dados inválidos", vagas.Notifications);

            //Salvar usuario banco
            _vagaRepositorio.Alterar(vagas);

            //Enviar email de boas vindas

            return new ResultadosComandosGenericos(true, "vaga alterada", null);
        }
    }
}
