using AutoMapper;
using Domain;
using Dtos;
namespace ArtAdvisorBackEnd
{
    public class Mapper : Profile
    {
        public Mapper ()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<Artist, ArtistDto>();
            CreateMap<ArtPiece, ArtPieceDto>();
        }
    }
}