using System;
using AutoMapper;
using Domain;
using Dtos;
using MapUtils;
namespace ArtAdvisorBackEnd {
  public class Mapper : Profile {
    public Mapper () {
      //DINAMIC WAY
      CreateMap<Category, CategoryDto> ().IgnoreNoMap ();
      CreateMap<Artist, ArtistDto> ().IgnoreNoMap ();
      CreateMap<ArtPiece, ArtPieceDto> ().IgnoreNoMap ();
      CreateMap<ArtAdvisorUser, ArtAdvisorUserDto> ().IgnoreNoMap ();
      CreateMap<Museum, MuseumDto> ().IgnoreNoMap ();

      CreateMap<CategoryDto, Category> ().IgnoreNoMap ();
      CreateMap<ArtistDto, Artist> ().IgnoreNoMap ();
      CreateMap<ArtPieceDto, ArtPiece> ().
      IgnoreNoMap ().
      ForMember (destinationMember => destinationMember.Type,
        opt => opt.MapFrom (src => new ArtPiece { Type = new Category { Id = Guid.Parse (src.Type) } })).
      ForMember (destinationMember => destinationMember.Author,
        opt => opt.MapFrom (src => new ArtPiece { Author = new Artist { Id = Guid.Parse (src.Author) } })).
      ForMember (destinationMember => destinationMember.Museum,
        opt => opt.MapFrom (src => new ArtPiece { Museum = new Museum { Id = Guid.Parse (src.Museum) } }));
      CreateMap<MuseumDto, Museum> ().IgnoreNoMap ();
      CreateMap<ArtAdvisorUserDto, ArtAdvisorUser> ().IgnoreNoMap ();
      //TRADITIONAL WAY
      // CreateMap<ArtPiece, ArtPieceDto>(). 
      //     ForMember(x => x.Type, opts => opts.Ignore()).
      //     ForMember(x => x.Author, opts => opts.Ignore());
    }

  }
}