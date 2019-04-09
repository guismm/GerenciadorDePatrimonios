using GereciadorDePatrimonio.Domain.Marcas.Interfaces;
using GereciadorDePatrimonio.Domain.Marcas.Models;
using GereciadorDePatrimonio.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GereciadorDePatrimonio.Infrastructure.Data.Repository
{
    public class MarcasRepository : IMarcaRepository
    {
        private GereciadorDePatrimonioContext _context { get; set; }
        private DbSet<Marca> _marcas { get; set; }

        public MarcasRepository(GereciadorDePatrimonioContext context)
        {
            _context = context;
            _marcas = context.Marcas;
        }

        public void AdicionarNovo(Marca usuario)
        {
            _marcas.Add(usuario);

            // Remover e usar o unit of work
            _context.SaveChanges();
        }

        public IEnumerable<Marca> ListarTodos()
        {
            return _marcas.ToList();
        }

        public void Atualizar(Marca usuario)
        {
            _context.Entry(usuario).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            var usuario = _marcas.FirstOrDefault(e => e.Id == id);

            if (usuario == null)
            {
                // Adiciona notification pattern aqui
                return;
            }

            _marcas.Remove(usuario);
            _context.SaveChanges();
        }

        public IEnumerable<Marca> Buscar(Expression<Func<Marca, bool>> expression)
        {
            return _marcas.Where(expression).ToList();
        }
    }
}
