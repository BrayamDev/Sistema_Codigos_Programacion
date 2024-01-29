using AutoMapper;
using SistemaCodigoProgramacionBack.DTOs;
using SistemaCodigoProgramacionBack.Migrations;
using SistemaCodigoProgramacionBack.Models;

namespace SistemaCodigoProgramacionBack.Utilities
{
    public class AutoMapperProfile : Profile
    {
        /*Se crea el constructor para interconectar el DTO con el modelo base*/
        public AutoMapperProfile()
        {
            /*Con la linea CreateMap interconectamos (Codigo con CodigoDTO) 
             * y con la propiedad reverseMap interconectamos(CodigoDTO con Codigo)*/
            CreateMap<Codigo, CodigoDTO>().ReverseMap();/*Agregar la propiedad al startup*/
            CreateMap<CodigoCreationDTO, Codigo>();
        }

    }
}
