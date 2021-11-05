using Intelitrader.Comum.Enum;
using Intelitrader.Dominio.Entidades;
using Intelitrader.Dominio.Repositorios;
using Intelitrader.Infa.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelitrader.Infa.Data.Repositorios
{
    public class VagaRepositorio : IVagaRepositorio
    {

        private readonly IntelitraderContext _context;

        public VagaRepositorio(IntelitraderContext context)
        {
            _context = context;
        }

        public void Alterar(Vaga vaga)
        {
            _context.Entry(vaga).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        public Vaga BuscarPorID(Guid id)
        {
            return _context.Vaga.FirstOrDefault(x => x.Id == id);
        }

        public Vaga BuscarVagaPorNome(string nome)
        {
            return _context.Vaga.FirstOrDefault(x => x.Nome.ToLower() == nome.ToLower());
        }

        public void Cadastrar(Vaga vaga)
        {
            _context.Vaga.Add(vaga);
            _context.SaveChanges();
        }

        public IEnumerable<Vaga> Listar(EnStatusVaga? ativo = null)
        {
            if (ativo == null)
            {
                return _context.Vaga
                    .AsNoTracking()
                    .Include(v => v.Quantidade)
                    .OrderBy(v => v.DataCriacao);
            }
            else
            {
                return _context.Vaga
                    .AsNoTracking()
                    .Include(v => v.Quantidade)
                    .Where(v =>v.StatusVaga == ativo)
                    .OrderBy(v => v.DataCriacao);
            }
        }
    }
}
