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
    public class Vagas : Base
    {
        public Vagas()
        {

        }


        public Vagas(string nome, int quantidade, string descricao, EnStatusVaga statusVaga)
        {
            AddNotifications(
           new Contract<Notification>()
               .Requires()
               .IsNotEmpty(nome, "Nome", "Nome não poder ser vazio")
               .IsNotNull(quantidade, "Qantidade", "Qantidade não poder ser vazio")
               .IsNotEmpty(descricao, "Descrição", "Descrição não pode ser vazia")
               .IsNotNull(statusVaga, "StatusVaga", "Status Vaga não pode ser vazia")
          );

            if (IsValid)
            {
                Nome = nome;
                Quantidade = quantidade;
                Descricao = descricao;
                StatusVaga = statusVaga;
            }
        }

        public string Nome { get; private set; }
        public int Quantidade { get; private set; }
        public string Descricao { get; private set; }
        public EnStatusVaga StatusVaga { get; private set; }

        //composções
        public IReadOnlyCollection<Descricao> Descricaos { get { return _descricaos.ToArray(); } }

    }
}