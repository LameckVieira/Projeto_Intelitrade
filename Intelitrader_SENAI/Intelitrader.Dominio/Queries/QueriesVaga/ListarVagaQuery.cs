using Intelitrader.Comum.Enum;
using Intelitrader.Comum.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelitrader.Dominio.Queries.QueriesVaga
{
    public class LIstarVagaQuery : IQuery
    {

        public EnStatusVaga? Ativo { get; set; } = null;

        public void Validar()
        {
            // Ainda não vamos validar
        }

        // Classe para pegar só o que é mais nescessário para o usuário

        public class ListarVagaResult
        {
            public Guid Id { get; set; }
            public string Nome { get; set; }
            public string Descricao { get; set; }
            public int Quanidade { get; set; }
            public DateTime DataCriacao { get; set; }

        }
    }
}
