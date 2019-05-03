using System;

namespace Dtos
{
    public class ArtAdvisorUserDto
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public int UserRole { get; set; }
    }
}