using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MapUtils;

namespace Domain
{
    public class ArtPiece
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public Artist Author { get; set; }
        public Category Type { get; set; }
        public Museum Museum { get; set; }
    }
}