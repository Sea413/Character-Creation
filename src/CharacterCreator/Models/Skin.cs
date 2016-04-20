using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterCreator.Models
{
    [Table("Skins")]
    public class Skin
    {
        public Skin()
        {
            this.Characters = new HashSet<Character>();
        }
        [Key]
        public int skinId { get; set; }
        public string name { get; set; }
        public virtual ICollection<Character> Characters { get; set; }

    }
}