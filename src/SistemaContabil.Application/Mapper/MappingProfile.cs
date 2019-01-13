using AutoMapper;
using SistemaContabil.Application.ViewModels;
using SistemaContabil.Core.Aggregates.Fiscal.Entities;

namespace SistemaContabil.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<NotaFiscalEntity, NotaFiscalViewModel>().ReverseMap();
        }
    }
}
