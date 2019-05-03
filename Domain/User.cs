using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class ArtAdvisorUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Email { get; set; }
        public Role UserRole { get; set; }
        //public ICollection<UserRelationship> RelationShips { get; set; }

    }
    public enum Role
    {
        MUSEUM_ADMIN,
        APP_USER,
        ART_ADVISOR_ADMIN
    }
}