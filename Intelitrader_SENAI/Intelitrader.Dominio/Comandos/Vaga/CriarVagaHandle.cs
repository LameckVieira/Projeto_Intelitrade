using Flunt.Notifications;
using Intelitrader.Comum.Comandos;
using Intelitrader.Comum.Handlers;
using Intelitrader.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelitrader.Dominio.Comandos.Vaga
{
    public class CriarVagaHandle : Notifiable<Notification>, IHandler<CriarVagaComandos>
    {
        private readonly IVagaRepositorio _vagaRepositorio;

        public CriarVagaHandle(IVagaRepositorio vagaRepositorio)
        {
            _vagaRepositorio = vagaRepositorio;
        }

        public IResultadosComandos Handler(CriarVagaComandos comandos)
        {
            // Validar nosso comandos
            comandos.Validar();

            if (!comandos.IsValid)
            {
                return new ResultadosComandosGenericos
                (
                    false,
                    "Informe os dados da vaga corretamente",
                    comandos.Notifications
                );
            }

            var vagaExiste = _vagaRepositorio.BuscarVagaPorNome(comandos.Nome);
            if (vagaExiste != null)
                return new ResultadosComandosGenericos(false, "Vaga já cadastrada", null);


            // Criar uma instância da vaga
            Vaga vaga = new Vaga
                (
                    comandos.Nome, 
                    comandos.Quantidade, 
                    comandos.StatusVaga, 
                    comandos.Descricao
                );
            if (vaga != null)
                return new ResultadosComandosGenericos(false, "Dados da vaga inválidos", vaga.Notication);
            
            // Adicionar vaga no banco 
            _vagaRepositorio.Cadastrar(vaga);


            // Retornar sucesso
            return new ResultadosComandosGenericos(true, "Vaga cadastrada com sucesso", null);
        }
    }
}
