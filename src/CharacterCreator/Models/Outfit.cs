using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterCreator.Models
{
    [Table("Outfits")]
    public class Outfit
    {
        [Key]
        public int outfitId { get; set; }
        public string name { get; set; }
    }
}