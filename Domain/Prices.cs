using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Domain
{
    public class Price
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public double total { get; set; }
        public CurrencyType Currency { get; set; }
        public Museum Museum { get; set; }
    }
    public enum CurrencyType
    {
        CRC,
        EUR,
        USD
    }
}