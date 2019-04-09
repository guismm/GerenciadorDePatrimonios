using GereciadorDePatrimonio.Domain.Patrimonios.Models;
using GereciadorDePatrimonio.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace GereciadorDePatrimonio.Domain.Patrimonios.Interfaces
{
    public interface IPatrimonioAppService : IGenericService<Patrimonio>
    {
        IEnumerable<Patrimonio> BuscarPorMarca(Guid marcaId);

    }
}
