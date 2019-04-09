using GereciadorDePatrimonio.Domain.Marcas.Models;
using GereciadorDePatrimonio.Domain.Patrimonios.Interfaces;
using GereciadorDePatrimonio.Domain.Patrimonios.Models;
using GereciadorDePatrimonio.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GereciadorDePatrimonio.Infrastructure.Data.Repository
{
    public class PatrimonioRepository : IPatrimonioRepository
    {
        private GereciadorDePatrimonioContext _context { get; set; }
        private DbSet<Patrimonio> _patrimonios { get; set; }

        public PatrimonioRepository(GereciadorDePatrimonioContext context)
        {
            _context = context;
            _patrimonios = context.Patrimonios;
        }

        public void AdicionarNovo(Patrimonio usuario)
        {
            _patrimonios.Add(usuario);

            // Remover e usar o unit of work
            _context.SaveChanges();
        }

        public IEnumerable<Patrimonio> ListarTodos()
        {
            return _patrimonios.ToList();
        }

        public void Atualizar(Patrimonio patrimonio)
        {
            _context.Entry(patrimonio).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            var patrimonio = _patrimonios.FirstOrDefault(e => e.Id.Equals(id));

            if (patrimonio == null)
            {
                // Adiciona notification pattern aqui
                return;
            }

            _patrimonios.Remove(patrimonio);
            _context.SaveChanges();
        }
        
        public IEnumerable<Patrimonio> Buscar(Expression<Func<Patrimonio, bool>> expression)
        {
            return _patrimonios.Where(expression).ToList();
        }

        public IEnumerable<Patrimonio> BuscarAsNoTracking(Expression<Func<Patrimonio, bool>> expression)
        {
            return _patrimonios.AsNoTracking().Where(expression).ToList();
        }
    }
}
