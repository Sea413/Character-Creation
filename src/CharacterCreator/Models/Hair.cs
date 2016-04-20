using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterCreator.Models
{
    [Table("Hairs")]
    public class Hair
    {
        public Hair()
        {
            this.Characters = new HashSet<Character>();
        }
        [Key]
        public int hairId { get; set; }
        public string name { get; set; }
        public virtual ICollection<Character> Characters { get; set; }
    }
}
