using Flunt.Notifications;
using Flunt.Validations;
using Intelitrader.Comum.Comandos;
using Intelitrader.Comum.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelitrader.Dominio.Comandos.Vaga
{
    public class CriarVagaComandos : Notifiable<Notification>, IComandos
    {
        public CriarVagaComandos()
        {

        }

        public CriarVagaComandos(string nome, int quantidade, string descricao, EnStatusVaga statusVaga)
        {
            Nome = nome;
            Quantidade = quantidade;
            Descricao = descricao;
            StatusVaga = statusVaga;
        }

        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public string Descricao { get; set; }
        public EnStatusVaga StatusVaga { get; set; }

        public void Validar()
        {
            AddNotifications(
                new Contract<Notification>()
                    .Requires()
                    .IsNotEmpty(Nome, "Nome", "Nome não poder ser vazio")
                    .IsNotNull(Quantidade, "Quantidade", "Quantidade não poder ser vazio")
                    .IsNotEmpty(Descricao, "Descrição", "Descrição não poder ser vazio")
                    .IsNotNull(StatusVaga, "Status da vaga", "Status da vaga não poder ser vazio")
            ); 
        }
    }
}
