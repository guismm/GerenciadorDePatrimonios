using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using GereciadorDePatrimonio.Domain.Patrimonios.Models;

namespace GereciadorDePatrimonio.Domain.Patrimonios.Interfaces
{
    public interface IPatrimonioRepository
    {
        void AdicionarNovo(Patrimonio usuario);

        IEnumerable<Patrimonio> ListarTodos();

        void Atualizar(Patrimonio usuario);

        void Deletar(Guid tombo);

        IEnumerable<Patrimonio> Buscar(Expression<Func<Patrimonio, bool>> expression);

        IEnumerable<Patrimonio> BuscarAsNoTracking(Expression<Func<Patrimonio, bool>> expression);
    }
}
