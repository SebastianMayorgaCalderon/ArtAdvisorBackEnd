using System;

namespace Dtos
{
    public class ArtADvisorUserDto
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public Role UserRole { get; set; }
    }
    public enum Role
    {
        MUSEUM_ADMIN,
        APP_USER,
        ART_ADVISOR_ADMIN
    }
}