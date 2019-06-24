using System;
using AutoMapper;
using Domain;
using Dtos;
using MapUtils;
namespace ArtAdvisorBackEnd {
  public class Mapper : Profile {
    public Mapper () {
      //DINAMIC WAY
      CreateMap<Category, CategoryDto> ();
      CreateMap<Artist, ArtistDto> ();
      CreateMap<ArtPiece, ArtPieceDto> ()
        .ForMember (destinationMember => destinationMember.Museum,
          opts => opts.MapFrom (sourceMember => sourceMember.Museum.Id))
        .ForMember (destinationMember => destinationMember.Type,
          opts => opts.MapFrom (sourceMember => sourceMember.Type.Id))
        .ForMember (destinationMember => destinationMember.Author,
          opts => opts.MapFrom (sourceMember => sourceMember.Author.Id));
      CreateMap<ArtAdvisorUser, ArtAdvisorUserDto> ();
      CreateMap<Museum, MuseumDto> ();

      CreateMap<CategoryDto, Category> ();
      CreateMap<ArtistDto, Artist> ();
      CreateMap<ArtPieceDto, ArtPiece> ().
      ForMember (destinationMember => destinationMember.Type,
        opt => opt.MapFrom (src => new ArtPiece { Type = new Category (src.Type) })).
      ForMember (destinationMember => destinationMember.Author,
        opt => opt.MapFrom (src => new ArtPiece { Author = new Artist (src.Author) })).
      ForMember (destinationMember => destinationMember.Museum,
        opt => opt.MapFrom (src => new ArtPiece { Museum = new Museum (src.Museum) }));
      CreateMap<MuseumDto, Museum> ();
      CreateMap<ArtAdvisorUserDto, ArtAdvisorUser> ();
      //TRADITIONAL WAY
      // CreateMap<ArtPiece, ArtPieceDto>(). 
      //     ForMember(x => x.Type, opts => opts.Ignore()).
      //     ForMember(x => x.Author, opts => opts.Ignore());
    }

  }
}