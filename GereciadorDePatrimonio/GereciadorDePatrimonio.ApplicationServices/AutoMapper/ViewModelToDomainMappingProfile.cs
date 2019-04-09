using AutoMapper;
using GereciadorDePatrimonio.ApplicationServices.ViewModels;
using GereciadorDePatrimonio.Domain.Marcas.Models;
using GereciadorDePatrimonio.Domain.Patrimonios.Models;

namespace GereciadorDePatrimonio.ApplicationServices.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<PatrimonioViewModel, Patrimonio>()
                .ConstructUsing(c => new Patrimonio(c.Id, c.Tombo, c.MarcaId, c.Nome, c.Descricao));

            CreateMap<MarcaViewModel, Marca>()
                .ConstructUsing(c => new Marca(c.Id,c.Nome));
        }
    }
}
