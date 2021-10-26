using Flunt.Notifications;
using Flunt.Validations;
using Intelitrader.Comum.Comandos;
using Intelitrader.Comum.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelitrader.Dominio.Comandos.Usuario
{
    public class CriarContaComandos : Notifiable<Notification>, IComandos
    {
        public CriarContaComandos()
        {

        }

        public CriarContaComandos(string nome, string email, string telefone, string cPF, string senha, EnTipoUsuario tipoUsuario)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            CPF = cPF;
            Senha = senha;
            TipoUsuario = tipoUsuario;
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public string Senha { get; set; }
        public EnTipoUsuario TipoUsuario { get; set; }

        public void Validar()
        {
            AddNotifications(
                new Contract<Notification>()
                    .Requires()
                    .IsNotEmpty(Telefone, "Telefone", "Telefone não poder ser vazio")
                    .IsNotEmpty(CPF, "CPF", "CPF não poder ser vazio")
                    .IsNotEmpty(Nome, "Nome", "Nome não poder ser vazio")
                    .IsEmail(Email, "Email", "O formato do email está incorreto")
                    .IsGreaterOrEqualsThan(Senha, 7, "Senha", "A senha deve ter pelo menos 8 caracteres")
            );
        }
    }
}
