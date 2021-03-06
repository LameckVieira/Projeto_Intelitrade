using Intelitrader.Comum.Comandos;
using Intelitrader.Comum.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelitrader.Comum.Handlers.Contracts
{
    public interface IHandlerQuery<T> where T : IQuery
    {      
        IQueryResult Handler(T comandos);
        
    }
}
