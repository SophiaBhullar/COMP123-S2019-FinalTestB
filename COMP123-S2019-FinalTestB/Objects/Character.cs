﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * STUDENT NAME: SOPHIA BHULLAR
 * STUDENT ID: 301048344
 * DESCRIPTION: This is the Character class used in character creation.
 *              This is also the Data container for the application.
 */



namespace COMP123_S2019_FinalTestB.Objects
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
        public CharacterClass Class { get; set; }
        public int Level { get; set; }

        //Equipment
        public List<Item> Inventory;

        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Constructor
        public Character(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            this.Inventory = new List<Item>();
            
    }
    }
}
