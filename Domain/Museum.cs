using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain {
  public class Museum {
    public Museum (Guid id) {
      this.Id = id;
      this.ImgUrl = null;
      this.Lat = null;
      this.Lng = null;
      this.MuseumAdmin = null;
      this.Name = null;
      this.Prices = null;
      this.Rate = null;
    }

    [Key]
    [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public double? Lat { get; set; }
    public double? Lng { get; set; }
    public string Description { get; set; }
    public string ImgUrl { get; set; }
    public double? Rate { get; set; }
    public ArtAdvisorUser MuseumAdmin { get; set; }
    public virtual ICollection<Price> Prices { get; set; }
  }
}