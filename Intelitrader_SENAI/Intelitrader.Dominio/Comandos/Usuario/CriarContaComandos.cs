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

        public CriarContaComandos(string nome, string email, string telefone, string cpf, string foto, string rg, string curriculo, string senha, EnTipoUsuario tipoUsuario)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            CPF = cpf;
            Curriculo = curriculo;
            RG = rg;
            Foto = foto;
            Senha = senha;
            TipoUsuario = tipoUsuario;
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public string Foto { get; set; }
        public string RG { get; set; }
        public string Curriculo { get; set; }
        public string Senha { get; set; }
        public EnTipoUsuario TipoUsuario { get; set; }

        public void Validar()
        {
            AddNotifications(
                new Contract<Notification>()
                    .Requires()
                    .IsNotNull(Telefone, "Telefone", "Telefone não poder ser vazio")
                    .IsNotNull(CPF, "CPF", "CPF não poder ser vazio")
                    .IsNotEmpty(Nome, "Nome", "Nome não poder ser vazio")
                    .IsEmail(Email, "Email", "O formato do email está incorreto")
                    .IsNotNull(Foto, "CPF", "CPF não poder ser vazio")
                    .IsNotNull(RG, "Nome", "Nome não poder ser vazio")
                    .IsNotNull(Curriculo, "CPF", "CPF não poder ser vazio")
                    .IsGreaterOrEqualsThan(Senha, 7, "Senha", "A senha deve ter pelo menos 8 caracteres")
            );
        }
    }
}
