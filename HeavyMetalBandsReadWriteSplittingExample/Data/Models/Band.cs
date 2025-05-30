﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeavyMetalBandsReadWriteSplittingExample.Data.Models
{
    [Table("bands")]
    public class Band
    {
        [Key]
        public int id { get; set; }
        public string band_name { get; set; }
        public int year_created { get; set; }
    }
}
