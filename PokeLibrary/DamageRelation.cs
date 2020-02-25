using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeLibrary
{
    public class DamageRelation
    {
        public List<PokemonType> No_Damage_To { get; set; }
        public List<PokemonType> Half_Damage_To { get; set; }
        public List<PokemonType> Double_Damage_To { get; set; }
        public List<PokemonType> No_Damage_From { get; set; }
        public List<PokemonType> Half_Damage_From { get; set; }
        public List<PokemonType> Double_Damage_From { get; set; }
    }
}
