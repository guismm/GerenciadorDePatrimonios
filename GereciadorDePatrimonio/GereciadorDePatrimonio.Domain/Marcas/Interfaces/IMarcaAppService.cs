using GereciadorDePatrimonio.Domain.Marcas.Models;
using GereciadorDePatrimonio.Domain.Patrimonios.Models;
using GereciadorDePatrimonio.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace GereciadorDePatrimonio.Domain.Marcas.Interfaces
{
    public interface IMarcaAppService : IGenericService<Marca>
    {
        IEnumerable<Patrimonio> BuscarPatrimoniosPorMarca(Guid id);

        void Deletar(Guid id);

    }
}
