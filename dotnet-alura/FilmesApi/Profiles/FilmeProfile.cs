using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;

namespace FilmesApi.Profiles;

public class FilmeProfile : Profile
{
    public FilmeProfile()
    {
        CreateMap<CreateFilmeDto, Filme>();
        CreateMap<UpdatefilmeDto, Filme>();
        CreateMap<Filme, UpdatefilmeDto>();
        CreateMap<Filme, ReadFilmeDto>();
    }
}