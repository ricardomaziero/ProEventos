using AutoMapper;
using Proeventos.Application.Dtos;
using ProEventos.Application.Dtos;
using ProEventos.Domain;

namespace Proeventos.Application.Helpers
{
    public class ProEventosProfile : Profile
    {
        public ProEventosProfile() 
        {
            CreateMap<Evento, EventoDto>().ReverseMap();
            CreateMap<Lote, LoteDto>().ReverseMap();
            CreateMap<RedeSocial, RedeSocialDto>().ReverseMap();
            CreateMap<Palestrante, PalestranteDto>().ReverseMap();
        }
    }
}