using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Domain {
  public class Category {
    public Category (Guid id) {
      this.Id = id;
      this.CategoryName = null;
    }

    [Key]
    [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public string CategoryName { get; set; }

  }
  public class Artist {
    public Artist (Guid id) {
      this.Id = Id;
      this.ArtistName = null;
      this.BirthDate = null;
      this.Description = null;
      this.ImsgUrl = null;
    }

    [Key]
    [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public string ArtistName { get; set; }
    public DateTime? BirthDate { get; set; }
    public string Description { get; set; }
    public string ImsgUrl { get; set; }
  }
}