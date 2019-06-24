using System;
using MapUtils;

namespace Dtos
{
    public class ArtPieceDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public Guid Museum { get;set;}
        public Guid Author { get; set; }
        public Guid Type { get; set; }
    }
}