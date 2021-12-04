using Flunt.Notifications;
using Flunt.Validations;
using Intelitrader.Comum.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelitrader.Dominio.Comandos.Autenticacao
{
    class AlterarSenhaComandos : Notifiable<Notification>, IComandos
    {
        public AlterarSenhaComandos(string senha)
        {
            Senha = senha;
        }

        public string Senha { get; set; }

        public void Validar()
        {
            AddNotifications(
                new Contract<Notification>()
                    .Requires()
                    .IsGreaterOrEqualsThan(Senha, 7, "Senha", "A senha deve ter pelo menos 8 caracteres")
            );
        }
    }
}
