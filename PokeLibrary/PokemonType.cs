using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeLibrary
{
    public enum PokeTypes { normal, water, electric, fighting, ground, psychic, rock, dark, steel, fire, grass, ice, poison, flying, bug, ghost, dragon, fairy }
    
    public class PokemonType
    {
        public PokeTypes Name { get; set; }
        public DamageRelation Damage_Relations { get; set; }
    }
}
