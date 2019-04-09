using AutoMapper;

namespace GereciadorDePatrimonio.ApplicationServices.AutoMapper
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration Register()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DomainToViewModelMappingProfile());
                cfg.AddProfile(new ViewModelToDomainMappingProfile());
            });
        }
    }
}
