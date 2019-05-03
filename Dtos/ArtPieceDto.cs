using System;
using MapUtils;

namespace Dtos
{
    public class ArtPieceDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        
        [NoMap]
        public string Museum { get;set;}
        [NoMap]
        public string Author { get; set; }
        [NoMap]
        public string Type { get; set; }
    }
}