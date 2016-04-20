using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterCreator.Models
{
    [Table("Personalities")]
    public class Personality
    {
        [Key]
        public int personalityId { get; set; }
        public string name { get; set; }
    }
}