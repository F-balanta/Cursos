using API.DTOs;
using AutoMapper;
using Core.Entities;

namespace API.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Producto, ProductoDto>().ReverseMap();
            CreateMap<Categoria, CategoriaDto>().ReverseMap();
            CreateMap<Marca, MarcaDto>().ReverseMap();
            


            CreateMap<Producto, ProductoListDto>()
                .ForMember(x => x.Marca, y => y.MapFrom(z => z.Marca!.Nombre))
                .ForMember(x => x.Categoria, y => y.MapFrom(z => z.Categoria!.Nombre))
                .ReverseMap()
                .ForMember(x => x.Categoria, y => y.Ignore())
                .ForMember(x => x.Marca, y => y.Ignore());

            CreateMap<Producto, ProductoAddOrUpdateDto>()
                .ReverseMap()
                .ForMember(x => x.Categoria, y => y.Ignore())
                .ForMember(x => x.Marca, y => y.Ignore());
        }
    }
}
