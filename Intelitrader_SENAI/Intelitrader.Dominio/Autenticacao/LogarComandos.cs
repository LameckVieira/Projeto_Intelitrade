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
    class LogarComandos : Notifiable<Notification>, IComandos
    {
        public LogarComandos(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }

        public string Email { get; set; }
        public string Senha { get; set; }
        public void Validar()
        {
            AddNotifications(
                new Contract<Notification>()
                    .Requires()
                    .IsEmail(Email, "Email", "O formato do email está incorreto")
                    .IsGreaterOrEqualsThan(Senha, 7, "Senha", "A senha deve ter pelo menos 8 caracteres")
            );
        }
    }
}
