using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterCreator.Models
{
    public class CharacterCreatorContext : DbContext
    {
        public virtual DbSet<Character> Characters { get; set; }
        public virtual DbSet<Hair> Hairs { get; set; }
        public virtual DbSet<Outfit> Outfits { get; set; }
        public virtual DbSet<Personality> Personalities { get; set; }
        public virtual DbSet<Skin> Skins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SimsFinity;integrated security = True");
        }
    }
}
