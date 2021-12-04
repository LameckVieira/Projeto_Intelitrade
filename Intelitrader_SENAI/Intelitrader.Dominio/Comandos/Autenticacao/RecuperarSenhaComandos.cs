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
    class RecuperarSenhaComandos : Notifiable<Notification>, IComandos
    {
        public RecuperarSenhaComandos(string email)
        {
            Email = email;
        }

        public string Email { get; set; }

        public void Validar()
        {
            AddNotifications(
                 new Contract<Notification>()
                     .Requires()
                     .IsEmail(Email, "Email", "O formato do email está incorreto")
             );
        }
    }
}
