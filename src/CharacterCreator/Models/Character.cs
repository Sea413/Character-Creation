using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterCreator.Models
{
        [Table("Characters")]
        public class Character
        {
            [Key]
            public int characterId { get; set; }
            public string name { get; set; }
            public int hairId { get; set; }
            public virtual Hair Hair { get; set; }
            public int skinId { get; set; }
            public virtual Skin Skin { get; set; }
            public int outfitId { get; set; }
            public virtual Outfit Outfit { get; set; }
            public int personalityId { get; set; }
            public virtual Personality Personality { get; set; }
        }
    }

