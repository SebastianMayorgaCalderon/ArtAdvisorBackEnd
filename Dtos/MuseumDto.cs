using System;

namespace Dtos
{
    public class MuseumDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public double Rate { get; set; }
    }
}