using Intelitrader.Comum.Enum;
using Intelitrader.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelitrader.Dominio.Repositorios
{
    public interface IVagaRepositorio
    {

        void Cadastrar(Vaga vaga);
        void Alterar(Vaga vaga);
        IEnumerable<Vaga> Listar(EnStatusVaga? ativo = null);
        Vaga BuscarVagaPorNome(string nome);
        Vaga BuscarPorID(Guid id);



    }
}
