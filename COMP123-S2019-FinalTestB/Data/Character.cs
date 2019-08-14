using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2019_FinalTestB.Data
{
    class Character
    {
        //Character Abilities
        public string Strength { get; set; }
        public string Dexterity { get; set; }
        public string Constitution { get; set; }
        public string Intelligence { get; set; }
        public string Wisdom { get; set; }
        public string Charisma { get; set; }

        //Secondary Abilities
        public int ArmourClass { get; set; }
        public int HitPoints { get; set; }

        //Character Class
        public string CharacterClass { get; set; }
        public int Level { get; set; }

    }
}
