using System;
using System.Collections.Generic;

namespace GereciadorDePatrimonio.Domain.Interfaces.Services
{
    public interface IGenericService<TEntity> where TEntity : class
    {
        void AdicionarNovo(ref TEntity usuario);

        IEnumerable<TEntity> ListarTodos();

        void Atualizar(TEntity usuario);

        TEntity BuscarPorId(Guid id);

        void Deletar(Guid tombo);

    }
}
