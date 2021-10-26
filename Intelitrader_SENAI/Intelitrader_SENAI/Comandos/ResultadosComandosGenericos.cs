using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelitrader.Comum.Comandos
{
    public class ResultadosComandosGenericos : IResutadosComandos
    {
        public ResultadosComandosGenericos(bool sucesso, string mensagem, object data)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
            Data = data;
        }

        public bool Sucesso { get; set; }

        public string Mensagem { get; set; }

        public Object Data { get; set; }
    }
}
