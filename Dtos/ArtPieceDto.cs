using System;

namespace Dtos
{
    public class ArtPieceDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ArtistDto Author { get; set; }
        public CategoryDto Type { get; set; }
        public string ImgUrl { get; set; }
    }
}