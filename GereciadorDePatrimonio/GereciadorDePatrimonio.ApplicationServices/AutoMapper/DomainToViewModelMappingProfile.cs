using AutoMapper;
using GereciadorDePatrimonio.ApplicationServices.ViewModels;
using GereciadorDePatrimonio.Domain.Marcas.Models;
using GereciadorDePatrimonio.Domain.Patrimonios.Models;

namespace GereciadorDePatrimonio.ApplicationServices.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Patrimonio, PatrimonioViewModel>();
            CreateMap<Marca, MarcaViewModel>();
        }
    }
}
