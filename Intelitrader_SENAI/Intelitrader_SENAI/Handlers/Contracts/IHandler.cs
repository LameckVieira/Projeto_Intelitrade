using Intelitrader.Comum.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelitrader.Comum.Handlers
{

    // <T> -> Tipo de objeto generico 
    // Where  -> Garante que esse objeto generico esteja erdando da interface IComandos
    public interface IHandler<T> where T : IComandos
    {
        IResultadosComandos Handler(T comandos);
    }
}
