using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BossRaid;

namespace Items
{
    public class Potions
    {
        public static int potion = 50;
        public static int UsePotion()
        {
            Program.currentHP += potion;

            return potion;
        }


    }

    public class MedKit
    {
        public static int medkit = 60;
        public static int UseMedKit()
        {
            Program.currentHP += medkit;

            return medkit;
        }


    }

    public class MedPotion
    {
        public static int medPotion = 50;
        public static int UseMedPotion()
        {
            Program.currentHP += medPotion;

            return medPotion;
        }


    }

    public class bottleOfWine
    {
        public static int BOF = 10;
        public static int UseBOF()
        {
            Program.currentMP += BOF;

            return BOF;
        }


    }

    public class CleansingPowder
    {
        public static int cleansingpowder = 20;
        public static int Usecleansingpowder()
        {
            Program.currentMP += cleansingpowder;

            return cleansingpowder;
        }


    }

    public class SenzuBean
    {
        public static int senzu = Program.currentHP;
        public static int Usesenzu()
        {
            Program.HP += senzu;

            return senzu;
        }


    }

    public class FeatherPheonix
    {
        public static int featherpheonix = 50;
        public static int Usefeatherpheonix()
        {
            Program.currentHP += featherpheonix;

            return featherpheonix;
        }


    }

    public class enchantingJuice
    {
        public static int enchantingjuice = 75;
        public static int UseenchantingJ()
        {
            Program.currentMP += enchantingjuice;

            return enchantingjuice;
        }


    }

    public class Turnaquette
    {
        public static int turnaquettes = 75;
        public static int Useturnaquette()
        {
            Program.currentHP += turnaquettes;

            return turnaquettes;
        }


    }

    public class LiquorBottle
    {
        public static int liquor = 50;
        public static int Useliquor()
        {
            Program.currentMP += liquor;

            return liquor;
        }


    }

    public class Soda
    {
        public static int soda = 50;
        public static int Usesoda()
        {
            Program.HP += soda;

            return soda;
        }


    }

    public class PackOfMagic
    {
        public static int packofmagic = 50;
        public static int Usepackofmagic()
        {
            Program.HP += packofmagic;

            return packofmagic;
        }


    }

    public class RegeneratingWater
    {
        public static int regeneratingwater = 50;
        public static int Useregeneratingwater()
        {
            Program.HP += regeneratingwater;

            return regeneratingwater;
        }


    }

    public class SmoothingLotion
    {
        
            public static int smoothinglotion = 50;
            public static int Usesenzu()
            {
                Program.HP += smoothinglotion;

                return smoothinglotion;
            }


        
    }

    public class HotBandage
    {
        public static int bandage = 50;
        public static int Usebandage()
        {
            Program.HP += bandage;

            return bandage;
        }


    }

    public class LargeKit
    {
        public static int largekit = 50;
        public static int Uselargekit()
        {
            Program.HP += largekit;

            return largekit;
        }


    }

    public class LargePotion
    {
        public static int LPotion = 50;
        public static int UseLPotion()
        {
            Program.HP += LPotion;

            return LPotion;
        }


    }
}
