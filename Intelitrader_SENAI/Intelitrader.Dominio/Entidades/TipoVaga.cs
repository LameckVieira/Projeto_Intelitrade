
using Flunt.Notifications;
using Flunt.Validations;
using Intelitrader.Comum;
using Intelitrader.Comum.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelitrader.Dominio.Entidades
{
    public class TipoVaga : Base
    {
        public TipoVaga(string nomeTipoVaga, string descricao, EnTipoCargo cargo)
        {
            AddNotifications(
           new Contract<Notification>()
               .Requires()
               .IsNotEmpty(nomeTipoVaga, "Nome", "Nome não poder ser vazio")
               .IsNotEmpty(descricao, "Descrição", "Descrição não pode ser vazia")
               .IsNotNull(cargo, "StatusVaga", "Status Vaga não pode ser vazia")
          );
            if (IsValid)
            {
                NomeTipoVaga = nomeTipoVaga;
                Descricao = descricao;
                Cargo = cargo;
            }

        }

        public string NomeTipoVaga { get; private set; }
        public string Descricao { get; private set; }
        public EnTipoCargo Cargo { get; private set; }

        // Composições

        public Guid IdVaga { get; set; }

        public Vagas Vaga { get; set; }
    }

}
