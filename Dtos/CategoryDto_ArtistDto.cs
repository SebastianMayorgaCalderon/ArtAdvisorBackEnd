using System;

namespace Dtos
{
    public class CategoryDto
    {
        public Guid Id { get; set; }
        public string CategoryName { get; set; }
    }
    public class ArtistDto
    {
        public Guid Id { get; set; }
        public string ArtistName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Description { get; set; }
        public string ImsgUrl { get; set; }
    }
}