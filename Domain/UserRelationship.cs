using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class UserRelationship
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public ArtAdvisorUser UserA { get; set; }
        public ArtAdvisorUser UserB { get; set; }
        public RelationshipType type { get; set; }
    }
    public enum RelationshipType
    {
        BLOCKED,
        WAITING_FOR_RESPONCE,
        FOLLOWING
    }
}