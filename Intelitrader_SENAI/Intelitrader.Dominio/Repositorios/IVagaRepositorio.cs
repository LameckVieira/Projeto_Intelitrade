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

        void Cadastrar(Vagas vaga);
        void Alterar(Vagas vaga);
        IEnumerable<Vagas> Listar(EnStatusVaga? ativo = null);
        Vagas BuscarVagaPorNome(string nome);
        Vagas BuscarPorID(Guid id);
        Vagas Delete(Guid id);



    }
}
