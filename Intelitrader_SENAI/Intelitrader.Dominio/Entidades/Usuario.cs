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
    public class Usuario : Base
    {
        public Usuario(string nome, string email, string telefone, string cpf, string senha, EnTipoUsuario tipoUsuario)
        {
            AddNotifications(
                new Contract<Notification>()
                    .Requires()
                    .IsNotEmpty(telefone, "Telefone", "Telefone não poder ser vazio")
                    .IsNotEmpty(cpf, "CPF", "CPF não poder ser vazio")
                    .IsNotEmpty(nome, "Nome", "Nome não poder ser vazio")
                    .IsEmail(email, "Email", "O formato do email está incorreto")
                    .IsGreaterOrEqualsThan(senha, 7, "Senha", "A senha deve ter pelo menos 8 caracteres")
            );

            if (IsValid)
            {
                Nome = nome;
                Email = email;
                Telefone = telefone;
                CPF = cpf;
                Senha = senha;
                TipoUsuario = tipoUsuario;
            }

        }

        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public string CPF { get; private set; }
        public string Senha { get; private set; }
        public EnTipoUsuario TipoUsuario { get; private set; }


        // Composições
        
        public void AtualizarSenha(string senha)
        {
            AddNotifications(
                new Contract<Notification>()
                    .Requires()
                    .IsGreaterOrEqualsThan(senha, 7, "Senha", "A senha deve ter pelo menos 8 caracteres")
            );

            if (IsValid)
            {
                Senha = senha;
            }
        }

        public void AtualizaUsuario(string nome, string email, string telefone)
        {
            AddNotifications(
                new Contract<Notification>()
                    .Requires()
                    .IsNotEmpty(telefone, "Telefone", "Telefone não poder ser vazio")
                    .IsNotEmpty(nome, "Nome", "Nome não poder ser vazio")
                    .IsEmail(email, "Email", "O formato do email está incorreto")
            );
            
            if (IsValid)
            {
                Nome = nome;
                Email = email;
                Telefone = telefone;
            }
        }

    }

}
