using AutoMapper;
using CursoArquitectura.Net.Core.Entities;
using CursoArquitectura.Net.DTOs;

namespace CursoArquitectura.Net.Mapper
{
    public class ProductMapperProfiles : Profile
    {
        public ProductMapperProfiles()
        {
            CreateMap<ProductDTO, Product>().ReverseMap();
        }
    }
}
