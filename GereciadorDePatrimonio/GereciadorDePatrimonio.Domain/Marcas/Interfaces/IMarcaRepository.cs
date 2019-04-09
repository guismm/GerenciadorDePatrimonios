using GereciadorDePatrimonio.Domain.Marcas.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GereciadorDePatrimonio.Domain.Marcas.Interfaces
{
    public interface IMarcaRepository
    {
        void AdicionarNovo(Marca marca);

        IEnumerable<Marca> ListarTodos();

        void Atualizar(Marca marca);

        void Deletar(Guid id);

        IEnumerable<Marca> Buscar(Expression<Func<Marca, bool>> expression);
    }
}
