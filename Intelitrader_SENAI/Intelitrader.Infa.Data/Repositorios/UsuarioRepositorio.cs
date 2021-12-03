using Intelitrader.Dominio.Entidades;
using Intelitrader.Dominio.Repositorios;
using Intelitrader.Infa.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelitrader.Infa.Data.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        // injeção de dependência 
        private readonly IntelitraderContext _context;

        public UsuarioRepositorio(IntelitraderContext context)
        {
            _context = context;
        }

        public void Adicionar(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void Alterar(Usuario usuario)
        {
            _context.Entry(usuario).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        public Usuario BuscarPorEmail(string email)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Email.ToLower() == email.ToLower());
        }

        public Usuario BuscarPorId(Guid id)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Id == id);
        }

        //public Usuario Delete(Guid id)
        //{
        //    // Remove o tipo de usuário que foi buscado
        //    _context.Usuarios.Remove(BuscarPorId(id));

        //    // Salva as alterações
        //    _context.SaveChanges();
        //}

        public ICollection<Usuario> Listar(bool? ativo = null)
        {
            return _context.Usuarios.ToList();
        }
    }
}
