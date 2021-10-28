using Intelitrader.Dominio.Entidades;
using Intelitrader.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelitrader.Testes.Repositorios
{
    public class FakeUsuarioRepositorio : IUsuarioRepositorio
    {
        public void Adicionar(Usuario usuario)
        {
            
        }

        public void Alterar(Usuario usuario)
        {
            
        }

        public Usuario BuscarPorEmail(string email)
        {
            return null;
        }

        public Usuario BuscarPorId(Guid id)
        {
            return new Usuario(
                "Lameck", 
                "lameck.v.barbosa@gmail.com", 
                "08866677713", 
                "11993785259", 
                "123456789", 
                Intelitrader.Comum.Enum.EnTipoUsuario.Funcionario);
        }

        public ICollection<Usuario> Listar(bool? ativo = null)
        {
            return new List<Usuario>()
            {
                new Usuario(
                    "Lameck",
                    "lameck.v.barbosa@gmail.com",
                    "08866677713",
                    "11993785259",
                    "123456789",
                    Intelitrader.Comum.Enum.EnTipoUsuario.Funcionario),
                new Usuario(
                    "Danilo",
                    "danilo@gmail.com",
                    "08866677715",
                    "11993785255",
                    "123456789",
                    Intelitrader.Comum.Enum.EnTipoUsuario.Funcionario)
            };
        }
    }
}
