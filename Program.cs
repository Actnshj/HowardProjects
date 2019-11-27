using System;
using Bosses;
using Weapons;
using System.Collections.Generic;
using Items;
using Armour;
using FSPG;
using Levels;
using BossUnlocking;
using Minions;
namespace BossRaid
{
    public class Program
    {
        GameWeapons s1 = new GameWeapons();
        public static bool playerMinionTurn=false;
        public static bool playerTurn;
        public static bool oppBurn = false;
        public static bool oppPoison = false;
        static int turnCount = 0;
        public static int HP = 0;
        public static int currentHP = 0;
        public static int MaxMP = 0;
        public static int currentMP = 0;
        public static int MPATK = 0;
        public static int Atk = 0;
        public static int Def = 0;
        public static int currentdef = 0;
        public static string username = "";
        public static int Level = 1;
        public static int Exp = 0;
        public static int Gold = 200000;
        public static bool swordsmanPicked = false;
        public static bool MagePicked = false;
        public static bool MonControllerPicked = false;
        public static bool GunnerPicked = false;
        public static bool TankerPicked = false;
        public static bool EnemyTurn = false;
        static List<int> equip = new List<int>();
        static List<int> items = new List<int>();
        static List<int> armour = new List<int>();
        static List<string> MPlist = new List<string>();
        static List<babyEyeman> babyeye = new List<babyEyeman>();
        public static bool Reflex = false;
        public bool FireNull = false;
        public bool PoisonNull = false;
        public bool FreezeNull = false;
        public static bool HurtDamage = false;

        public enum FighterClass
        {
            none,
            Swordsman,
            Magician,
            MonController,
            Gunner,
            Tanker,

        }
        public enum PlayersTurn
        {
            
            Attack=1,
            MPAttack,
            Inventory,
            EndTurn,
        }
        

        public enum PidgHeadStates
        {
          
            Peck =1,
            HeadBash,
            SaborSword,
            TornadoWhirlwind,
        }


        public enum MenuSelect
        {
            none,
            Tower,
            stats,
            shop,
            diffulity,
            endgame,


        }
        public enum BattleMenu
        {
            none,
            Attack,
            Stats,
            Item,
            EndTurn,
        }

       static void Main(string[] args)
        {
            bool menutog = true;
            Random rand1 = new Random();


            Console.Title = "Boss Raid!";
            Console.WriteLine("Welcome to the frontlines soldier!");
            Console.WriteLine("There are a bunch of super powered Monsters and Mutants that are attacking us!");
            Console.WriteLine("Press Enter to continue..");
            Console.ReadLine();
            Console.WriteLine("What is your name?");
          username = Console.ReadLine();
            Console.WriteLine("Nice to meet you " + username);
            int WarriorValueClass = 0;
            do
            {

                Console.WriteLine("Now, what class are you?");
                Console.WriteLine("1) Swordsman");
                Console.WriteLine("2) Magician");
                Console.WriteLine("3) Monster Controller");
                Console.WriteLine("4) Gunner");
                Console.WriteLine("5) Tanker");
                WarriorValueClass = Utility.ReadInt();

                FighterClass FClass = (FighterClass)(WarriorValueClass);
                
                switch (FClass)
                {
                    case (FighterClass.Swordsman):
                        bool classPicked = false;
                      
                        int pickClass1 = 0;
                        do
                        {
                           Console.WriteLine("Swordsman:");
                        Console.WriteLine("A person who is a master of the sword who is reasonable in attack and strength.");
                        Console.Write("Are you sure you want the swordsman? Type ('1')Yes or ('2')No.");
                           pickClass1 = Utility.ReadInt();
                        } while(!Utility.IsReadGood()) ;

                            if (pickClass1 == 1)
                        {
                            int chooseClass1 = 0;
                            do
                            {
                                HP = rand1.Next(80, 150);
                                MaxMP = rand1.Next(1, 20);
                                MPATK = rand1.Next(5, 20);
                                Atk = rand1.Next(10, 20);                          
                                Console.Clear();
                                Console.WriteLine("Do you want these stats '1' for yes? or '2' for no? ");
                                if (HP > 130)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                }

                                else if (HP < 90)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                }

                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                Console.WriteLine("HP : " + HP);
                                if (MaxMP > 15)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                }

                                else if (MaxMP < 8)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                }


                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                Console.WriteLine("MP : " + MaxMP);
                                if (Atk > 15)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                }

                                else if (Atk < 13)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                }


                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                Console.WriteLine("Atk : " + Atk);
                                if (MPATK > 15)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                }

                                else if (MPATK < 8)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                }


                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                chooseClass1 = Utility.ReadInt();
                            } while (!Utility.IsReadGood() || chooseClass1 > 2 || chooseClass1<1);  
                                if (chooseClass1 == 1)
                                {
                                Console.ResetColor();
                                menutog = false;
                                swordsmanPicked = true;
                                //equip.Add(5);
                                    Menu();
                                    break;
                                }

                                else
                                {
                                Console.ResetColor();
                                classPicked = false;
                                }
                          

                               


                            }

                           else
                            {
                            Console.ResetColor();
                            classPicked = false;
                            }
                         
                       
                      
                        break;

                    case (FighterClass.Magician):
                        int pickClass2 = 0;
                        bool classPicked5 = false;
                        do
                        {
                            Console.Write("Magician");
                            Console.WriteLine("A magical alchemist, white mage, dark sorcerer... what ever comes to mind.");
                            Console.Write("Are you sure you want the magician? Type ('1')Yes or ('2')No.");
                        } while (!Utility.IsReadGood());
                        

                        pickClass2 = Utility.ReadInt();
                        do
                        {
                          
                            if (pickClass2 == 1)
                            {
                                menutog = false;
                                int chooseClass3 = 0;

                                do {

                                    Console.Clear();
                                    HP = rand1.Next(70,110);
                                    MaxMP = rand1.Next(10, 40);
                                    MPATK = rand1.Next(5, 30);
                                    Atk = rand1.Next(5, 12);
                                    Console.WriteLine("Do you want these stats '1' for yes? or '2' for no?  ");
                                    if (HP > 90)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                    }

                                    else if (HP < 79)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                    }

                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                    }
                                    Console.WriteLine("HP : " + HP);
                                    if (MaxMP > 29)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                    }

                                    else if (MaxMP < 15)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                    }


                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                    }
                                    Console.WriteLine("MP : " + MaxMP);
                                    if (Atk > 9)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                    }

                                    else if (Atk <= 7)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                    }


                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                    }
                                    Console.WriteLine("Atk : " + Atk);
                                    if (MPATK > 22)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                    }

                                    else if (MPATK < 12)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                    }


                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                    }                                   
                                    chooseClass3 = Utility.ReadInt();
                                } while (!Utility.IsReadGood());


                               
                                if (chooseClass3 == 1)
                                {
                                    Console.ResetColor();
                                    menutog = false;
                                    MagePicked = true;
                                    //equip.Add(5);
                                    Menu();
                                    break;
                                }

                                else
                                {
                                    Console.ResetColor();
                                    goto case FighterClass.Magician;
                                    classPicked5 = false;
                                }

                            }


                            else
                            {
                                Console.ResetColor();
                               
                            }


                        } while (!Utility.IsReadGood()); 
                        
                        break;

                    case (FighterClass.MonController):
                        bool classPicked2 = false;
                        int pickClass3 = 0;
                        do
                        {
                        Console.Write("Monster Controller");
                        Console.WriteLine("The Taker of all minions. Turn your bosses enemies against him ;p.");
                        Console.Write("Are you sure you want the Monster Controller? Type ('1')Yes or ('2')No.");
                        pickClass3 = Utility.ReadInt();
                        } while (!Utility.IsReadGood());
                       
                        do
                        {
                            if (pickClass3 == 1)
                            {
                                menutog = false;
                                int chooseClass4 = 0;
                                do
                                {
                                    Console.Clear();
                                    HP = rand1.Next(70, 110);
                                    MaxMP = rand1.Next(4, 35);
                                    Atk = rand1.Next(5, 15);
                                    MPATK = rand1.Next(4, 15);                               
                                    Console.WriteLine("Do you want these stats '1' for yes? or '2' for no?  ");
                                    if (HP > 120)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                    }

                                    else if (HP < 85)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                    }

                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                    }
                                    Console.WriteLine("HP : " + HP);
                                    if (MaxMP > 28)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                    }

                                    else if (MaxMP < 10)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                    }


                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                    }
                                    Console.WriteLine("MP : " + MaxMP);
                                    if (Atk > 10)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                    }

                                    else if (Atk <=6)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                    }


                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                    }
                                    Console.WriteLine("Atk : " + Atk);
                                    if (MPATK > 30)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                    }

                                    else if (MPATK < 20)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                    }


                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                    }
                                                               
                                    chooseClass4 = Utility.ReadInt();
                                } while (!Utility.IsReadGood());
                               
                                
                                if (chooseClass4 == 1)
                                {
                                    Console.ResetColor();
                                    menutog = false;
                                    MonControllerPicked = true;
                                    equip.Add(5);
                                    Menu();
                                    break;
                                }

                                else
                                {
                                    Console.ResetColor();
                                    classPicked2 = false;
                                }

                            }

                            if (pickClass3 == 2)
                            {
                                Console.ResetColor();
                                classPicked2 = false;

                            }

                            else
                            {
                                Console.ResetColor();
                                goto case FighterClass.MonController;
                            }
                            
                        } while (classPicked2 == false);
                       break;


                    case (FighterClass.Gunner):
                        bool classPicked3 = false;
                        int pickClass4 = 0;
                        do
                        {
                        Console.Write("Gunner");
                        Console.WriteLine("A modern soldier than can do mutiple damage. Bullets add up!.");
                        Console.Write("Are you sure you want the Gunner? Type ('1')Yes or ('2')No.");
                        pickClass4 = Utility.ReadInt();
                        } while (!Utility.IsReadGood());

                        if (pickClass4 == 1)
                        {
                            int pickClass6 = 0;
                        menutog = false;
                         do
                         { 
                                Console.Clear();
                                HP = rand1.Next(70, 100);
                                MaxMP = rand1.Next(1, 15);
                                Atk = rand1.Next(5, 20);
                                MPATK = rand1.Next(1, 10);
                                Console.WriteLine("Do you want these stats '1' for yes? or '2' for no?  ");
                                if (HP > 90)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                }

                                else if (HP < 79)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                }

                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                Console.WriteLine("HP : " + HP);
                                if (MaxMP > 10)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                }

                                else if (MaxMP < 7)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                }


                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                Console.WriteLine("MP : " + MaxMP);
                                if (Atk > 14)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                }

                                else if (Atk < 7)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                }


                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                Console.WriteLine("Atk : " + Atk);
                                if (MPATK > 8)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                }

                                else if (MPATK < 4)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                }


                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                pickClass6 = Utility.ReadInt();
                        } while (!Utility.IsReadGood());
                            
                            if (pickClass6 == 1)
                            {
                                Console.ResetColor();
                                GunnerPicked = true;
                                    menutog = false;
                                equip.Add(5);
                                Menu();
                                                                 
                            
                            }

                           

                            else
                            {
                                Console.ResetColor();
                                goto case FighterClass.Gunner;
                            }
                           

                        }

                        else
                        {
                            Console.ResetColor();
                            classPicked3 = false;
                        }
                      
                       break;
                      


                    case (FighterClass.Tanker):
                        bool classPicked4 = false;
                        int pickClass5 = 0;
                        
                        do
                        {
                            Console.Write("Tanker");
                            Console.WriteLine("An Heavy Damage machine weapone and vehicle specialist can also heal robotic minions.");
                            Console.Write("Are you sure you want the Tanker? Type ('1')Yes or ('2')No.");
                            pickClass5 = Utility.ReadInt();
                        } while (!Utility.IsReadGood());
                       
                           
                            if (pickClass5 == 1)
                            {
                            int chooseClass = 0;
                            do
                            {
                                Console.Clear();
                                HP = rand1.Next(65, 200);
                                MaxMP = rand1.Next(1, 15);
                                Atk = rand1.Next(5, 30);
                                MPATK = rand1.Next(1, 55);
                                Console.WriteLine("Do you want these stats '1' for yes? or '2' for no? ");
                                if (HP > 120)
                                {
                                     Console.ForegroundColor =ConsoleColor.Green;
                                }

                                else if (HP < 85)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                }

                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                Console.WriteLine("HP : " + HP);
                                if (MaxMP > 10)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                }

                                else if (MaxMP < 5)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                }


                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                Console.WriteLine("MP : " + MaxMP);
                                if (Atk > 19)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                }

                                else if (Atk < 9)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                }


                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                Console.WriteLine("Atk : " + Atk);
                                if (MPATK > 30)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                }

                                else if (MPATK < 20)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                }


                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                chooseClass = Utility.ReadInt();
                            } while (!Utility.IsReadGood());
                                menutog = false;
                               
                                if(chooseClass == 1)
                                {
                                Console.ResetColor();
                                TankerPicked = true;
                                    menutog = false;
                                equip.Add(5);
                                Menu();
                                    
                                }

                                else
                                {
                                Console.ResetColor();
                                goto case FighterClass.Tanker;

                                }

                            }

                           

                            else
                            {

                           goto case FighterClass.Tanker;

                            }
                       
                        break;



                    default:

                        Console.WriteLine("1) Swordsman");
                        Console.WriteLine("2) Magician");
                        Console.WriteLine("3) Monster Controller");
                        Console.WriteLine("4) Gunner");
                        Console.WriteLine("5) Tanker");
                        int redo = Convert.ToInt32(Console.ReadLine());


                


                        break;




                }
            } while (menutog == true);

      
           



        }
        public static void MPAttack(ref int oppHealth)
        {
            
         

            foreach (string MP in MPlist)
            {
                
                Console.WriteLine(MP);
            }

            if (Shop.BattleWand >= 1 && MPlist.Contains("4) EarthQuake: " + Battlewand.EarthquakeCost))
            {
                Battlewand.SpellInput(ref oppHealth);
                EnemyTurn = true;
                playerTurn = false;
            }

            else if(Shop.BookofBeginners >= 1 && MPlist.Contains("2) Water: " + BookofBeginners.waterCost))
            {
                BookofBeginners.SpellInput(ref oppHealth);
                EnemyTurn = true;
                playerTurn = false;
            }

            else if (Shop.BabyFlute >= 1 && MPlist.Contains("1) Baby Eyeman: " + BabyFlute.babyeyemancost))
            {
                BabyFlute.SpellInput(ref oppHealth);
                EnemyTurn = true;
                playerTurn = false;
            }

            else if(Shop.Mfour >= 1 && MPlist.Contains("1) Explosive Shot: " + MFour.roundDmg))
            {
                MFour.SpellInput(ref oppHealth);
                EnemyTurn = true;
                playerTurn = false;
            }

            else if (Shop.SniperRifle >= 1 && MPlist.Contains("1) Anti-Tank: " + SniperRifle.antitank))
            {
                SniperRifle.SpellInput(ref oppHealth);
                EnemyTurn = true;
                playerTurn = false;
            }

            else if (Shop.grenades >= 1 && MPlist.Contains("1) Multi-Grenades: " + Grenades.multigrenade))
            {
                Grenades.SpellInput(ref oppHealth);
                EnemyTurn = true;
                playerTurn = false;
            }

            else if (Shop.claymores >= 1 && MPlist.Contains("1) Claymores 2x : " + Claymores.claymore2x))
            {
                Claymores.SpellInput(ref oppHealth);
                EnemyTurn = true;
                playerTurn = false;
            }

            else if (Shop.IceBringer >=1 && MPlist.Contains("1) IceSlash: " + IceBringer.IceSlashCost))
            {
                IceBringer.SpellInput(ref oppHealth);
                EnemyTurn = true;
                playerTurn = false;
            }

            else if (Shop.spellbinder>=1 && MPlist.Contains("3) Half Damage: " + SpellBinder.halfDmgcost))
            {
                SpellBinder.SpellInput(ref oppHealth);
                EnemyTurn = true;
                playerTurn = false;
            }

            else if (Shop.fairyMace >= 1 && MPlist.Contains("1) Fairy Dust: " + FairyMace.FairyDustCost))
            {
                FairyMace.SpellInput(ref oppHealth);
                EnemyTurn = true;
                playerTurn = false;
            }

            else if (Shop.WaterWand >= 1 && MPlist.Contains("1) WaterStream: " + Waterwand.waterstreamCost))
            {
                Waterwand.SpellInput(ref oppHealth);
                EnemyTurn = true;
                playerTurn = false;
            }

            else if (Shop.airWhisperer >= 1 && MPlist.Contains("1) AirSlash: " + AirWhisperer.airSlashCost))
            {
                AirWhisperer.SpellInput(ref oppHealth);
                EnemyTurn = true;
                playerTurn = false;
            }

            else if (Shop.EveningStar >= 1 && MPlist.Contains("1) Sparkle Blast: " + EveningStar.SparkleBlastCost))
            {
                EveningStar.SpellInput(ref oppHealth);
                EnemyTurn = true;
                playerTurn = false;
            }

            else if (Shop.Twilightlongrifle >= 1 && MPlist.Contains("1) Star Blaster: " + TwilightLongRifle.starblasterCost))
            {
                TwilightLongRifle.SpellInput(ref oppHealth);
                EnemyTurn = true;
                playerTurn = false;
            }


            else if (Shop.GrenadeLauncher >= 1 && MPlist.Contains("1) Anthrax Grenade: " + GrenadeLauncher.AnthraxGrenades))
            {
                GrenadeLauncher.SpellInput(ref oppHealth);
                EnemyTurn = true;
                playerTurn = false;
            }

            else if (Shop.AnthraxBomb >= 1 && MPlist.Contains("1) Double Shot: " + AnthraxBomb.DoubleShot))
            {
               AnthraxBomb.SpellInput(ref oppHealth);
                EnemyTurn = true;
                playerTurn = false;
            }

            else if (Shop.chanceSword >= 1 && MPlist.Contains("1) Gain Gold: " + ChanceSword.chancesword))
            {
                ChanceSword.SpellInput(ref oppHealth);
                EnemyTurn = true;
                playerTurn = false;
            }

            else if (Shop.Airtitan >= 1 && MPlist.Contains("1) Air Breaker: " + AirTitan.airBreakCost))
            {
                AirTitan.SpellInput(ref oppHealth);
                EnemyTurn = true;
                playerTurn = false;
            }
            else if (Shop.rodofsecrets>= 1 && MPlist.Contains("2) Crystal Blast: " + RodofSecrets.CRBlastCost))
            {
                RodofSecrets.SpellInput(ref oppHealth);
                EnemyTurn = true;
                playerTurn = false;
            }
            else if (Shop.rodofconistency >= 1 && MPlist.Contains("1) Consistency: " + RodofConsistency.consitencyCost))
            {
                RodofConsistency.SpellInput(ref oppHealth);
                EnemyTurn = true;
                playerTurn = false;
            }
            else if (Shop.earthrod >= 1 && MPlist.Contains("1) Stone Edge: " + EarthRod.stonedgeCost))
            {
                EarthRod.SpellInput(ref oppHealth);
                EnemyTurn = true;
                playerTurn = false;
            }
            else if (Shop.firerod >= 1 && MPlist.Contains("1) Firo: " + FireRod.FiroCost))
            {
                FireRod.SpellInput(ref oppHealth);
                EnemyTurn = true;
                playerTurn = false;
            }

            else if (Shop.bookofhealing >= 1 && MPlist.Contains("1) Heal : " + Bookofhealing.healCost))
            {
                Bookofhealing.SpellInput(ref oppHealth);
                EnemyTurn = true;
                playerTurn = false;
            }

            else if (Shop.frostbound >= 1 && MPlist.Contains("1) Ice: " + FronstBound.iceCost))
            {
                FronstBound.SpellInput(ref oppHealth);
                EnemyTurn = true;
                playerTurn = false;
            }

            else if (Shop.DefendersTome >= 1 && MPlist.Contains("1) Defense: " + DefendersTome.risedefenceCost))
            {
                DefendersTome.SpellInput(ref oppHealth);
                EnemyTurn = true;
                playerTurn = false;
            }

            else if (Shop.dragonscroll >= 1 && MPlist.Contains("1) Fire Breath: " + ScrolloftheDragon.firebreathcost))
            {
              ScrolloftheDragon.SpellInput(ref oppHealth);
                EnemyTurn = true;
                playerTurn = false;
            }

            else if (Shop.MissileLauncher >= 1 && MPlist.Contains("!) Anthrax Missile: " + MissileLauncher.Anthraxmissile))
            {
               MissileLauncher.SpellInput(ref oppHealth);
                EnemyTurn = true;
                playerTurn = false;
            }

            else if (Shop.bookofintermediates >= 1 && MPlist.Contains("1) Eartho: " + Bookofintermediates.earthoCost))
            {
                Bookofintermediates.SpellInput(ref oppHealth);
                EnemyTurn = true;
                playerTurn = false;
            }

            else
            {
                int input = 0;
                do
                {


               Console.WriteLine("None");
                    Console.WriteLine("Enter any number to go back");
                       Console.ReadLine();
                    if(input>=1){
                        playerTurn = true;
                        
                    }

                } while (!Utility.IsReadGood() );
                
             

            }

        }

        public static void Menu()
        {
            Program s1 = new Program();
            
            int Menuselect = 0;
            do
            {


                Console.Clear();
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Note: Difficulty isnt working in this version.");
                Console.WriteLine("BOSS RAID");
                Console.WriteLine("1) Boss Tower");
                Console.WriteLine("2) Stats and Inventory");
                Console.WriteLine("3) Shop");
                Console.WriteLine("4) Difficulty");
                Console.WriteLine("5) EndGame");
                Console.WriteLine("---------------------------------");
                Menuselect = Utility.ReadInt();




                MenuSelect select = (MenuSelect)(Menuselect);

                switch (select)
                {
                    case (MenuSelect.Tower):
                        int BossSelection = 0;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Enter 16 to go back.");
                            Console.WriteLine("1) PigeonHead");
                            if (BossUnlock.PidgeonHead == true)
                            {
                                 Console.WriteLine("2) Titan");
                            }

                            if (BossUnlock.Titan == true)
                            {
                                Console.WriteLine("3) Void Sorcerer");
                            }

                            if (BossUnlock.VoidS == true)
                            {
                                Console.WriteLine("4) Colosal Eye");
                            }

                            if (BossUnlock.ColosslEye== true)
                            {
                               Console.WriteLine("5) Master of the woods");
                            }

                            if (BossUnlock.MasterWood == true)
                            {
                               Console.WriteLine("6) Sensei Gouketsu");
                            }

                            if (BossUnlock.SenseiGouk == true)
                            {
                               Console.WriteLine("7) Guardian of the Abyss #1");
                            }

                            if (BossUnlock.Abyss2 == true)
                            {
                             Console.WriteLine("8) Guardian of the Abyss #2");
                            }

                            if (BossUnlock.other == true)
                            {
                      Console.WriteLine("9) Guardian of the Abyss #3");

                        Console.WriteLine("10) Sin Kiss");

                        Console.WriteLine("11) Shinkee");

                        Console.WriteLine("12) Timeus of Time");

                        Console.WriteLine("12) Recreuss");

                        Console.WriteLine("13) Dweller of the Planet");

                        Console.WriteLine("14) The Mastermind");

                        Console.WriteLine("15) End Game: The Creator, Psychosis");
                            }
                       
                            BossSelection = Utility.ReadInt();
                         } while (!Utility.IsReadGood() || BossSelection > 16);
                       

                        
                        if (BossSelection == 1)
                         {
                            int PidgInput = 0;
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("1) Leech");
                                if (BossUnlock.Eyesman == true)
                                {
                                Console.WriteLine("2) Eyemen");
                                }
                                if (BossUnlock.PidgeonHead == true)
                                {
                                 Console.WriteLine("3) PidgeonHead");
                                }
                               
                                Console.WriteLine("4) Go back");
                                PidgInput = Utility.ReadInt();
                                } while (!Utility.IsReadGood() || PidgInput > 4);

                                if(PidgInput == 1)
                                {
                                    LeechMonster.LeechBattle();
                                }

                                if (PidgInput == 2 && BossUnlock.Eyesman == true)
                                {
                                    Eyemen.EyemenBattle();
                                }

                                if (PidgInput == 3 && BossUnlock.PidgeonHead == true)
                                {

                                s1.pigeonHead();
                                }


                            if (PidgInput == 4)
                            {
                                goto case MenuSelect.Tower;
                            }
                           
                          }

                         if (BossSelection == 2 && BossUnlock.PidgeonHead == true)
                        {
                            int PidgInput = 0;
                            do
                            {
                                Console.Clear();
                                
                                 Console.WriteLine("1) Cobalt Puncher");
                                
                                if (BossUnlock.GiantS == true)
                                {
                                  Console.WriteLine("2) Giant Spider");
                                }
                                if (BossUnlock.Titan == true)
                                {
                                  Console.WriteLine("3) Titan");

                                }
                                
                                Console.WriteLine("4) Go back");
                                PidgInput = Utility.ReadInt();
                            } while (!Utility.IsReadGood() || PidgInput > 4);

                            if (PidgInput == 1)
                            {
                                CobaltPuncher.CobaltBattle();
                            }

                            if (PidgInput == 2 && BossUnlock.GiantS== true)
                            {
                                GiantSpider.SpiderBattle();
                            }

                            if (PidgInput == 3 && BossUnlock.Titan == true)
                            {
                                Titan.TitanBattle();
                            }

                            if (PidgInput == 4)
                            {
                                goto case MenuSelect.Tower;
                            }
                        }

                        else if (BossSelection == 3 && BossUnlock.Titan == true)
                        {
                            int PidgInput = 0;
                            do
                            {
                                Console.Clear();
                               
                                  Console.WriteLine("1) MudMonster");
                                
                                if (BossUnlock.MadScientist == true)
                                {
                                  Console.WriteLine("2) Mad Scientist");
                                }
                                if (BossUnlock.AppMag == true)
                                {
                                  Console.WriteLine("3) Apprentice Magician");
                                }
                                if (BossUnlock.VoidS == true)
                                {
                                   Console.WriteLine("4) Void Sorcerer");
                                }
                                
                                Console.WriteLine("5) Go back");
                                PidgInput = Utility.ReadInt();
                            } while (!Utility.IsReadGood() || PidgInput > 5);

                            if (PidgInput == 1)
                            {
                                MudMonster.MudMonsterBattle();
                            }

                            if (PidgInput == 2 && BossUnlock.MudMonster == true)
                            {
                                MadScientist.MadScientistBattle();
                            }

                            if (PidgInput == 3 && BossUnlock.MadScientist == true)
                            {
                                ApprenticeMag.AMagBattle();
                            }

                            if (PidgInput == 4 && BossUnlock.AppMag == true)
                            {
                                VoidSorcerer.VoidSBattle();
                            }

                            if (PidgInput == 5)
                            {
                                goto case MenuSelect.Tower;
                            }

                        }


                       if (BossSelection == 4 && BossUnlock.VoidS== true)
                        {
                            int PidgInput = 0;
                            do
                            {
                                Console.Clear();
                                
                                   Console.WriteLine("1) Giant Hand");
                                
                                if (BossUnlock.StoneOgre == true)
                                {
                                   Console.WriteLine("2) Stone Ogre");
                                }

                                if (BossUnlock.ColosslEye == true)
                                {
                                  Console.WriteLine("3) Colossal Eye");
                                }
                               
                                Console.WriteLine("4) Go Back");
                                PidgInput = Utility.ReadInt();
                            } while (!Utility.IsReadGood() || PidgInput > 4);

                            if (PidgInput == 1)
                            {
                                GiantHand.GiantHBattle();
                            }

                            if (PidgInput == 2 && BossUnlock.GiantHand == true)
                            {
                                StoneOgre.SOgreBattle();
                            }

                            if (PidgInput == 3 && BossUnlock.StoneOgre == true)
                            {
                                ColossalEye.ColEyeBattle();
                            }
                            if (PidgInput == 4)
                            {
                                goto case MenuSelect.Tower;
                            }

                        }


                        if (BossSelection == 5 && BossUnlock.ColosslEye == true)
                        {
                            int PidgInput = 0;
                            do
                            {
                                Console.Clear();
                                
                                   Console.WriteLine("1) Queen Pixie");
                                
                                if (BossUnlock.ElfLord == true)
                                {
                                   Console.WriteLine("2) King Elf");
                                }
                                if (BossUnlock.MasterWood == true)
                                {
                                   Console.WriteLine("3) Master of the Woods");
                                }
                               
                                Console.WriteLine("4) Go back");
                                PidgInput = Utility.ReadInt();
                            } while (!Utility.IsReadGood() || PidgInput > 4);

                            if (PidgInput == 1)
                            {
                                QueenPixie.QueenPixieBattle();
                            }

                            if (PidgInput == 2 && BossUnlock.QueenP == true)
                            {
                                KingElf.KingElfBattle();
                            }

                            if (PidgInput == 3 && BossUnlock.ElfLord == true)
                            {
                                MasteroftheWoods.MasterWBattle();
                            }

                            if (PidgInput == 4)
                            {
                                goto case MenuSelect.Tower;
                            }
 break;
                        }
                              

                         if (BossSelection == 6 && BossUnlock.MasterWood == true)
                        {
                            int PidgInput = 0;
                            do
                            {
                                Console.Clear();
                                
                                    Console.WriteLine("1) Sonic Warrior ");
                                
                                if (BossUnlock.GoldenSam == true)
                                {
                                   Console.WriteLine("2) Golden Samurai");
                                }
                                if (BossUnlock.SenseiGouk == true)
                                {
                                  Console.WriteLine("3) Sensei Gouketsu");
                                }
                               
                                Console.WriteLine("4) Go Back");
                                PidgInput = Utility.ReadInt();
                            } while (!Utility.IsReadGood() || PidgInput > 4);

                            if (PidgInput == 1)
                            {
                                SonicWarrior.SonicWBattle();
                            }

                            if (PidgInput == 2 && BossUnlock.SonicW == true)
                            {
                                GoldenSamurai.GoldSamuraiBattle();
                            }

                            if (PidgInput == 3 && BossUnlock.GoldenSam== true)
                            {
                                SenseiGouketsu.GouketsuBattle();
                            }

                            if (PidgInput == 4)
                            {
                                goto case MenuSelect.Tower;
                            }
 break;
                        }
                       

                        if (BossSelection == 7 && BossUnlock.SenseiGouk == true)
                        {
                            int PidgInput = 0;
                            do
                            {
                                Console.Clear();
                                
                                    Console.WriteLine("1) Cybernetic Cowboy");
                                
                                if (BossUnlock.Kraken == true)
                                {
                                    Console.WriteLine("2) Kraken");
                                }
                                if (BossUnlock.Abyss1 == true)
                                {
                                    Console.WriteLine("3) Guardian of the Abyss #1");
                                }
                                Console.WriteLine("4) Go Back");
                                PidgInput = Utility.ReadInt();
                            } while (!Utility.IsReadGood() || PidgInput > 4);

                            if (PidgInput == 1)
                            {
                                CyberneticCowboy.CyberCowboyBattle();
                            }

                            if (PidgInput == 2 && BossUnlock.CyberneticCow == true)
                            {
                                Kraken.KrakenBattle();
                            }

                            if (PidgInput == 3 && BossUnlock.Kraken == true)
                            {
                                Abyss1.Abyss1Battle();
                            }

                            if (PidgInput == 4)
                            {
                                goto case MenuSelect.Tower;
                            }
 break;
                        }
                       

                        if (BossSelection == 8 && BossUnlock.Abyss1 == true)
                        {
                            int PidgInput = 0;
                            do
                            {
                                Console.Clear();
                                if (BossUnlock.GiantSerp == true)
                                {
                                  Console.WriteLine("1) Giant Serpent");
                                }
                                if (BossUnlock.TwilightSw == true)
                                {
                                  Console.WriteLine("2) Twilight Swordsman");
                                }
                                if (BossUnlock.Abyss2 == true)
                                {
                                  Console.WriteLine("3) Guardian of the Abyss #2");
                                }
                                
                                Console.WriteLine("4) Go back");
                                PidgInput = Utility.ReadInt();
                            } while (!Utility.IsReadGood() || PidgInput > 4);

                            if (PidgInput == 1)
                            {
                                GiantSerpent.GiantSerpentBattle();
                            }

                            if (PidgInput == 2 && BossUnlock.GiantSerp== true)
                            {
                                TwilightSwordsman.TwilightBattle();
                            }

                            if (PidgInput == 3 && BossUnlock.TwilightSw == true)
                            {
                                Abyss2.Abyss2Battle();
                            }

                            if (PidgInput == 4)
                            {
                                goto case MenuSelect.Tower;
                            }
                            break;
                        }


                        if (BossSelection == 16)
                        {
                            Menu();


                        }

                        else
                        {
 Console.WriteLine("Some Weirdness is going on beware!");
                            Console.ReadLine();
                        }
                                
                        break;

                    case (MenuSelect.stats):
                        int input1 = 0;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Username: " + username);
                            Console.WriteLine("Level: " + Level);
                            Console.WriteLine("Gold: " + Gold);
                            Console.WriteLine("Exp: " + Exp);
                            Console.WriteLine("Health: " + HP);
                            Console.WriteLine("Magic Power: " + MaxMP);
                            Console.WriteLine("Attack: " + Atk);
                            Console.WriteLine("Defense: " + Def);
                            Console.WriteLine("Press '1' for Inventory");

                            input1 = Utility.ReadInt();

                            if (input1 == 1)
                            {
                                do
                                {
                                    Console.WriteLine("1) Weapons");
                                    Console.WriteLine("2) Armour");
                                    Console.WriteLine("3) Items");

                                    int inputS = 0;
                                    do
                                    {
                                        inputS = Utility.ReadInt();

                                        if (inputS == 1)
                                        {
                                            Shop.CheckWeapons();
                                            int inputW = 0;

                                            do
                                            {
                                                inputW = Utility.ReadInt();
                                                if (inputW == 1 && Shop.BronzeSword >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.BronzeSword);
                                                    MPlist.Clear();
                                                    Console.WriteLine("Equipped BronzeSword");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                } 

                                                if (inputW == 2 && Shop.RuggedAxe >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.RuggedAxe);
                                                    MPlist.Clear();
                                                    Console.WriteLine("Equipped RuggedAxe");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 3 && Shop.BattleWand >= 1)
                                                {
                                                    
                                                    equip.Clear();
                                                    equip.Add(Shop.BattleWand);
                                                    MPlist.Clear();
                                                    MPlist.Add("1) Rock Toss: " + Battlewand.RockTCost);
                                                    MPlist.Add("2) FireBall: " + Battlewand.FireBCost);
                                                    MPlist.Add("3) FreezeBall: " + Battlewand.FreezeBCost);
                                                    MPlist.Add("4) EarthQuake: " + Battlewand.EarthquakeCost);
                                                    Console.WriteLine("Equipped Battlewand");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW ==4 && Shop.BookofBeginners >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.BookofBeginners);
                                                    MPlist.Clear();
                                                    MPlist.Add("1) Fire: " + BookofBeginners.fireCost);
                                                    MPlist.Add("2) Water: " + BookofBeginners.waterCost);
                                                    MPlist.Add("3) Air: " + BookofBeginners.airCost);
                                                    MPlist.Add("4) Earth: " + BookofBeginners.earthCost);
                                                    Console.WriteLine("Equipped Book of Beginners");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 5 && Shop.BabyFlute >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.BabyFlute);
                                                    MPlist.Clear();
                                                    MPlist.Add("1) Baby Eyeman: " + BabyFlute.babyeyemancost);
                                                    MPlist.Add("2) Baby Leeches: " + BabyFlute.babyleechescost);
                                                    MPlist.Add("3) Baby Bats: " + BabyFlute.babybatscost);
                                                    MPlist.Add("4) Baby Ogres: " + BabyFlute.babyogrecost);
                                                    Console.WriteLine("Equipped Baby Flute");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 6 && Shop.insectHormones >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.insectHormones);
                                                    Console.WriteLine("Equipped Insect Hormones");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 7 && Shop.Mfour >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.Mfour);
                                                    MPlist.Clear();
                                                    MPlist.Add("1) Explosive Shot: " + MFour.roundDmg);
                                                    Console.WriteLine("Equipped M4");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 8 && Shop.SniperRifle >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.SniperRifle);
                                                    MPlist.Clear();
                                                    MPlist.Add("1) Anti-Tank: " + SniperRifle.antitank);
                                                    MPlist.Add("2) Explosive Shot: " + SniperRifle.explosiveShot);
                                                    Console.WriteLine("Equipped SniperRifle");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 9 && Shop.grenades >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.grenades);
                                                    MPlist.Clear();
                                                    MPlist.Add("1) Multi-Grenades: " + Grenades.multigrenade);
                                                    Console.WriteLine("Equipped Grenades");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 10 && Shop.claymores>= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.claymores);
                                                    MPlist.Clear();
                                                    MPlist.Add("1) Claymores 2x : " + Claymores.claymore2x);
                                                    MPlist.Add("2) Burn Claymore: " + Claymores.burnClaymore);
                                                    Console.WriteLine("Equipped Claymores");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 11 && Shop.rustySabre >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.rustySabre);
                                                    MPlist.Clear();
                                                    Console.WriteLine("Equipped Rusty Sabre");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 12 && Shop.Flanchard >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.Flanchard);
                                                    MPlist.Clear();
                                                    Console.WriteLine("Equipped Flanchard");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 13 && Shop.IceBringer >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.IceBringer);
                                                    MPlist.Clear();
                                                    MPlist.Add("1) IceSlash: " + IceBringer.IceSlashCost);
                                                    Console.WriteLine("Equipped IceBringer");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 14 && Shop.spellbinder >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.spellbinder);
                                                    MPlist.Clear();
                                                    MPlist.Add("1) Half Damage: " + SpellBinder.halfDmgcost);
                                                    MPlist.Add("2) SpellRender: " + SpellBinder.spellrenderCost);
                                                    MPlist.Add("3) Aura Pulse: " + SpellBinder.aurapulseCost);
                                                    Console.WriteLine("Equipped SpellBinder");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 15 && Shop.fairyMace >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.fairyMace);
                                                    MPlist.Clear();
                                                    MPlist.Add("1) Fairy Dust: " + FairyMace.FairyDustCost);
                                                    MPlist.Add("2) Fairy Explosion: " + FairyMace.DustExplosionCost);
                                                    Console.WriteLine("Equipped FairyMace");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 16 && Shop.WaterWand >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.WaterWand);
                                                    MPlist.Clear();
                                                    MPlist.Add("1) WaterStream: " + Waterwand.waterstreamCost);
                                                    MPlist.Add("2) Water Gun: " + Waterwand.watergunCost);
                                                    MPlist.Add("3) Water Whip: " + Waterwand.waterwhip);
                                                    MPlist.Add("4) Octupus Style: " + Waterwand.OctupusCost);
                                                    Console.WriteLine("Equipped Waterwand");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 17 && Shop.airWhisperer>= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.airWhisperer);
                                                    MPlist.Clear();
                                                    MPlist.Add("1) AirSlash: " + AirWhisperer.airSlashCost);
                                                    MPlist.Add("2) AirRender: " + AirWhisperer.AirRendCost);
                                                    Console.WriteLine("Equipped Air Whisperer");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 18 && Shop.EveningStar >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.EveningStar);
                                                    MPlist.Clear();
                                                    MPlist.Add("1) Sparkle Blast: " + EveningStar.SparkleBlastCost);
                                                    MPlist.Add("2) Meteorite Shower: " + EveningStar.MeteoriteSCost);
                                                    MPlist.Add("3) Meteor: " + EveningStar.Meteor);
                                                    Console.WriteLine("Equipped EveningStar");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 19 && Shop.uzi>= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.uzi);
                                                    MPlist.Clear();
                                                    Console.WriteLine("Equipped Uzi");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 20 && Shop.Twilightlongrifle >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.Twilightlongrifle);
                                                    MPlist.Clear();
                                                    MPlist.Add("1) Star Blaster: " + TwilightLongRifle.starblasterCost);
                                                    MPlist.Add("2) Light Pulsar: " + TwilightLongRifle.LightPulseCost);
                                                    Console.WriteLine("Equipped Twilight LongRifle");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 21 && Shop.GrenadeLauncher >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.GrenadeLauncher);
                                                    MPlist.Clear();
                                                    MPlist.Add("1) Anthrax Grenade: " + GrenadeLauncher.AnthraxGrenades);
                                                    MPlist.Add("2) Ailment Grenade: " + GrenadeLauncher.AilmentGrenades);
                                                    Console.WriteLine("Equipped Grenade Launcher");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 22 && Shop.rocketlauncher >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.rocketlauncher);
                                                    MPlist.Clear();                                                    
                                                    Console.WriteLine("Equipped Rocket Launcher");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 23 && Shop.AnthraxBomb >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.AnthraxBomb);
                                                    MPlist.Clear();
                                                    MPlist.Add("1) Double Shot: " + AnthraxBomb.DoubleShot);
                                                    MPlist.Add("2) WideSpread Disease: " + AnthraxBomb.WideSpreadDisease);
                                                    Console.WriteLine("Equipped Anthrax Bomb");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 24 && Shop.chanceSword >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.chanceSword);
                                                    MPlist.Clear();
                                                    MPlist.Add("1) Gain Gold: " + ChanceSword.chancesword);
                                                    MPlist.Add("2) Gain Exp: " + ChanceSword.chancesword);
                                                    Console.WriteLine("Equipped Chance Sword");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 25 && Shop.valyrianSword >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.valyrianSword);
                                                    MPlist.Clear();
                                                    Console.WriteLine("Equipped Valyrian Sword");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 26 && Shop.elementalSword >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.elementalSword);
                                                    MPlist.Clear();
                                                    MPlist.Add("1) Ice Crash: " + ElementalSword.icecrashCost);
                                                    MPlist.Add("2) Fire Slash: " + ElementalSword.fireslashCost);
                                                    MPlist.Add("3) Lightning Slash: " + ElementalSword.lightninsSlashCost);
                                                    Console.WriteLine("Equipped Elemental Sword");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 27 && Shop.gutrender >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.gutrender);
                                                    MPlist.Clear();
                                                    Console.WriteLine("Equipped GutRender");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 28 && Shop.DireDualblade >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.DireDualblade);
                                                    MPlist.Clear();
                                                    Console.WriteLine("Equipped Dire - DualBlade");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 29 && Shop.Airtitan >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.Airtitan);
                                                    MPlist.Clear();
                                                    MPlist.Add("1) Air Breaker: " + AirTitan.airBreakCost);
                                                    MPlist.Add("2) Air Blast: " + AirTitan.airBlastCost);
                                                    Console.WriteLine("Equipped Air Titan");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 30 && Shop.rodofsecrets >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.rodofsecrets);
                                                    MPlist.Clear();
                                                    MPlist.Add("1) Crystal Blast: " + RodofSecrets.CRBlastCost);
                                                    MPlist.Add("2) Sephon Terror: " + RodofSecrets.sephontcost);
                                                    MPlist.Add("3) Darkness: " + RodofSecrets.darknessCost);
                                                    MPlist.Add("4) Solar Blast: " + RodofSecrets.solrBlastCost);
                                                    Console.WriteLine("Equipped Rod of Secrets");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 31 && Shop.rodofconistency >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.rodofconistency);
                                                    MPlist.Clear();
                                                    MPlist.Add("1) Consistency: " + RodofConsistency.consitencyCost);
                                                    Console.WriteLine("Equipped Rod of Consistency");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 32 && Shop.earthrod >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.earthrod);
                                                    MPlist.Clear();
                                                    MPlist.Add("1) Stone Edge: " + EarthRod.stonedgeCost);
                                                    MPlist.Add("2) Rock Storm: " + EarthRod.RockStormCost);
                                                    MPlist.Add("3) Boulder Storm: " + EarthRod.BoulderStormCost);
                                                    MPlist.Add("4) Catastrophe: " + EarthRod.CatastropheCost);
                                                    Console.WriteLine("Equipped Earth Rod");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 33 && Shop.firerod >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.firerod);
                                                    MPlist.Clear();
                                                    MPlist.Add("1) Firo: " + FireRod.FiroCost);
                                                    MPlist.Add("2) Fire Wheel: " + FireRod.FireWheelCost);
                                                    MPlist.Add("3) Flame Tornado: " + FireRod.FlameTornadoCost);
                                                    MPlist.Add("4) Volcanic Eruption: " + FireRod.VolcanicCost);
                                                    Console.WriteLine("Equipped Fire Rod");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 34 && Shop.bookofhealing >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.bookofhealing);
                                                    MPlist.Clear();
                                                    MPlist.Add("1) Heal : " + Bookofhealing.healCost);
                                                    MPlist.Add("2) Super Heal: " + Bookofhealing.superhealCost);
                                                    MPlist.Add("3) Heal Drain: " + Bookofhealing.healdrainCost);
                                                    MPlist.Add("4) All Heal: " + Bookofhealing.allhealcost);
                                                    Console.WriteLine("Equipped Book Of Healing");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 35 && Shop.dragonscroll >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.dragonscroll);
                                                    MPlist.Clear();
                                                    MPlist.Add("1) Fire Breath: " + ScrolloftheDragon.firebreathcost);
                                                    MPlist.Add("2) Blast Fury: " + ScrolloftheDragon.blastfurycost);
                                                    Console.WriteLine("Equipped Scroll of the Dragon");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 36 && Shop.frostbound >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.frostbound);
                                                    Console.WriteLine("Equipped FrostBound");
                                                    MPlist.Clear();
                                                    MPlist.Add("1) Ice: " + FronstBound.iceCost);
                                                    MPlist.Add("2) Iceo: " + FronstBound.iceoCost);
                                                    MPlist.Add("3) Iceoro: " + FronstBound.iceoroCost);
                                                    MPlist.Add("4) FrozenFury: " + FronstBound.fronzenfurycost);
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 37 && Shop.DefendersTome >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.DefendersTome);
                                                    MPlist.Clear();
                                                    MPlist.Add("1) Defense: " + DefendersTome.risedefenceCost);
                                                    MPlist.Add("2) Ally Def: " + DefendersTome.riseallydefcost);
                                                    MPlist.Add("3) Invincible: " +DefendersTome.invincibleCost);
                                                    Console.WriteLine("Equipped Defender's Tome");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 38 && Shop.shotgun >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.shotgun);
                                                    MPlist.Clear();
                                                    Console.WriteLine("Equipped Shotgun");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 39 && Shop.roaringobsidianblaster >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.roaringobsidianblaster);
                                                    MPlist.Clear();
                                                    MPlist.Add("1) Magnetic Blaster: " + RoaringObsidianBlaster.MBCost);
                                                    MPlist.Add("2) Graviton Destruction: " + RoaringObsidianBlaster.GravitonCost);
                                                    Console.WriteLine("Equipped Roaring Obsidian Blaster");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 40 && Shop.Peacekiller >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.Peacekiller);
                                                    MPlist.Clear();
                                                    MPlist.Add("1) Destruction: " + PeaceKiller.DestructionCost);
                                                    MPlist.Add("2) Insidious PierceShot: " + PeaceKiller.insidiuosCost);
                                                    Console.WriteLine("Equipped PeaceKiller");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 41 && Shop.AK47 >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.AK47);
                                                    MPlist.Clear();
                                                    Console.WriteLine("Equipped AK47");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 42 && Shop.Choppa >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.Choppa);
                                                    MPlist.Clear();
                                                    Console.WriteLine("Equipped Choppa");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 43 && Shop.railgun >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.railgun);
                                                    MPlist.Clear();
                                                    Console.WriteLine("Equipped Railgun");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 44 && Shop.AT4 >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.AT4);
                                                    MPlist.Clear();
                                                    Console.WriteLine("Equipped AT-4");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 45 && Shop.MissileLauncher >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.MissileLauncher);
                                                    MPlist.Clear();
                                                    MPlist.Add("1) Anthrax Missile: " + MissileLauncher.Anthraxmissile);
                                                    MPlist.Add("2) Uranium: " + MissileLauncher.Uranium);
                                                    Console.WriteLine("Equipped Missile Launcher");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 46 && Shop.silverSword >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.silverSword);
                                                    MPlist.Clear();
                                                    Console.WriteLine("Equipped SilverSword");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 47 && Shop.Comrade >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.Comrade);
                                                    MPlist.Clear();
                                                    Console.WriteLine("Equipped Comrade");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 48 && Shop.waraxe >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.waraxe);
                                                    MPlist.Clear();
                                                    Console.WriteLine("Equipped War Axe");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 49 && Shop.bookofintermediates >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.bookofintermediates);
                                                    MPlist.Clear();
                                                    MPlist.Add("1) Eartho: " + Bookofintermediates.earthoCost);
                                                    MPlist.Add("2) Windo: " + Bookofintermediates.windoCost);
                                                    MPlist.Add("3) Watero: " + Bookofintermediates.wateroCost);
                                                    Console.WriteLine("Equipped Book of Intermediates");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 50 && Shop.tomeofpower >= 1)
                                                {
                                                    equip.Clear();
                                                    equip.Add(Shop.tomeofpower);
                                                    MPlist.Clear();
                                                    Console.WriteLine("Equipped Tome of Power");
                                                    Console.WriteLine("Push any button to go back to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }



                                                    } while (!Utility.IsReadGood());

                                                }

                                                else
                                                {
                                                    goto case MenuSelect.stats;
                                                }



                                            } while (!Utility.IsReadGood()); // Is BronzeSword Input a int?

                                        } //Inventory Menu Input  for Weapons  





                                        if (inputS == 2)
                                        {

                                            Shop.CheckArmour();
                                            int inputW = 0;
                                            do
                                            {
                                                inputW = Utility.ReadInt();
                                                if (inputW == 1 && Shop.leathervest >= 1)
                                                {
                                                    armour.Clear();
                                                    armour.Add(Shop.leathervest);
                                                    LeatherVest.EquipLeatherVest();
                                                    Console.WriteLine("You equipped the leatherVest");
                                                    Console.WriteLine("Push 4 to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Wrong Input!");
                                                        }
                                                    } while (!Utility.IsReadGood());

                                                }


                                                if (inputW == 2 && Shop.RoundShield >= 1)
                                                {
                                                    armour.Clear();
                                                    armour.Add(Shop.RoundShield);
                                                    RoundShield.EquipRoundShield();
                                                    Console.WriteLine("You equipped the RoundShield");
                                                    Console.WriteLine("Push 4 to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Wrong Input!");
                                                        }
                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 3 && Shop.SpikedShield >= 1)
                                                {
                                                    armour.Clear();
                                                    armour.Add(Shop.SpikedShield);
                                                    SpikedShield.EquipSpikedShield();
                                                    HurtDamage = true;
                                                    Console.WriteLine("You equipped the SpikedShield");
                                                    Console.WriteLine("Push 4 to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Wrong Input!");
                                                        }
                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 4 && Shop.ClearRobe >= 1)
                                                {
                                                    armour.Clear();
                                                    armour.Add(Shop.ClearRobe);
                                                    ClearRobe.EquipClearRobe();
                                                    Console.WriteLine("You equipped the ClearRobe");
                                                    Console.WriteLine("Push 4 to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Wrong Input!");
                                                        }
                                                    } while (!Utility.IsReadGood());

                                                }
                                                if (inputW == 5 && Shop.AntFlakRobe >= 1)
                                                {
                                                    armour.Clear();
                                                    armour.Add(Shop.AntFlakRobe);
                                                    AntiFlakRobe.EquipAntiFlakRobe();
                                                    Console.WriteLine("You equipped the Anti-Flak Robe");
                                                    Console.WriteLine("Push 4 to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Wrong Input!");
                                                        }
                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 6 && Shop.Kevlar >= 1)
                                                {
                                                    armour.Clear();
                                                    armour.Add(Shop.Kevlar);
                                                    Kevlar.EquipKevlar();
                                                    Console.WriteLine("You equipped the Kevlar");
                                                    Console.WriteLine("Push 4 to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Wrong Input!");
                                                        }
                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 7 && Shop.BallisticVest >= 1)
                                                {
                                                    armour.Clear();
                                                    armour.Add(Shop.BallisticVest);
                                                    BallisticVest.EquipBallisticVest();
                                                    Console.WriteLine("You equipped the BallisticVest");
                                                    Console.WriteLine("Push 4 to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Wrong Input!");
                                                        }
                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 8 && Shop.Chainmail >= 1)
                                                {
                                                    armour.Clear();
                                                    armour.Add(Shop.Chainmail);
                                                   ChainMail.EquipChainMail();
                                                    Console.WriteLine("You equipped the Chainmail");
                                                    Console.WriteLine("Push 4 to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Wrong Input!");
                                                        }
                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 9 && Shop.SilverShield >= 1)
                                                {
                                                    armour.Clear();
                                                    armour.Add(Shop.SilverShield);
                                                   SilverShield.EquipSilverSword();
                                                    Console.WriteLine("You equipped the Silver shield");
                                                    Console.WriteLine("Push 4 to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Wrong Input!");
                                                        }
                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 10 && Shop.BrickShield >= 1)
                                                {
                                                    armour.Clear();
                                                    armour.Add(Shop.BrickShield);
                                                    BrickShield.EquipBrickShield();
                                                    Console.WriteLine("You equipped the Brick Shield");
                                                    Console.WriteLine("Push 4 to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Wrong Input!");
                                                        }
                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 11 && Shop.longShield >= 1)
                                                {
                                                    armour.Clear();
                                                    armour.Add(Shop.longShield);
                                                    longShield.Equiplongshield();
                                                    Console.WriteLine("You equipped the Long Shield");
                                                    Console.WriteLine("Push 4 to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Wrong Input!");
                                                        }
                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 12 && Shop.KnightsArmour >= 1)
                                                {
                                                    armour.Clear();
                                                    armour.Add(Shop.KnightsArmour);
                                                    KnightsArmour.EquipKnightArmour();
                                                    Console.WriteLine("You equipped the Knights Armour");
                                                    Console.WriteLine("Push 4 to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Wrong Input!");
                                                        }
                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 13 && Shop.SilverArmour >= 1)
                                                {
                                                    armour.Clear();
                                                    armour.Add(Shop.SilverArmour);
                                                    SilverArmour.EquipsilverArmour();
                                                    Console.WriteLine("You equipped the Silver Armour");
                                                    Console.WriteLine("Push 4 to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Wrong Input!");
                                                        }
                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 14 && Shop.FireResRobe >= 1)
                                                {
                                                    armour.Clear();
                                                    armour.Add(Shop.FireResRobe);
                                                    FireResRobe.EquipFireRobe();
                                                    Console.WriteLine("You equipped the Fire Resistant Robe");
                                                    Console.WriteLine("Push 4 to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Wrong Input!");
                                                        }
                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 15 && Shop.WaterResRobe >= 1)
                                                {
                                                    armour.Clear();
                                                    armour.Add(Shop.WaterResRobe);
                                                    WaterResRobe.Equipwaterresrobe();
                                                    Console.WriteLine("You equipped the Water Resistance Robe");
                                                    Console.WriteLine("Push 4 to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Wrong Input!");
                                                        }
                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 16 && Shop.AirResRobe >= 1)
                                                {
                                                    armour.Clear();
                                                    armour.Add(Shop.AirResRobe);
                                                    AirResRobe.EquipAirResRobe();
                                                    Console.WriteLine("You equipped the Air Resistance Robe");
                                                    Console.WriteLine("Push 4 to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Wrong Input!");
                                                        }
                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 17 && Shop.EarthResRobe>= 1)
                                                {
                                                    armour.Clear();
                                                    armour.Add(Shop.EarthResRobe);
                                                    EarthResRobe.EquipBallisticVest();
                                                    Console.WriteLine("You equipped the Earth Resistance Robe");
                                                    Console.WriteLine("Push 4 to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Wrong Input!");
                                                        }
                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 18 && Shop.RefexRobe >= 1)
                                                {
                                                    armour.Clear();
                                                    armour.Add(Shop.RefexRobe);
                                                    ReflexRobe.EquipBallisticVest();
                                                    Console.WriteLine("You equipped the Reflex Robe");
                                                    Console.WriteLine("Push 4 to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Wrong Input!");
                                                        }
                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 19 && Shop.MultiCams >= 1)
                                                {
                                                    armour.Clear();
                                                    armour.Add(Shop.MultiCams);
                                                    MultiCams.EquipMultiCams();
                                                    Console.WriteLine("You equipped the Multi-Cams");
                                                    Console.WriteLine("Push 4 to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Wrong Input!");
                                                        }
                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 20 && Shop.Carbonnanotube >= 1)
                                                {
                                                    armour.Clear();
                                                    armour.Add(Shop.Carbonnanotube);
                                                    CarbonNanotubeSuit.EquipBallisticVest();
                                                    Console.WriteLine("You equipped the CarbonNanotube Suit");
                                                    Console.WriteLine("Push 4 to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Wrong Input!");
                                                        }
                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 21 && Shop.Camouflauge >= 1)
                                                {
                                                    armour.Clear();
                                                    armour.Add(Shop.Camouflauge);
                                                   Camoflauge.EquipCamoflauge();
                                                    Console.WriteLine("You equipped the Camoflauge");
                                                    Console.WriteLine("Push 4 to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Wrong Input!");
                                                        }
                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 22 && Shop.HAZMAT >= 1)
                                                {
                                                    armour.Clear();
                                                    armour.Add(Shop.HAZMAT);
                                                  HazmatSuit.EquipBallisticVest();
                                                    Console.WriteLine("You equipped the HAZMAT Suit");
                                                    Console.WriteLine("Push 4 to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Wrong Input!");
                                                        }
                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 23 && Shop.Technogear >= 1)
                                                {
                                                    armour.Clear();
                                                    armour.Add(Shop.Technogear);
                                                   TechnicianGear.EquipTechGear();
                                                    Console.WriteLine("You equipped the Technician Gear");
                                                    Console.WriteLine("Push 4 to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Wrong Input!");
                                                        }
                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 24 && Shop.Fireretarent >= 1)
                                                {
                                                    armour.Clear();
                                                    armour.Add(Shop.Fireretarent);
                                                   FireRetardentSuit.EquipFireRetardentGear();
                                                    Console.WriteLine("You equipped the Fire Retardent Suit");
                                                    Console.WriteLine("Push 4 to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Wrong Input!");
                                                        }
                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 25 && Shop.raingear >= 1)
                                                {
                                                    armour.Clear();
                                                    armour.Add(Shop.raingear);
                                                   RainGear.EquipRainGear();
                                                    Console.WriteLine("You equipped the Raingear");
                                                    Console.WriteLine("Push 4 to go back");
                                                    int inputA = 0;
                                                    do
                                                    {
                                                        inputA = Utility.ReadInt();
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Wrong Input!");
                                                        }
                                                    } while (!Utility.IsReadGood());

                                                }

                                                else
                                                {
                                                    goto case MenuSelect.stats;
                                                }
                                            } while (!Utility.IsReadGood());// Is the input an int?


                                        }  // Inventory Menu input for Armour    

                                      

                                        if (inputS == 3)
                                        {
                                           Shop.CheckItems();
                                            //GrabInventory();
                                            int inputW = 0;
                                            do
                                            {
                                               
                                                inputW = Utility.ReadInt();
                                                if (inputW == 1 && Shop.Potion >= 1)
                                                {

                                                    items.Add(Shop.Potion);
                                                    Console.WriteLine("Potions " + Shop.Potion + " x");
                                                    Console.WriteLine("Push any button to go back");

                                                    int inputA = 0;
                                                    do
                                                    {
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }

                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 2 && Shop.medkit >= 1)
                                                {

                                                    items.Add(Shop.medkit);
                                                    Console.WriteLine("MedKits " + Shop.medkit + "x");
                                                    Console.WriteLine("Push any button to go back");

                                                    int inputA = 0;
                                                    do
                                                    {
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }

                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 3 && Shop.Potion >= 1)
                                                {

                                                    items.Add(Shop.medPotion);
                                                    Console.WriteLine("MedPotions " + Shop.medPotion + "x");
                                                    Console.WriteLine("Push any button to go back");

                                                    int inputA = 0;
                                                    do
                                                    {
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }

                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 4 && Shop.bottlewine >= 1)
                                                {

                                                    items.Add(Shop.bottlewine);
                                                    Console.WriteLine("Bottles of Wine " + Shop.bottlewine + "x");
                                                    Console.WriteLine("Push any button to go back");

                                                    int inputA = 0;
                                                    do
                                                    {
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }

                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 5 && Shop.cleansingPowder >= 1)
                                                {

                                                    items.Add(Shop.cleansingPowder);
                                                    Console.WriteLine("CleansingPowder " + Shop.cleansingPowder + "x");
                                                    Console.WriteLine("Push any button to go back");

                                                    int inputA = 0;
                                                    do
                                                    {
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }

                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 6 && Shop.senzubean >= 1)
                                                {

                                                    items.Add(Shop.senzubean);
                                                    Console.WriteLine("Beans of Senzu " + Shop.senzubean + "x");
                                                    Console.WriteLine("Push any button to go back");

                                                    int inputA = 0;
                                                    do
                                                    {
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }

                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 7 && Shop.featherPheonix >= 1)
                                                {

                                                    items.Add(Shop.featherPheonix);
                                                    Console.WriteLine("Feathers of the Pheonix " + Shop.featherPheonix + "x");
                                                    Console.WriteLine("Push any button to go back");

                                                    int inputA = 0;
                                                    do
                                                    {
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }

                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 8 && Shop.enchantingJuice >= 1)
                                                {

                                                    items.Add(Shop.enchantingJuice);
                                                    Console.WriteLine("Enchanting Juices " + Shop.enchantingJuice + "x");
                                                    Console.WriteLine("Push any button to go back");

                                                    int inputA = 0;
                                                    do
                                                    {
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }

                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 9 && Shop.turnaquette >= 1)
                                                {

                                                    items.Add(Shop.turnaquette);
                                                    Console.WriteLine("Turnaquettes " + Shop.turnaquette + "x");
                                                    Console.WriteLine("Push any button to go back");

                                                    int inputA = 0;
                                                    do
                                                    {
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }

                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 10 && Shop.LiquorBottle >= 1)
                                                {

                                                    items.Add(Shop.LiquorBottle);
                                                    Console.WriteLine("Liquor Bottles " + Shop.LiquorBottle + "x");
                                                    Console.WriteLine("Push any button to go back");

                                                    int inputA = 0;
                                                    do
                                                    {
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }

                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 11 && Shop.Soda >= 1)
                                                {

                                                    items.Add(Shop.Soda);
                                                    Console.WriteLine("Sodas " + Shop.Soda + "x");
                                                    Console.WriteLine("Push any button to go back");

                                                    int inputA = 0;
                                                    do
                                                    {
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }

                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 12 && Shop.PackofMagic >= 1)
                                                {

                                                    items.Add(Shop.PackofMagic);
                                                    Console.WriteLine("Pack 'o' Magics " + Shop.PackofMagic + "x");
                                                    Console.WriteLine("Push any button to go back");

                                                    int inputA = 0;
                                                    do
                                                    {
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }

                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 13 && Shop.RegeneratingWater >= 1)
                                                {

                                                    items.Add(Shop.RegeneratingWater);
                                                    Console.WriteLine("Regenerating Waters " + Shop.RegeneratingWater + "x");
                                                    Console.WriteLine("Push any button to go back");

                                                    int inputA = 0;
                                                    do
                                                    {
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }

                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 14 && Shop.SmoothingLotion >= 1)
                                                {

                                                    items.Add(Shop.SmoothingLotion);
                                                    Console.WriteLine("Smoothing Potions " + Shop.SmoothingLotion + "x");
                                                    Console.WriteLine("Push any button to go back");

                                                    int inputA = 0;
                                                    do
                                                    {
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }

                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 15 && Shop.HotBandage >= 1)
                                                {

                                                    items.Add(Shop.HotBandage);
                                                    Console.WriteLine("Hot Bandages " + Shop.HotBandage + "x");
                                                    Console.WriteLine("Push any button to go back");

                                                    int inputA = 0;
                                                    do
                                                    {
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }

                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 16 && Shop.LargeKit >= 1)
                                                {

                                                    items.Add(Shop.LargeKit);
                                                    Console.WriteLine("LargeKits " + Shop.LargeKit + "x");
                                                    Console.WriteLine("Push any button to go back");

                                                    int inputA = 0;
                                                    do
                                                    {
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }

                                                    } while (!Utility.IsReadGood());

                                                }

                                                if (inputW == 17 && Shop.LargePotion >= 1)
                                                {

                                                    items.Add(Shop.LargePotion);
                                                    Console.WriteLine("LargePotions " + Shop.LargePotion + "x");
                                                    Console.WriteLine("Push any button to go back");

                                                    int inputA = 0;
                                                    do
                                                    {
                                                        if (inputA == 4)
                                                        {

                                                            goto case MenuSelect.stats;
                                                        }

                                                        else
                                                        {
                                                            goto case MenuSelect.stats;
                                                        }

                                                    } while (!Utility.IsReadGood());

                                                }

                                                else
                                                {
                                                    goto case MenuSelect.stats;
                                                }
                                            } while (!Utility.IsReadGood());



                                        }//Items Input

                                        else
                                        {
                                            goto case MenuSelect.stats;
                                        }

                                    } while (!Utility.IsReadGood()); //Is Weapon Input an int?


                                } while (!Utility.IsReadGood()); //Is the inventory menu input an int?                                                                                                                    
                            } //Input to access inventory

                            else
                            {
                                Menu();
                            }

                        } while (!Utility.IsReadGood() || input1 > 1 || input1 < 1);// Is inventory input a int?

                        break;




                    case (MenuSelect.shop):
                        int input = 0;
                        do
                        {
                            Console.WriteLine("Welcome to the shop get all your Weapon needs!");
                            Console.WriteLine("1) Weapons");
                            Console.WriteLine("2) Shields");
                            Console.WriteLine("3) Items");
                            Console.WriteLine("Press 4 to go back!");
                            input = Utility.ReadInt();
                        } while (!Utility.IsReadGood());

                        if (input == 1)
                        {
                            Shop.WeaponsMenu();


                        }

                        if (input == 2)
                        {
                            Shop.ShieldsMenu();
                        }

                        if (input == 3)
                        {
                            Shop.ItemsMenu();
                        }

                        if (input == 4)
                        {
                            Menu();
                        }

                        else
                        {
                            goto case (MenuSelect.shop);
                        }

                        break;

                    case (MenuSelect.diffulity):
                        Console.WriteLine("Easy");
                        Console.WriteLine("Medium");
                        Console.WriteLine("Hard");
                        Console.ReadLine();
                        break;

                    case (MenuSelect.endgame):
                        Console.WriteLine("EndGame?");
                        Console.ReadLine();
                        break;


                    default:
                        Console.WriteLine("Try a different input.");
                        Console.ReadLine();
                        break;

                }
            } while (!Utility.IsReadGood());
        }

     public class Shop
        {
            //Weapons
           public static int BronzeSword = 0;
            public static int RuggedAxe = 0;
            public static int BattleWand = 0;
            public static int BookofBeginners = 0;
            public static int BabyFlute = 0;
            public static int insectHormones = 0;
            public static int Mfour = 0;
            public static int SniperRifle = 0;
            public static int grenades = 0;
            public static int claymores = 0;
            public static int rustySabre = 0;
            public static int Flanchard = 0;
            public static int IceBringer = 0;
            public static int spellbinder = 0;
            public static int fairyMace = 0;
            public static int WaterWand = 0;
            public static int airWhisperer = 0;
            public static int EveningStar= 0;
            public static int uzi = 0;
            public static int Twilightlongrifle = 0;
            public static int GrenadeLauncher = 0;
            public static int rocketlauncher = 0;
            public static int AnthraxBomb = 0;
            public static int valyrianSword = 0;
            public static int chanceSword = 0;
            public static int elementalSword = 0;
            public static int gutrender = 0;
            public static int DireDualblade = 0;
            public static int Airtitan = 0;
            public static int rodofconistency = 0;
            public static int rodofsecrets = 0;
            public static int earthrod = 0;
            public static int firerod = 0;
            public static int bookofhealing = 0;
            public static int dragonscroll = 0;
            public static int frostbound= 0;
            public static int DefendersTome = 0;
            public static int shotgun = 0;
            public static int roaringobsidianblaster = 0;
            public static int Peacekiller= 0;
            public static int AK47 = 0;
            public static int Choppa = 0;
            public static int railgun = 0;
            public static int AT4 = 0;
            public static int MissileLauncher = 0;
            public static int silverSword = 0;
            public static int Comrade = 0;
            public static int bookofintermediates = 0;
            public static int tomeofpower = 0;
            public static int waraxe = 0;
            //Items
            public static int Potion = 0;         
            public static int medkit = 0;
            public static int medPotion = 0;
            public static int bottlewine = 0;
            public static int cleansingPowder = 0;
            public static int senzubean = 0;
            public static int featherPheonix = 0;
            public static int enchantingJuice = 0;
            public static int turnaquette = 0;
            public static int LiquorBottle = 0;
            public static int Soda = 0;
            public static int PackofMagic = 0;
            public static int RegeneratingWater = 0;
            public static int SmoothingLotion = 0;
            public static int HotBandage = 0;
            public static int LargeKit = 0;
            public static int LargePotion = 0;
        

            //Armour
            public static int leathervest = 0;
            public static int RoundShield = 0;
            public static int SpikedShield = 0;
            public static int ClearRobe = 0;
            public static int AntFlakRobe = 0;
            public static int Kevlar = 0;
            public static int BallisticVest = 0;
            public static int Chainmail = 0;
           public static int SilverShield = 0;
           public static int  BrickShield = 0;
           public static int  longShield = 0;
            public static int KnightsArmour = 0;
            public static int SilverArmour = 0;
            public static int  FireResRobe = 0;
            public static int  WaterResRobe= 0;
            public static int  AirResRobe = 0;
            public static int  EarthResRobe= 0;
            public static int  RefexRobe= 0;
            public static int  MultiCams= 0;
            public static int  Carbonnanotube= 0;
            public static int Camouflauge = 0;
            public static int Technogear = 0;
            public static int HAZMAT = 0;
            public static int  Fireretarent= 0;
            public static int raingear = 0;   
            static bool Pidgeonhead = false;
           public static List<string> list = new List<string>();
            public static List<string> item = new List<string>();
            static List<string> armour = new List<string>();
            public static void WeaponsMenu()
            {
                int input = 0;
                do
                {
                Console.Clear();
                Console.WriteLine("1) BronzeSword - 2,000 Gold.");
                Console.WriteLine("2) RuggedAxe - 10,000 Gold.");
                Console.WriteLine("3) BattleWand - 5000 gold.");
                Console.WriteLine("4) BookofBeginners - 8,000 gold.");
                Console.WriteLine("5) BabyFlute - 5,000 gold");
                Console.WriteLine("6) insectHormones - 11,000 gold");
                Console.WriteLine("7) M4 - 5,000 gold");
                Console.WriteLine("8) Sniper Rifle - 15,000 gold");
                Console.WriteLine("9) Grenades - 10,000 gold");
                Console.WriteLine("10) Claymores - 17,000 gold");
                    if (Level == 5)
                    {
                    Console.WriteLine("11) RustySabre - 22,000 gold");
                    Console.WriteLine("12) Flanchard - 24,500 gold");
                    Console.WriteLine("13) IceBringer - 26,000 gold");
                    Console.WriteLine("14) Spellbinder - 30,000 gold");
                    Console.WriteLine("15) FairyMace - 32,000 gold");
                    Console.WriteLine("16) WaterWand - 35,000 gold");
                    Console.WriteLine("17) Air Whisperer - 40,000 gold");
                    Console.WriteLine("18) EveningStar - 50,000 gold");
                    Console.WriteLine("19) Uzi - 55,000 gold");
                    }

                    if (Level == 10)
                    {

                    Console.WriteLine("20) Twilight LongRifle - 65,000 gold");
                    Console.WriteLine("21) Grenade Launcher - 100,000 gold");
                    Console.WriteLine("22) Rocket Launcher - 200,000 gold");
                    Console.WriteLine("23) AnthraxBomb - 500,00 gold");
                    Console.WriteLine("24) ChanceSword - 75,000 gold");
                    Console.WriteLine("25) ValyrianSword - 105,000 gold");
                    Console.WriteLine("26) ElementalSword - 80,000 gold");
                    Console.WriteLine("27) GutRender - 50,000 gold");
                    Console.WriteLine("28) Dire DualBlade - 70,000 gold");
                    Console.WriteLine("29) Air Titan - 155,000 gold");
                    Console.WriteLine("30) RodofSecrets - 300,000 gold ");
                    Console.WriteLine("31) RodofConsistency - 220,000 gold");
                    }

                    if (Level == 15)
                    {
                    Console.WriteLine("32) EarthRod - 400,000 gold");
                    Console.WriteLine("33) FireRod - 400,000 gold");
                    Console.WriteLine("34) BookofHealing - 250,000 gold");
                    Console.WriteLine("35) ScrolloftheDragon - 1,000,000 gold");
                    Console.WriteLine("36) FrostBound - 230,000 gold");
                    Console.WriteLine("37) Defenders Tome - 250,000 gold");
                    Console.WriteLine("38) Shotgun - 175,000 gold");
                    Console.WriteLine("39) RoaringObsidiamBlaste - 750,000 gold");
                    Console.WriteLine("40) PeaceKiller - 900,000 gold");
                    Console.WriteLine("41) AK-47 - 300,000 gold");
                    Console.WriteLine("42) Choppa - 600,000 gold");
                    }

                    if (Level == 25)
                    {
                    Console.WriteLine("43) RailGun - 1,200,000 gold");
                    Console.WriteLine("44) AT-4 - 1,300,000 gold");
                    Console.WriteLine("45) Missile Launcher - 1,500,000 gold");
                    Console.WriteLine("46) SilverSword - 100,000 gold");
                    Console.WriteLine("47) Comrade - 950,000 gold");
                    Console.WriteLine("48) WarAxe - 800,000 gold");
                    Console.WriteLine("49) BookofIntermediates - 450,000 gold");
                    Console.WriteLine("50) TomeofPower - 650,000 gold");
                    }
                   
                 input = Utility.ReadInt();
                } while (!Utility.IsReadGood());
                
               
                

                if(input == 1 && BronzeSword ==0 && Gold >= 2000 && swordsmanPicked==true)
                {
                    BronzeSword++;
                    Gold -= 2000;
                    list.Add("1) BronzeSword");
                    Console.WriteLine("You unlocked The BronzeSword! ");
                }

                if (input == 2 && RuggedAxe == 0 && Gold >= 10000 && swordsmanPicked==true)
                {
                    RuggedAxe++;
                    Gold -= 10000;
                    list.Add("2) RuggedAxe");
                    Console.WriteLine("You unlocked the Rugged Axe!");
                }

                if (input == 3 && BattleWand == 0 && Gold >= 5000 && MagePicked == true || input == 3 && BattleWand == 0 && Gold >= 5000 && MonControllerPicked ==true)
                {
                    BattleWand++;
                    Gold -= 5000;
                    list.Add("3) BattleWand");
                    Console.WriteLine("You unlocked the BattleWand!");
                }

                if (input == 4 && BookofBeginners == 0 && Gold >= 8000 && MagePicked == true || input == 4 && BookofBeginners == 0 && Gold >= 8000 && MonControllerPicked == true)
                {
                    BookofBeginners++;
                    Gold -= 8000;
                    list.Add("4) BookofBeginners");
                    Console.WriteLine("You unlocked  the BookofBeginners!");
                }

                if (input == 5 && BabyFlute == 0 && Gold >= 5000 && MonControllerPicked == true)
                {
                    BabyFlute++;
                    Gold -= 5000;
                    list.Add("5) BabyFluke");
                    Console.WriteLine("You unlocked theBabyFlute! ");
                }

                if (input == 6 && insectHormones == 0 && Gold >= 11000 && MonControllerPicked == true)
                {
                    insectHormones++;
                    Gold -= 11000;
                    list.Add("6) insectHormones");
                    Console.WriteLine("You unlocked the insectHormones ");
                }

                if (input == 7 && Mfour ==0 && Gold >= 5000 && GunnerPicked == true)
                {
                    Mfour++;
                    Gold -= 5000;
                    list.Add("7) M4");
                    Console.WriteLine("You unlocked the M4! ");
                }

                if (input == 8 && SniperRifle == 0 && Gold >= 15000 && GunnerPicked == true)
                {
                    SniperRifle++;
                    list.Add("8) Sniper Rifle");
                    Gold -= 15000;
                    Console.WriteLine("You unlocked the SniperRifle!");
                }

                if (input == 9 && grenades ==0 && Gold >= 10000 && GunnerPicked == true || input == 9 && grenades == 0 && Gold >= 10000 && TankerPicked ==true)
                {
                    grenades++;
                    Gold -= 10000;
                    list.Add("9) Grenades");
                    Console.WriteLine("You unlocked the Grenades! ");
                }

                if (input == 10 && claymores == 0 && Gold >= 17000 && GunnerPicked == true || input == 10 && claymores == 0 && Gold >= 17000 && TankerPicked == true)
                {
                    claymores++;
                    Gold -= 17000;
                    list.Add("10) Claymores");
                    Console.WriteLine("You unlocked the Claymores!");
                }

                if (input == 11 && rustySabre==0 && Level >= 5 && Gold >= 22000 && swordsmanPicked == true)
                {
                    rustySabre++;
                    Gold -= 22000;
                    list.Add("11) RustySaber");
                    Console.WriteLine("You unlocked the RustySabre!");
                }

                if (input == 12 && Flanchard ==0 && Level >= 5 && Gold >= 24500 && swordsmanPicked == true)
                {
                    Flanchard++;
                    Gold -= 24500;
                    list.Add("12) Flanchard");
                    Console.WriteLine("You unlocked the Flanchard!");
                }

                if (input == 13 && IceBringer==0 && Level >= 5 && Gold >= 26000 && swordsmanPicked == true)
                {
                    IceBringer++;
                    Gold -= 26000;
                    list.Add("13) IceBringer");
                    Console.WriteLine("You unlocked the IceBringer!");
                }

                if (input == 14 && spellbinder==0 && Level >= 5 && Gold >= 30000 && MagePicked == true || input == 14 && spellbinder == 0 && Level >= 5 && Gold >= 30000 && MonControllerPicked ==true)
                {
                    spellbinder++;
                    Gold -= 30000;
                    list.Add("14) SpellBinder");
                    Console.WriteLine("You unlocked the SpellBinder!");
                }

                if (input == 15 && fairyMace==0 && Level >= 5 && Gold >= 32000 && MagePicked == true || input == 15 && fairyMace == 0 && Level >= 5 && Gold >= 32000 && MonControllerPicked ==true)
                {
                   fairyMace++;
                    Gold -= 32000;
                    list.Add("15) Fairymace");
                    Console.WriteLine("You unlocked the Fairymace!");
                }

                if (input == 16 && WaterWand==0 && Level >= 5 && Gold >= 35000 && MagePicked == true || input == 16 && WaterWand == 0 && Level >= 5 && Gold >= 35000 && MonControllerPicked == true)
                {
                   WaterWand++;
                    Gold -= 35000;
                    list.Add("16) Waterwand");
                    Console.WriteLine("You unlocked the Waterwand!");
                }

                if (input == 17 && airWhisperer==0 && Level >= 5 && Gold >= 40000 && MagePicked == true || input == 17 && airWhisperer == 0 && Level >= 5 && Gold >= 40000 && swordsmanPicked == true)
                {
                    airWhisperer++;
                    Gold -= 40000;
                    list.Add("17) Air Whisperer");
                    Console.WriteLine("You unlocked the Air Whisperer!");
                }

                if (input == 18 && EveningStar ==0 && Level >= 5 && Gold >= 50000 && GunnerPicked == true)
                {
                   EveningStar++;
                    Gold -= 50000;
                    list.Add("18) Evening Star");
                    Console.WriteLine("You unlocked the Evening Star!");
                }

                if (input == 19 && uzi==0 && Level >= 5 && Gold >= 55000 && GunnerPicked == true)
                {
                    uzi++;
                    Gold -= 55000;
                    list.Add("19) Uzi");
                    Console.WriteLine("You unlocked the Uzi!");
                }

                if (input == 20 && Twilightlongrifle==0 && Level >= 10 && Gold >= 65000 && GunnerPicked == true)
                {
                    Twilightlongrifle++;
                    Gold -= 65000;
                    list.Add("20) Twilight LongRifle");
                    Console.WriteLine("You unlocked the Twilight LongRifle!");
                }

                if (input == 21 && GrenadeLauncher == 0 && Level >= 10 && Gold >= 100000 && GunnerPicked == true)
                {
                    GrenadeLauncher++;
                    Gold -= 100000;
                    list.Add("21) Grenade Launcher");
                    Console.WriteLine("You unlocked the Grenade Launcher!");
                }

                if (input == 22 && rocketlauncher == 0 && Level >= 10 && Gold >= 200000 && GunnerPicked == true || input == 22 && rocketlauncher == 0 && Level >= 10 && Gold >= 200000 && TankerPicked ==true)
                {
                    rocketlauncher++;
                    Gold -= 200000;
                    list.Add("22) Rocket Launcher");
                    Console.WriteLine("You unlocked the Rocket Launcher!");
                }

                if (input == 23 && AnthraxBomb == 0 && Level >= 10 && Gold >= 500000 && GunnerPicked==true || input == 23 && AnthraxBomb == 0 && Level >= 10 && Gold >= 500000 && TankerPicked ==true)
                {
                    AnthraxBomb++;
                    Gold -= 500000;
                    list.Add("23) Anthrax Bomb");
                    Console.WriteLine("You unlocked the Anthrax Bomb!");
                }

                if (input == 24 && chanceSword == 0 && Level >= 10 && Gold >= 75000 && swordsmanPicked==true)
                {
                    chanceSword++;
                    Gold -= 75000;
                    list.Add("24) Chance Sword");
                    Console.WriteLine("You unlocked the Chance Sword!");
                }

                if (input == 25 && valyrianSword == 0 && Level >= 10 && Gold >= 105000 && swordsmanPicked == true)
                {
                    valyrianSword++;
                    Gold -= 105000;
                    list.Add("25) Valyrian Sword");
                    Console.WriteLine("You unlocked the Valyrian Sword!");
                }

                if (input == 26 && elementalSword == 0 && Level >= 10 && Gold >= 80000 && swordsmanPicked == true)
                {
                    elementalSword++;
                    Gold -= 80000;
                    list.Add("26) Elemenatal Sword");
                    Console.WriteLine("You unlocked the Elemental Sword");
                }

                if (input == 27 && gutrender == 0 && Level >= 10 && Gold >= 50000 && swordsmanPicked == true)
                {
                    gutrender++;
                    Gold -= 50000;
                    list.Add("27) GutRender");
                    Console.WriteLine("You unlocked the GutRender!");
                }

                if (input == 28 && DireDualblade == 0 && Level >= 10 && Gold >= 70000 && swordsmanPicked == true)
                {
                    DireDualblade++;
                    Gold -= 70000;
                    list.Add("28) Dire - DualBlade");
                    Console.WriteLine("You unlocked the Dire - DualBlade!");
                }

                if (input == 29 && Airtitan == 0 && Level >= 10 && Gold >= 155000 && swordsmanPicked == true)
                {
                    Airtitan++;
                    Gold -= 155000;
                    list.Add("29) Air Titan");
                    Console.WriteLine("You unlocked the Air Titan!");
                }

                if (input == 30 && rodofsecrets == 0 && Level >= 10 && Gold >= 300000 && MagePicked == true || input == 30 && rodofsecrets == 0 && Level >= 10 && Gold >= 300000 && MonControllerPicked ==true)
                {
                    rodofsecrets++;
                    Gold -= 300000;
                    list.Add("30) Rod of Secrets");
                    Console.WriteLine("You unlocked the Rod of Secrets!");
                }

                if (input == 31 && rodofconistency == 0 && Level >= 10 && Gold >= 220000 && MagePicked == true || input == 31 && rodofconistency == 0 && Level >= 10 && Gold >= 220000 && MonControllerPicked == true)
                {
                    rodofconistency++;
                    Gold -= 220000;
                    list.Add("31) Rod of Consistency");
                    Console.WriteLine("You unlocked the Rod of Consistency!");
                }

                if (input == 32 && silverSword == 0 && Level >= 25 && Gold >= 100000 && swordsmanPicked==true)
                {
                    silverSword++;
                    Gold -= 100000;
                    list.Add("32) SilverSword");
                    Console.WriteLine("You unlocked the SilverSword!");
                }

                if (input == 33 && earthrod == 0 && Level >= 15 && Gold >= 400000 && MagePicked == true || input == 33 && earthrod == 0 && Level >= 15 && Gold >= 400000 && MonControllerPicked == true)
                {
                    earthrod++;
                    Gold -= 400000;
                    list.Add("33) Earthrod");
                    Console.WriteLine("You unlocked the Earthrod!");
                }

                if (input == 34 && firerod == 0 && Level >= 15 && Gold >= 400000 && MagePicked == true || input == 34 && firerod == 0 && Level >= 15 && Gold >= 400000 && MonControllerPicked == true)
                {
                    firerod++;
                    Gold -= 400000;
                    list.Add("34) Firerod");
                    Console.WriteLine("You unlocked the Firerod!");
                }

                if (input == 35 && bookofhealing == 0 && Level >= 15 && Gold >= 250000 && MagePicked == true || input == 35 && bookofhealing == 0 && Level >= 15 && Gold >= 250000 && MonControllerPicked == true)
                {
                    bookofhealing++;
                    Gold -= 250000;
                    list.Add("35) Book of Healing");
                    Console.WriteLine("You unlocked the Book of Healing!");
                }

                if (input == 36 && dragonscroll == 0 && Level >= 15 && Gold >= 1000000 && MagePicked == true || input == 36 && dragonscroll == 0 && Level >= 15 && Gold >= 1000000 && MonControllerPicked == true)
                {
                    dragonscroll++;
                    Gold -= 1000000;
                    list.Add("36) Scroll of the Dragon");
                    Console.WriteLine("You unlocked the Scroll of the Dragon!");
                }

                if (input == 37 && frostbound == 0 && Level >= 15 && Gold >= 230000 && MagePicked == true || input == 37 && frostbound == 0 && Level >= 15 && Gold >= 230000 && swordsmanPicked == true)
                {
                    frostbound++;
                    Gold -= 230000;
                    list.Add("37) FrostBound");
                    Console.WriteLine("You unlocked the FrostBound!");
                }

                if (input == 38 && DefendersTome == 0 && Level >= 15 && Gold >= 250000 && MagePicked == true)
                {
                    DefendersTome++;
                    Gold -= 250000;
                    list.Add("38) Defender's Tome");
                    Console.WriteLine("You unlocked the Defender's Tome!");
                }

                if (input == 39 && shotgun == 0 && Level >= 15 && Gold >= 175000 && GunnerPicked==true)
                {
                    shotgun++;
                    Gold -= 175000;
                    list.Add("39) Shotgun");
                    Console.WriteLine("You unlocked the Shotgun!");
                }

                if (input == 40 && roaringobsidianblaster == 0 && Level >= 15 && Gold >= 750000 && GunnerPicked==true)
                {
                    roaringobsidianblaster++;
                    Gold -= 750000;
                    list.Add("40) Roaring Obsidian Blaster");
                    Console.WriteLine("You unlocked the Roaring Obsidian Blaster!");
                }

                if (input == 41 && Peacekiller== 0 && Level >= 15 && Gold >= 900000 && GunnerPicked==true)
                {
                   Peacekiller++;
                    Gold -= 900000;
                    list.Add("41) PeaceKiller");
                    Console.WriteLine("You unlocked the PeaceKiller!");
                }

                if (input == 42 && AK47 == 0 && Level >= 15 && Gold >= 300000 && GunnerPicked==true)
                {
                    AK47++;
                    Gold -= 300000;
                    list.Add("42) AK-47");
                    Console.WriteLine("AK-47!");
                }


                if (input == 43 && Choppa == 0 && Level >= 25 && Gold >= 600000 && GunnerPicked == true || input == 43 && Choppa == 0 && Level >= 25 && Gold >= 600000 && TankerPicked == true)
                {
                    Choppa++;
                    Gold -= 600000;
                    list.Add("43) Choppa");
                    Console.WriteLine("You unlocked the Choppa!!!");
                }

                if (input == 44 && railgun== 0 && Level >= 25 && Gold >= 1200000 && TankerPicked == true)
                {
                    railgun++;
                    Gold -= 1200000;
                    list.Add("44) Railgun");
                    Console.WriteLine("You unlocked the Railgun!");
                }

                if (input == 45 && AT4 == 0 && Level >= 25 && Gold >= 1300000 && GunnerPicked == true || input == 45 && AT4 == 0 && Level >= 25 && Gold >= 1300000 && TankerPicked == true)
                {
                    AT4++;
                    Gold -= 1300000;
                    list.Add("45) AT-4");
                    Console.WriteLine("You unlocked the AT-4!");
                }

                if (input == 46 && MissileLauncher == 0 && Level >= 25 && Gold >= 1500000 && TankerPicked == true)
                {
                    MissileLauncher++;
                    Gold -= 1500000;
                    list.Add("46) Missile Launcher");
                    Console.WriteLine("You unlocked the Missile Launcher!");
                }

                if (input == 47 && waraxe == 0 && Level >= 25 && Gold >= 950000 && swordsmanPicked==true)
                {
                    waraxe++;
                    Gold -= 950000;
                    list.Add("47) WarAxe");
                    Console.WriteLine("You unlocked the WarAxe!");
                }

                if (input == 48 && bookofintermediates == 0 && Level >= 25 && Gold >= 800000 && MagePicked == true || MonControllerPicked == true)
                {
                    bookofintermediates++;
                    Gold -= 800000;
                    list.Add("48) Book of Intermediates");
                    Console.WriteLine("You unlocked the Book of Intermediates!");
                }

                if (input == 49 && Comrade == 0 && Level >= 25 && Gold >= 450000 && swordsmanPicked==true)
                {
                    Comrade++;
                    Gold -= 450000;
                    list.Add("49) Comrade");
                    Console.WriteLine("You unlocked the Comrade!");
                }

                if (input == 50 && tomeofpower == 0 && Level >= 25 && Gold >= 650000 && MagePicked == true || MonControllerPicked == true)
                {
                    gutrender++;
                    Gold -= 650000;
                    list.Add("50) Tome of Power");
                    Console.WriteLine("You unlocked the Tome of Power!");
                }


               


                Console.ReadLine();
               
               

            }
            public static void ConvertWeapons(ref int damage)
            {
                if(BronzeSword >= 1)
                {
                    equip.Clear();  
                   BronzeSword=  Atk + Weapons.BronzeSword.BSword;                                
                    equip.Add(BronzeSword);
                    
                    

                }

                if (RuggedAxe >= 1)
                {
                    equip.Clear();
                    RuggedAxe= Program.Atk + Weapons.RuggedAxe.ruggedaxe;
                    equip.Add(RuggedAxe);
                }

                if (BattleWand == 1)
                {
                    equip.Clear();
                    BattleWand = Program.Atk + Battlewand.battlewand;
                    equip.Add(BattleWand);
                }

                if (BookofBeginners == 1)
                {
                    equip.Clear();
                    BookofBeginners = Program.Atk + Weapons.BookofBeginners.book;
                    equip.Add(BookofBeginners);
                }

                if (BabyFlute == 1)
                {
                    equip.Clear();
                    BabyFlute = Program.Atk + Weapons.BabyFlute.flute;
                    equip.Add(BabyFlute);
                }

                if (insectHormones == 1)
                {
                    equip.Clear();
                    insectHormones = Program.Atk + Weapons.InsectHormones.insectbag;
                    equip.Add(insectHormones);
                }

                if (Mfour >= 1)
                {
                    equip.Clear();
                    Mfour = Program.Atk + Weapons.MFour.mfour;
                    equip.Add(Mfour);
                }

                if (SniperRifle >= 1)
                {
                    equip.Clear();
                    SniperRifle = Program.Atk + Weapons.SniperRifle.bullet;
                    equip.Add(SniperRifle);
                }

                if (grenades >= 1)
                {
                    equip.Clear();
                    grenades = Program.Atk + Weapons.Grenades.grenade;
                    equip.Add(grenades);
                }

                if (claymores >= 1)
                {
                    equip.Clear();
                    claymores = Program.Atk + Weapons.Claymores.claymore;
                    equip.Add(claymores);
                }

                if (rustySabre >= 1)
                {
                    equip.Clear();
                    rustySabre = Program.Atk + RustySaber.rustysaber;
                    equip.Add(rustySabre);
                }

                if (Flanchard >= 1)
                {
                    equip.Clear();
                    Flanchard = Program.Atk + Weapons.Flanchard.flanchard;
                    equip.Add(Flanchard);
                }

                if (IceBringer == 1)
                {
                    equip.Clear();
                    IceBringer = Program.Atk + Weapons.IceBringer.icebringer;
                    equip.Add(IceBringer);
                }

                if (spellbinder == 1)
                {
                    equip.Clear();
                    spellbinder = Program.Atk + Weapons.SpellBinder.rod;
                    equip.Add(spellbinder);
                }

                if (fairyMace == 1)
                {
                    equip.Clear();
                    fairyMace = Program.Atk + FairyMace.fairymace;
                    equip.Add(fairyMace);
                }

                if (WaterWand == 1)
                {
                    equip.Clear();
                    WaterWand = Program.Atk + Weapons.Waterwand.waterwand;
                    equip.Add(WaterWand);
                }

                if (airWhisperer == 1)
                {
                    equip.Clear();
                    airWhisperer = Program.Atk + Weapons.AirWhisperer.whisperer;
                    equip.Add(airWhisperer);
                }

                if (EveningStar == 1)
                {
                    equip.Clear();
                    EveningStar = Program.Atk + Weapons.EveningStar.eveningstar;
                    equip.Add(EveningStar);
                }

                if (uzi == 1)
                {
                    equip.Clear();
                    uzi = Program.Atk + Weapons.Uzi.uzi;
                    equip.Add(uzi);
                }

                if (Twilightlongrifle == 1)
                {
                    equip.Clear();
                    Twilightlongrifle = Program.Atk * Twilightlongrifle;
                    equip.Add(Twilightlongrifle);
                }

                if (GrenadeLauncher == 1)
                {
                    equip.Clear();
                    GrenadeLauncher = Program.Atk + Weapons.GrenadeLauncher.Glauncher;
                    equip.Add(GrenadeLauncher);
                }

                if (AnthraxBomb == 1)
                {
                    equip.Clear();
                    AnthraxBomb = Program.Atk + Weapons.AnthraxBomb.Anthraxbomb;
                    equip.Add(AnthraxBomb);
                }

                if (chanceSword == 1)
                {
                    equip.Clear();
                    chanceSword = Program.Atk + ChanceSword.chancesword;
                    equip.Add(chanceSword);
                }

                if (valyrianSword == 1)
                {
                    equip.Clear();
                    valyrianSword = Program.Atk + Weapons.ValyrianSword.valyriansword;
                    equip.Add(valyrianSword);
                }

                if (elementalSword == 1)
                {
                    equip.Clear();
                    elementalSword = Program.Atk + ElementalSword.elemsword;
                    equip.Add(elementalSword);
                }

                if (gutrender == 1)
                {
                    equip.Clear();
                    gutrender = Program.Atk + GutRender.gutrender;
                    equip.Add(gutrender);
                }

                if (DireDualblade == 1)
                {
                    equip.Clear();
                    DireDualblade = Program.Atk + Weapons.DireDualblade.dualblade;
                    equip.Add(DireDualblade);
                }

                if (Airtitan == 1)
                {
                    equip.Clear();
                    Airtitan = Program.Atk + Weapons.AirTitan.airtitan;
                    equip.Add(Airtitan);
                }

                if (rodofsecrets == 1)
                {
                    equip.Clear();
                    rodofsecrets = Program.Atk + RodofSecrets.rodofS;
                    equip.Add(rodofsecrets);
                }

                if (rodofconistency == 1)
                {
                    equip.Clear();
                    rodofconistency = Program.Atk + Weapons.RodofConsistency.rodofConsistency;
                    equip.Add(rodofconistency);
                }

                if (earthrod == 1)
                {
                    equip.Clear();
                    earthrod = Program.Atk + Weapons.EarthRod.rodEarth;
                    equip.Add(earthrod);
                }


                if (firerod== 1)
                {
                    equip.Clear();
                    firerod = Program.Atk + Weapons.FireRod.firerod;
                    equip.Add(firerod);
                }

                if (bookofhealing== 1)
                {
                    equip.Clear();
                    bookofhealing = Program.Atk * bookofhealing;
                    equip.Add(bookofhealing);
                }

                if (dragonscroll == 1)
                {
                    equip.Clear();
                   dragonscroll = Program.Atk * dragonscroll;
                    equip.Add(dragonscroll);
                }

                if (frostbound == 1)
                {
                    equip.Clear();
                    frostbound = Program.Atk * frostbound;
                    equip.Add(frostbound);
                }

                if (DefendersTome == 1)
                {
                    equip.Clear();
                    DefendersTome = Program.Atk * DefendersTome;
                    equip.Add(DefendersTome);
                }

                if (shotgun == 1)
                {
                    equip.Clear();
                    shotgun = Program.Atk * shotgun;
                    equip.Add(shotgun);
                }

                if (roaringobsidianblaster == 1)
                {
                    equip.Clear();
                    roaringobsidianblaster = Program.Atk *=roaringobsidianblaster;
                    equip.Add(roaringobsidianblaster);
                }

                if (Peacekiller == 1)
                {
                    equip.Clear();
                   Peacekiller = Program.Atk * Peacekiller;
                    equip.Add(Peacekiller);
                }

                if (AK47 == 1)
                {
                    equip.Clear();
                    AK47 = Program.Atk *AK47;
                    equip.Add(AK47);
                }

                if (Choppa == 1)
                {
                    equip.Clear();
                    Choppa = Program.Atk * Choppa;
                    equip.Add(Choppa);
                }

                if (railgun == 1)
                {
                    equip.Clear();
                    railgun = Program.Atk * railgun;
                    equip.Add(railgun);
                }

                if (AT4 == 1)
                {
                    equip.Clear();
                    AT4 = Program.Atk * AT4;
                    equip.Add(AT4);
                }

                if (MissileLauncher == 1)
                {
                    equip.Clear();
                    MissileLauncher = Program.Atk * MissileLauncher;
                    equip.Add(MissileLauncher);
                }

                if (silverSword == 1)
                {
                    equip.Clear();
                    silverSword = Program.Atk * silverSword;
                    equip.Add(silverSword);
                }

                if (Comrade == 1)
                {
                    equip.Clear();
                    Comrade = Program.Atk * Comrade;
                    equip.Add(Comrade);
                }

                if (waraxe == 1)
                {
                    equip.Clear();
                   waraxe = Program.Atk * waraxe;
                    equip.Add(waraxe);
                }

                if (bookofintermediates == 1)
                {
                    equip.Clear();
                    bookofintermediates = Program.Atk * bookofintermediates;
                    equip.Add(bookofintermediates);
                }

                if (tomeofpower == 1)
                {
                    equip.Clear();
                    tomeofpower = Program.Atk * tomeofpower;
                    equip.Add(tomeofpower);
                }

             

            }

            public static void ConvertItem()
            {
                if (Potion >= 1)
                {
                    list.Add("1) Potion");
                    items.Add(Potion);
                    Console.WriteLine("1) Potion" + Potion + " x");
                   
                }

                if (medkit >= 1)
                {
                    list.Add("2) MedKits");
                    items.Add(medkit);
                    Console.WriteLine("2) MedKits" + medkit + " x");

                }

                if (medPotion >= 1)
                {
                    list.Add("3) medPotion");
                    items.Add(medPotion);
                    Console.WriteLine("3) MedPotion" + medPotion + " x");

                }

                if (bottlewine >= 1)
                {
                    list.Add("4) bottlewine");
                    items.Add(bottlewine);
                    Console.WriteLine("4) Bottles of Wine" + Potion + " x");

                }

                if (cleansingPowder >= 1)
                {
                    list.Add("5) cleansing Powder");
                    items.Add(cleansingPowder);
                    Console.WriteLine("5) CleansingPowder" + cleansingPowder + " x");

                }

                if (senzubean >= 1)
                {
                    list.Add("6) Beans of Senzu");
                    items.Add(senzubean);
                    Console.WriteLine("6) Bean of a Senzu" + senzubean + " x");

                }

                if (featherPheonix >= 1)
                {
                    list.Add("7) Feathers of the Pheonix");
                    items.Add(featherPheonix);
                    Console.WriteLine("7) Feather of the Pheonix" + featherPheonix + " x");

                }

                if (enchantingJuice >= 1)
                {
                    list.Add("8) Enchanting Juice");
                    items.Add( enchantingJuice);
                    Console.WriteLine("8) Enchanting Juice" + enchantingJuice + " x");

                }

                if (turnaquette >= 1)
                {
                    list.Add("9) Turnaquettes");
                    items.Add(turnaquette);
                    Console.WriteLine("9) Turnaquette" + turnaquette + " x");

                }


                if (LiquorBottle >= 1)
                {
                    list.Add("10) Liquor Bottle");
                    items.Add(LiquorBottle);
                    Console.WriteLine("10) Liquor Bottles" + LiquorBottle + " x");

                }


                if (Soda >= 1)
                {
                    list.Add("11) Soda");
                    items.Add(Soda);
                    Console.WriteLine("11) Soda" + Soda + " x");

                }


                if (PackofMagic >= 1)
                {
                    list.Add("12) Pack '0' Magic");
                    items.Add(PackofMagic);
                    Console.WriteLine("12) Pack 'o' Magic" + PackofMagic + " x");

                }


                if (RegeneratingWater >= 1)
                {
                    list.Add("13) Regenerating Water");
                    items.Add(RegeneratingWater);
                    Console.WriteLine("13) Regenerating" + RegeneratingWater + " x");

                }


                if (SmoothingLotion >= 1)
                {
                    list.Add("14) Smoothing Lotion");
                    items.Add(SmoothingLotion);
                    Console.WriteLine("14) Smoothing Lotion" + SmoothingLotion + " x");

                }


                if (HotBandage >= 1)
                {
                    list.Add("15) Hot Bandages");
                    items.Add(HotBandage);
                    Console.WriteLine("15) Hot Bandages" + HotBandage + " x");

                }


                if (LargeKit >= 1)
                {
                    list.Add("16) LargeKit");
                    items.Add(LargeKit);
                    Console.WriteLine("16) LargeKit" + LargeKit + " x");

                }


                if (LargePotion >= 1)
                {
                    list.Add("17) LargePotion");
                    items.Add(LargePotion);
                    Console.WriteLine("17) LargePotion" + LargePotion + " x");

                }

            }
            public static int ItemAmount(int amount)
            {
                int current = 0;
                amount += current;

                return amount;

            }

            public static void ShieldsMenu()
            {
                int input = 0;
                do {
                Console.Clear();
                Console.WriteLine("1) LeatherVest - 100 Gold");            
                Console.WriteLine("2) RoundShield - 500 Gold.");
                Console.WriteLine("3) SpikedShield - 4,500 Gold.");
                Console.WriteLine("4) ClearRobe - 6,000 gold.");
                Console.WriteLine("5) Anti-Flak Robe - 3,500 gold.");
                Console.WriteLine("6) Kevlar - 3,000 gold");
                Console.WriteLine("7) BallisticVest - 8,000 gold");
                    //Level UP Shields
                    if(Level >= 5)
                    {
                Console.WriteLine("8) ChainMail - 7,000 gold");
                Console.WriteLine("9) SilverShield - 40,000 gold");
                Console.WriteLine("10) BrickShield - 10,000 gold");
                Console.WriteLine("11) LongShield - 8,500 gold");
                    }


                    if (Level >= 8)
                    {
                        Console.WriteLine("12) Knight's Armour - 17,000 gold");
                Console.WriteLine("13) Silver Armour- 12,000 gold");
                Console.WriteLine("14) Fire Resistant Robe - 20,000 gold");
                Console.WriteLine("15) Water Resistant Robe - 20,000 gold");
                Console.WriteLine("16) Air Resistant Robe - 20,000 gold");
                Console.WriteLine("17) Earth Resistant Robe- 20,000 gold");
                    }

                    if (Level >= 15)
                    {
                         Console.WriteLine("18) ReflexRobe - 70,000 gold");
                Console.WriteLine("19) Multi-Cams - 17,000 gold");
                Console.WriteLine("20) Carbon Nanotube Suit = 150,000");
                Console.WriteLine("21) Camouflage - 25,000 gold");
                Console.WriteLine("22) HazMat Suit - 45,000 gold");
                    }

                    if (Level >= 20)
                    {
                Console.WriteLine("23) Technician Gear - 20,000 gold");
                Console.WriteLine("24) Fire Retardent Suit - 25,00 gold");
                Console.WriteLine("25) Rain Gear - 10,000 gold");
                    }
               
                    input = Utility.ReadInt();
                } while (!Utility.IsReadGood());
                  
                  if (input == 1 && leathervest==0 && Gold >= 100)
                {
                    leathervest++;
                    armour.Add("1) LeatherVest");
                    Console.WriteLine("You unlocked the Leathervest!");
                }          

                if(input ==2 && RoundShield == 0 && Gold>=500)
                {
                    RoundShield++;
                    armour.Add("2) RoundShield");
                    Console.WriteLine("You unlocked the RoundShield");
                }

                if (input == 3 && SpikedShield == 0 && Gold >= 4500)
                {
                    SpikedShield++;
                    armour.Add("3) SpikedShield");
                    Console.WriteLine("You unlocked the SpikedShield");
                }

                if (input == 4 && ClearRobe == 0 && Gold >= 6000)
                {
                    ClearRobe++;
                    armour.Add("4) ClearRobe");
                    Console.WriteLine("You unlocked the ClearRobe");
                }

                if (input == 5 && AntFlakRobe== 0 && Gold >= 3500)
                {
                    AntFlakRobe++;
                    armour.Add("5) Anti-FlakRobe");
                    Console.WriteLine("You unlocked the Anti-FlakRobe");
                }

                if (input == 6 && Kevlar == 0 && Gold >= 3000)
                {
                    Kevlar++;
                    armour.Add("6) Kevlar");
                    Console.WriteLine("You unlocked the Kevlar");
                }

                if (input == 7 && BallisticVest == 0 && Gold >= 8000)
                {
                    BallisticVest++;
                    armour.Add("7) BallisticVest");
                    Console.WriteLine("You unlocked the BallisticVest");
                }

                if (input == 8 && Chainmail == 0 && Gold >= 7000 && Level>=5)
                {
                    Chainmail++;
                    armour.Add("8) Chainmail");
                    Console.WriteLine("You unlocked the Chainmail");
                }

                if (input == 9 && SilverShield == 0 && Gold >= 40000 && Level >= 5)
                {
                    SilverShield++;
                    armour.Add("9) SilverSword");
                    Console.WriteLine("You unlocked the SilverSword");
                }

                if (input == 10 && BrickShield == 0 && Gold >= 10000 && Level >= 5)
                {
                    BrickShield++;
                    armour.Add("10) BrickShield");
                    Console.WriteLine("You unlocked BrickSword");
                }

                if (input == 11 && longShield == 0 && Gold >= 8500 && Level >= 5)
                {
                    longShield++;
                    armour.Add("11) longShield");
                    Console.WriteLine("You unlocked the longSword");
                }

                if (input == 12 && KnightsArmour == 0 && Gold >= 17000 && Level >= 8)
                {
                    KnightsArmour++;
                    armour.Add("12) Knight's Armour");
                    Console.WriteLine("You unlocked the Knight's Armour");
                }

                if (input == 13 &&  FireResRobe== 0 && Gold >= 20000 && Level >= 8)
                {
                    FireResRobe++;
                    armour.Add("13) Fire Resistant Robe");
                    Console.WriteLine("You unlocked the Fire Resistant Robe");
                }

                if (input == 14 && WaterResRobe == 0 && Gold >= 20000 && Level >= 8)
                {
                    WaterResRobe++;
                    armour.Add("14) Water Resistance Robe");
                    Console.WriteLine("You unlocked the Water Resistance Robe");
                }

                if (input == 15 && AirResRobe == 0 && Gold >= 20000 && Level >= 8)
                {
                    AirResRobe++;
                    armour.Add("15) Air Resistance Robe");
                    Console.WriteLine("You unlocked the Air Resistance Robe");
                }

                if (input == 16 && EarthResRobe == 0 && Gold >= 20000 && Level >= 8)
                {
                    EarthResRobe++;
                    armour.Add("16) Earth Resistance Robe");
                    Console.WriteLine("You unlocked the Earth Resistance Robe");
                }

                if (input == 17 && RefexRobe == 0 && Gold >= 70000 && Level >= 15)
                {
                    RefexRobe++;
                    armour.Add("17) Reflex Robe");
                    Console.WriteLine("You unlocked the Reflex Robe");
                }

                if (input == 18 && MultiCams == 0 && Gold >= 17000 && Level >= 15)
                {
                    MultiCams++;
                    armour.Add("18) Multi-Cams");
                    Console.WriteLine("You unlocked the Multi-Cams");
                }


                if (input == 19 && Carbonnanotube == 0 && Gold >= 150000 && Level >= 15)
                {
                    Carbonnanotube++;
                    armour.Add("19) Carbon-NanoTube Suit");
                    Console.WriteLine("You unlocked the Carbon NanoTube Suit");
                }

                if (input == 20 && Camouflauge== 0 && Gold >= 25000 && Level >= 15)
                {
                    Camouflauge++;
                    armour.Add("20) Camoflauge");
                    Console.WriteLine("You unlocked the Camoflauge");
                }

                if (input == 21 && HAZMAT == 0 && Gold >= 15000 && Level >= 15)
                {
                    HAZMAT++;
                    armour.Add("21) HAZMAT Suit");
                    Console.WriteLine("You unlocked the HAZMAT suit");
                }

                if (input == 22 &&  Technogear== 0 && Gold >= 20000 && Level >= 20)
                {
                    Technogear++;
                    armour.Add("22) Technician Gear");
                    Console.WriteLine("You unlocked the Technician Gear");
                }

                if (input == 23 && Fireretarent == 0 && Gold >= 25000 && Level >= 20)
                {
                    Fireretarent++;
                    armour.Add("23 )Fire Retardent Suit");
                    Console.WriteLine("You unlocked the Fire Retardent Suit");
                }

                if (input == 24 && raingear == 0 && Gold >= 10000 && Level >= 20)
                {
                    raingear++;
                    armour.Add("24) Raingear");
                    Console.WriteLine("You unlocked the Raingear");
                }

                Console.WriteLine("Press any button to go back");
                Console.ReadLine();
                
            }

            public static void ItemsMenu()
            {
                int input = 0;
                do
                {
                Console.Clear();
                Console.WriteLine("1) Potion - 200 Gold.");
                Console.WriteLine("2) Med-Kit - 1,000 Gold.");
                Console.WriteLine("3) Med-Potion - 1,200 gold.");
                    if (Level >= 6)
                    {
                Console.WriteLine("4) Bottle of Wine - 1,500 gold.");
                Console.WriteLine("5) Cleansing Powder - 3,000 gold");
                Console.WriteLine("6) Bean of the Senzu! - 10,000 gold");
                    }

                    if (Level >= 12)
                    {
                Console.WriteLine("7) Feather of the Pheonix - 20,000 gold");
                Console.WriteLine("8) Enchanting Juice - 1,200 gold");
                Console.WriteLine("9) Turnaquettes - 2,000 gold");
                    }

                    if (Level >= 18)
                    {
                Console.WriteLine("10) LiquorBottle- 2,000 gold");
                Console.WriteLine("11) Soda - 400 gold");
                Console.WriteLine("12)Pack 'o' MAgic - 17,000 gold");
                Console.WriteLine("13)Regenerating Water  - 17,000 gold");
                    }

                    if (Level >= 25)
                    {
                Console.WriteLine("14) Soothing Lotion - 2,000 gold");
                Console.WriteLine("15) Hot Bandage - 2,000 gold");
                Console.WriteLine("16) Large-Kit - 5,000 gold");
                Console.WriteLine("17) Large Potion - 7,000 gold");

                    }

                 
                    input = Utility.ReadInt();
                } while (!Utility.IsReadGood());

              
                if (input == 1)
                {
                    int count1 = 0;
                    do {

                      Console.WriteLine("How many do you want?");
                        count1 = Utility.ReadInt();
                    
                        if (count1 > 0 && Gold > count1*200)
                        {
                                do {

                            Potion = ItemAmount(count1);
                            Console.WriteLine("Is this how much you want? " + ItemAmount(count1) + "?");
                            Console.WriteLine(" y "+ "or" + " n ?");
                            string answer = Convert.ToString(Console.ReadLine());
                            if (answer == "y")
                            {
                                    Console.WriteLine("You bought " + Potion + " Potions.");
                                item.Add("1) Potions " + Potion + "x");
                                        
                                        Gold -= (count1 * 200);
                              
                               


                            }

                                
                           else
                        {
                            Console.WriteLine("Not enough Money...");
                            
                        }
                              } while (!Utility.IsReadGood());
                        }

                        
                    } while (!Utility.IsReadGood());
                    Console.ReadLine();
                }

                if (input == 2)
                {
                    int count1 = 0;
                    do
                    {

                        Console.WriteLine("How many do you want?");
                        count1 = Utility.ReadInt();
                        {
                            if (count1 > 0 && Gold > count1 * 1000)
                            {
                                do
                                {

                                    medkit = ItemAmount(count1);
                                    Console.WriteLine("Is this how much you want? " + ItemAmount(count1) + "?");
                                    Console.WriteLine(" y " + "or" + " n ?");
                                    string answer = Convert.ToString(Console.ReadLine());
                                    if (answer == "y")
                                    {
                                        Gold -= (count1 * 1000);
                                        item.Add("1) MedKits" + medkit + "x");
                                        Console.WriteLine("You bought " + medkit + " medkits.");
                                    }

                                } while (!Utility.IsReadGood());


                            }

                            else
                            {
                                Console.WriteLine("Not enough Money...");

                            }
                        }

                    } while (!Utility.IsReadGood());
                    Console.ReadLine();
                }


                if (input == 3)
                {
                    int count1 = 0;
                    do
                    {

                        Console.WriteLine("How many do you want?");
                        count1 = Utility.ReadInt();
                        
                            if (count1 > 0 && Gold > count1 * 1200)
                            {
                                do
                                {

                                   medPotion = ItemAmount(count1);
                                    Console.WriteLine("Is this how much you want? " + ItemAmount(count1) + "?");
                                    Console.WriteLine(" y " + "or" + " n ?");
                                    string answer = Convert.ToString(Console.ReadLine());
                                    if (answer == "y")
                                    {
                                        Gold -= (count1 * 1200);
                                        item.Add("1) MedPotion " + medPotion + "x");
                                        Console.WriteLine("You bought " + medPotion + " MedPotion.");
                                    }

                                } while (!Utility.IsReadGood());


                            }
                       

                           else
                            {
                            Console.WriteLine("Not enough Money...");

                        }

                    } while (!Utility.IsReadGood());
                    Console.ReadLine();
                }


                if (input == 4)
                {
                    int count1 = 0;
                    do
                    {

                        Console.WriteLine("How many do you want?");
                        count1 = Utility.ReadInt();
                        {
                            if (count1 > 0 && Gold > count1 * 1500)
                            {
                                do
                                {

                                    bottlewine = ItemAmount(count1);
                                    Console.WriteLine("Is this how much you want? " + ItemAmount(count1) + "?");
                                    Console.WriteLine(" y " + "or" + " n ?");
                                    string answer = Convert.ToString(Console.ReadLine());
                                    if (answer == "y")
                                    {
                                        Gold -= (count1 * 1500);
                                        item.Add("1) Battle of Wine " + bottlewine + "x");
                                        Console.WriteLine("You bought " + bottlewine + " Bottles of Wine.");



                                    }

                                } while (!Utility.IsReadGood());


                            }

                            else
                            {
                                Console.WriteLine("Not enough Money...");

                            }
                        }

                    } while (!Utility.IsReadGood());
                    Console.ReadLine();
                }

                if (input == 5)
                {
                    int count1 = 0;
                    do
                    {

                        Console.WriteLine("How many do you want?");
                        count1 = Utility.ReadInt();
                        {
                            if (count1 > 0 && Gold > count1 * 3000)
                            {
                                do
                                {

                                    cleansingPowder = ItemAmount(count1);
                                    Console.WriteLine("Is this how much you want? " + ItemAmount(count1) + "?");
                                    Console.WriteLine(" y " + "or" + " n ?");
                                    string answer = Convert.ToString(Console.ReadLine());
                                    if (answer == "y")
                                    {
                                        Gold -= (count1 * 3000);
                                        item.Add("1) Cleansing Powder " + cleansingPowder + "x");
                                        Console.WriteLine("You bought " + cleansingPowder + " Cleansing Powder.");



                                    }

                                } while (!Utility.IsReadGood());


                            }

                            else
                            {
                                Console.WriteLine("Not enough Money...");

                            }
                        }

                    } while (!Utility.IsReadGood());
                    Console.ReadLine();
                }

                if (input == 6)
                {
                    int count1 = 0;
                    do
                    {

                        Console.WriteLine("How many do you want?");
                        count1 = Utility.ReadInt();
                        {
                            if (count1 > 0 && Gold > count1 * 10000)
                            {
                                do
                                {

                                    senzubean = ItemAmount(count1);
                                    Console.WriteLine("Is this how much you want? " + ItemAmount(count1) + "?");
                                    Console.WriteLine(" y " + "or" + " n ?");
                                    string answer = Convert.ToString(Console.ReadLine());
                                    if (answer == "y")
                                    {
                                        Gold -= (count1 * 10000);
                                        item.Add("1) Beans of Senzu " + senzubean + "x");
                                        Console.WriteLine("You bought " + senzubean+ " Beans of Senzu.");



                                    }

                                } while (!Utility.IsReadGood());


                            }

                            else
                            {
                                Console.WriteLine("Not enough Money...");

                            }
                        }

                    } while (!Utility.IsReadGood());
                    Console.ReadLine();
                }

                if (input == 7)
                {
                    int count1 = 0;
                    do
                    {

                        Console.WriteLine("How many do you want?");
                        count1 = Utility.ReadInt();
                        {
                            if (count1 > 0 && Gold > count1 * 20000)
                            {
                                do
                                {

                                    featherPheonix = ItemAmount(count1);
                                    Console.WriteLine("Is this how much you want? " + ItemAmount(count1) + "?");
                                    Console.WriteLine(" y " + "or" + " n ?");
                                    string answer = Convert.ToString(Console.ReadLine());
                                    if (answer == "y")
                                    {
                                        Gold -= (count1 * 20000);
                                        item.Add("1) Feathers of the Pheonix" + featherPheonix + "x");
                                        Console.WriteLine("You bought " + featherPheonix + " Feathers of the Pheonix.");



                                    }

                                } while (!Utility.IsReadGood());


                            }

                            else
                            {
                                Console.WriteLine("Not enough Money...");

                            }
                        }

                    } while (!Utility.IsReadGood());
                    Console.ReadLine();
                }

                if (input == 8)
                {
                    int count1 = 0;
                    do
                    {

                        Console.WriteLine("How many do you want?");
                        count1 = Utility.ReadInt();
                        {
                            if (count1 > 0 && Gold > count1 * 1200)
                            {
                                do
                                {

                                    enchantingJuice = ItemAmount(count1);
                                    Console.WriteLine("Is this how much you want? " + ItemAmount(count1) + "?");
                                    Console.WriteLine(" y " + "or" + " n ?");
                                    string answer = Convert.ToString(Console.ReadLine());
                                    if (answer == "y")
                                    {
                                        Gold -= (count1 * 1200);
                                        item.Add("1) Enchantment Juice " + enchantingJuice + "x");
                                        Console.WriteLine("You bought " + enchantingJuice + " Enchantment Juice.");



                                    }

                                } while (!Utility.IsReadGood());


                            }

                            else
                            {
                                Console.WriteLine("Not enough Money...");

                            }
                        }

                    } while (!Utility.IsReadGood());
                    Console.ReadLine();
                }


                if (input == 9)
                {
                    int count1 = 0;
                    do
                    {

                        Console.WriteLine("How many do you want?");
                        count1 = Utility.ReadInt();
                        {
                            if (count1 > 0 && Gold > count1 * 1200)
                            {
                                do
                                {

                                    turnaquette = ItemAmount(count1);
                                    Console.WriteLine("Is this how much you want? " + ItemAmount(count1) + "?");
                                    Console.WriteLine(" y " + "or" + " n ?");
                                    string answer = Convert.ToString(Console.ReadLine());
                                    if (answer == "y")
                                    {
                                        Gold -= (count1 * 1200);
                                        item.Add("1) Turnaquettes " + turnaquette + "x");
                                        Console.WriteLine("You bought " + turnaquette + " Turnaquettes.");



                                    }

                                } while (!Utility.IsReadGood());


                            }

                            else
                            {
                                Console.WriteLine("Not enough Money...");

                            }
                        }

                    } while (!Utility.IsReadGood());
                    Console.ReadLine();
                }

                if (input == 10)
                {
                    int count1 = 0;
                    do
                    {

                        Console.WriteLine("How many do you want?");
                        count1 = Utility.ReadInt();
                        {
                            if (count1 > 0 && Gold > count1 * 2000)
                            {
                                do
                                {

                                    LiquorBottle = ItemAmount(count1);
                                    Console.WriteLine("Is this how much you want? " + ItemAmount(count1) + "?");
                                    Console.WriteLine(" y " + "or" + " n ?");
                                    string answer = Convert.ToString(Console.ReadLine());
                                    if (answer == "y")
                                    {
                                        Gold -= (count1 * 2000);
                                        item.Add("1) Liquor Bottles " + LiquorBottle + "x");
                                        Console.WriteLine("You bought " + LiquorBottle + " Liquor Bottles.");



                                    }

                                } while (!Utility.IsReadGood());


                            }

                            else
                            {
                                Console.WriteLine("Not enough Money...");

                            }
                        }

                    } while (!Utility.IsReadGood());
                    Console.ReadLine();
                }

                if (input == 11)
                {
                    int count1 = 0;
                    do
                    {

                        Console.WriteLine("How many do you want?");
                        count1 = Utility.ReadInt();
                        {
                            if (count1 > 0 && Gold > count1 * 400)
                            {
                                do
                                {

                                    Soda = ItemAmount(count1);
                                    Console.WriteLine("Is this how much you want? " + ItemAmount(count1) + "?");
                                    Console.WriteLine(" y " + "or" + " n ?");
                                    string answer = Convert.ToString(Console.ReadLine());
                                    if (answer == "y")
                                    {
                                        Gold -= (count1 * 400);
                                        item.Add("1) Sodas " + Soda + "x");
                                        Console.WriteLine("You bought " + Soda + " sodas.");



                                    }

                                } while (!Utility.IsReadGood());


                            }

                            else
                            {
                                Console.WriteLine("Not enough Money...");

                            }
                        }

                    } while (!Utility.IsReadGood());
                    Console.ReadLine();
                }

                if (input == 12)
                {
                    int count1 = 0;
                    do
                    {

                        Console.WriteLine("How many do you want?");
                        count1 = Utility.ReadInt();
                        {
                            if (count1 > 0 && Gold > count1 * 17000)
                            {
                                do
                                {

                                    PackofMagic = ItemAmount(count1);
                                    Console.WriteLine("Is this how much you want? " + ItemAmount(count1) + "?");
                                    Console.WriteLine(" y " + "or" + " n ?");
                                    string answer = Convert.ToString(Console.ReadLine());
                                    if (answer == "y")
                                    {
                                        Gold -= (count1 * 17000);
                                        item.Add("1) Pack 'o' Magic " + PackofMagic + "x");
                                        Console.WriteLine("You bought " + PackofMagic + " Pack 'o' Magic.");



                                    }

                                } while (!Utility.IsReadGood());


                            }

                            else
                            {
                                Console.WriteLine("Not enough Money...");

                            }
                        }

                    } while (!Utility.IsReadGood());
                    Console.ReadLine();
                }

                if (input == 13)
                {
                    int count1 = 0;
                    do
                    {

                        Console.WriteLine("How many do you want?");
                        count1 = Utility.ReadInt();
                        {
                            if (count1 > 0 && Gold > count1 * 17000)
                            {
                                do
                                {
                                    Gold -= (count1 * 17000);
                                    RegeneratingWater = ItemAmount(count1);
                                    Console.WriteLine("Is this how much you want? " + ItemAmount(count1) + "?");
                                    Console.WriteLine(" y " + "or" + " n ?");
                                    string answer = Convert.ToString(Console.ReadLine());
                                    if (answer == "y")
                                    {
                                        item.Add("1) Regenerating Water " + RegeneratingWater+ "x");
                                        Console.WriteLine("You bought " + RegeneratingWater + " Regenerating Water.");



                                    }

                                } while (!Utility.IsReadGood());


                            }

                            else
                            {
                                Console.WriteLine("Not enough Money...");

                            }
                        }

                    } while (!Utility.IsReadGood());
                    Console.ReadLine();
                }

                if (input == 14)
                {
                    int count1 = 0;
                    do
                    {

                        Console.WriteLine("How many do you want?");
                        count1 = Utility.ReadInt();
                        {
                            if (count1 > 0 && Gold > count1 * 2000)
                            {
                                do
                                {

                                    SmoothingLotion = ItemAmount(count1);
                                    Console.WriteLine("Is this how much you want? " + ItemAmount(count1) + "?");
                                    Console.WriteLine(" y " + "or" + " n ?");
                                    string answer = Convert.ToString(Console.ReadLine());
                                    if (answer == "y")
                                    {
                                        Gold -= (count1 * 2000);
                                        item.Add("1) Smoothing Potion " + SmoothingLotion + "x");
                                        Console.WriteLine("You bought " + SmoothingLotion + " Smoothing Potions.");



                                    }

                                } while (!Utility.IsReadGood());


                            }

                            else
                            {
                                Console.WriteLine("Not enough Money...");

                            }
                        }

                    } while (!Utility.IsReadGood());
                    Console.ReadLine();
                }

                if (input == 15)
                {
                    int count1 = 0;
                    do
                    {

                        Console.WriteLine("How many do you want?");
                        count1 = Utility.ReadInt();
                        {
                            if (count1 > 0 && Gold > count1 * 2000)
                            {
                                do
                                {

                                    HotBandage = ItemAmount(count1);
                                    Console.WriteLine("Is this how much you want? " + ItemAmount(count1) + "?");
                                    Console.WriteLine(" y " + "or" + " n ?");
                                    string answer = Convert.ToString(Console.ReadLine());
                                    if (answer == "y")
                                    {
                                        Gold -= (count1 * 2000);
                                        item.Add("1) Hot Bandage " + HotBandage + "x");
                                        Console.WriteLine("You bought " + HotBandage + " Hot Bandages.");



                                    }

                                } while (!Utility.IsReadGood());


                            }

                            else
                            {
                                Console.WriteLine("Not enough Money...");

                            }
                        }

                    } while (!Utility.IsReadGood());
                    Console.ReadLine();
                }

                if (input == 16)
                {
                    int count1 = 0;
                    do
                    {

                        Console.WriteLine("How many do you want?");
                        count1 = Utility.ReadInt();
                        {
                            if (count1 > 0 && Gold > count1 * 5000)
                            {
                                do
                                {

                                    LargeKit = ItemAmount(count1);
                                    Console.WriteLine("Is this how much you want? " + ItemAmount(count1) + "?");
                                    Console.WriteLine(" y " + "or" + " n ?");
                                    string answer = Convert.ToString(Console.ReadLine());
                                    if (answer == "y")
                                    {
                                        Gold -= (count1 * 5000);
                                        item.Add("1) LargeKits " + LargeKit + "x");
                                        Console.WriteLine("You bought " + LargeKit + " LargeKits.");



                                    }

                                } while (!Utility.IsReadGood());


                            }

                            else
                            {
                                Console.WriteLine("Not enough Money...");

                            }
                        }

                    } while (!Utility.IsReadGood());
                    Console.ReadLine();
                }

                if (input == 17)
                {
                    int count1 = 0;
                    do
                    {

                        Console.WriteLine("How many do you want?");
                        count1 = Utility.ReadInt();
                        {
                            if (count1 > 0 && Gold > count1 * 7000)
                            {
                                do
                                {

                                    LargePotion = ItemAmount(count1);
                                    Console.WriteLine("Is this how much you want? " + ItemAmount(count1) + "?");
                                    Console.WriteLine(" y " + "or" + " n ?");
                                    string answer = Convert.ToString(Console.ReadLine());
                                    if (answer == "y")
                                    {
                                        Gold -= (count1 * 7000);
                                        item.Add("1) Large Potions " + LargePotion + "x");
                                        Console.WriteLine("You bought " + LargePotion + " Large Potions.");



                                    }

                                } while (!Utility.IsReadGood());


                            }
                        }

                    } while (!Utility.IsReadGood());

                }

               
                Console.ReadLine();

            }

            public static void CheckWeapons()
            {

                foreach (string item in list)
                {
                   
                    Console.WriteLine(item);
                    
                }
                //Console.ReadLine();
            }

            public static void CheckItems()
            {
                foreach (string i in item )
                {

                    Console.WriteLine(i);

                }
            }

            public static void CheckArmour()
            {
                foreach (string A in armour)
                {
                    Console.WriteLine(A);
                }
            }
        }

        public void pigeonHead()
        {
            int PlayerMP = MPATK;
            int PidgeonHeadHP = 250;
            int PidgeonHeadMP = 150;
            currentMP = MaxMP;
            currentHP = HP;

            if (currentHP < 0)
            {
                currentHP = 0;
            }
            EnemyTurn = true;

            do
            {
           if ( EnemyTurn == true)
                do
            {
                        PidgeonHeadMP += 10;
            Random rand1 = new Random();
            int Enematk = rand1.Next(1, 6);
            int attackState = (rand1.Next(1, 5));
            //Array enumValues = Enum.GetValues(typeof(PidgHeadStates));           
            //enumValues.GetValue(rand1.Next(enumValues.Length));

            PidgHeadStates state = (PidgHeadStates)(attackState);


            switch (state)
            {
               
                case (PidgHeadStates.Peck):
                    if (attackState == 1)
                    {

                        int peck = 4;

                        Enematk = peck += Enematk;
                        currentHP = currentHP -= Enematk;
                                    if (Program.currentHP <= 0)
                                    {
                                        Program.currentHP = 0;
                                    }

                                    if (Program.Reflex == true)
                                    {
                                        Program player = new Program();
                                        player.ReflexDmgPlayer(ref PidgeonHeadHP, ref Enematk, ref Program.currentHP);
                                        Program.EnemyTurn = false;
                                        Program.playerTurn = true;

                                    }

                                    if (Program.HurtDamage == true)
                                    {
                                        Console.WriteLine("Pidgeon head pecked at your face for " + Enematk + " Damage");
                                        Console.WriteLine("You have " + Program.currentHP + "Left");
                                        SpikedShield spikeS = new SpikedShield();
                                        spikeS.ShieldDmg(ref PidgeonHeadHP);
                                        Program.EnemyTurn = false;
                                        Program.playerTurn = true;
                                    }
                                    Console.WriteLine("Pidgeon head pecked at your face for " + Enematk + " Damage");
                        Console.WriteLine("You have " + currentHP + "Left");
                                EnemyTurn = false;
                                playerTurn = true;
                                Console.ReadLine();
                           // EnemyTurn = false;
                            //playerTurn = true;
                        }
                    break;

                case (PidgHeadStates.HeadBash):
                    if (attackState == 2)
                    {
                        int HeadBash = 10;
                        Enematk = HeadBash += Enematk;
                        currentHP = currentHP -= Enematk;
                                    if (Program.currentHP <= 0)
                                    {
                                        Program.currentHP = 0;
                                    }

                                    if (Program.Reflex == true)
                                    {
                                        Program player = new Program();
                                        player.ReflexDmgPlayer(ref PidgeonHeadHP, ref Enematk, ref Program.currentHP);
                                        Program.EnemyTurn = false;
                                        Program.playerTurn = true;

                                    }

                                    if (Program.HurtDamage == true)
                                    {
                                        Console.WriteLine("Pidgeon head pecked at your face for " + Enematk + " Damage");
                                        Console.WriteLine("You have " + Program.currentHP + "Left");
                                        SpikedShield spikeS = new SpikedShield();
                                        spikeS.ShieldDmg(ref PidgeonHeadHP);
                                        Program.EnemyTurn = false;
                                        Program.playerTurn = true;
                                    }
                                    Console.WriteLine("Pidgeon bashed your head in for " + Enematk +  " Damage");
                        Console.WriteLine("You have " + currentHP + " Left");
                                EnemyTurn = false;
                                playerTurn = true;
                                Console.ReadLine();
                            //EnemyTurn = false;
                            //playerTurn = true;
                        }
                    break;

                case (PidgHeadStates.SaborSword):
                    if (attackState == 3)
                    {

                        GameWeapons.saberSword(HP);
                       currentHP = currentHP -= Enematk;
                                    if (Program.currentHP <= 0)
                                    {
                                        Program.currentHP = 0;
                                    }

                                    if (Program.HurtDamage == true)
                                    {
                                        Console.WriteLine("Pidgeon head pecked at your face for " + Enematk + " Damage");
                                        Console.WriteLine("You have " + Program.currentHP + "Left");
                                        SpikedShield spikeS = new SpikedShield();
                                        spikeS.ShieldDmg(ref PidgeonHeadHP);
                                        Program.EnemyTurn = false;
                                        Program.playerTurn = true;
                                    }
                                    Console.WriteLine("Pidgeon attacked with his saborsword for " + Enematk + " Damage");
                        Console.WriteLine("You have " + currentHP + " Left");
                                EnemyTurn = false;
                                playerTurn = true;
                                Console.ReadLine();
                            //EnemyTurn = false;
                            //playerTurn = true;
                        }
                    break;

                case (PidgHeadStates.TornadoWhirlwind):
                    if (attackState == 4)
                    {
                                    if (PidgeonHeadHP< 30)
                                    {
                                        goto case PidgHeadStates.HeadBash;
                                    }
                        int TornadoWhirlwind = 50;
                         currentHP= currentHP -= TornadoWhirlwind;
                                    PidgeonHeadMP -= 30;
                                    if (Program.currentHP <= 0)
                                    {
                                        Program.currentHP = 0;
                                    }
                                    if (PidgeonHeadMP < 0)
                                    {
                                        PidgeonHeadMP = 0;
                                    }
                                    Console.WriteLine("Special: Pidgeon Began a Tornado  for" + TornadoWhirlwind + " Damage!");
                        Console.WriteLine("You have " + currentHP + "Left");

                                EnemyTurn = false;
                                playerTurn = true;
                                Console.ReadLine();
                        //EnemyTurn = false;
                       // playerTurn = true;

                        }
                    break;
                           

                    }
                        if (Program.oppBurn == true)
                        {
                            Ailments burning = new Ailments();
                            burning.burnDmg(ref PidgeonHeadHP);
                            Console.WriteLine("Eyeman has been burned ");
                        }

                        if (Program.oppPoison == true)
                        {
                            Ailments poisoning = new Ailments();
                            poisoning.PoisonDmg(ref PidgeonHeadHP);
                            Console.WriteLine("Eyeman has been Poisoned");
                        }
                        Console.WriteLine("NextTurn!");
                    playerTurn = true;
                    Console.ReadLine();
            } while (EnemyTurn == true );
            

          

            if(playerTurn ==true){
                    int input = 0;
                    currentMP += 3 * Level;
             do
            {
                Console.WriteLine("Health " + currentHP);
                Console.WriteLine("MP: " + currentMP);
                Console.WriteLine("PidgeonHead: " + PidgeonHeadHP);
                Console.WriteLine("PidgeonHeadMP: " + PidgeonHeadMP);
                Console.WriteLine("1) Attack");
                Console.WriteLine("2) MP Attack");
                Console.WriteLine("3) Inventory");
                Console.WriteLine("4) Skip turn");

                        input = Utility.ReadInt();
                PlayersTurn turn = (PlayersTurn)(input);

                switch (turn)
                {

                    

                    case (PlayersTurn.Attack):
                        if (input == 1)
                        {

                       PidgeonHeadHP-= GrabAttack();
                                    if (PidgeonHeadHP <= 0)
                                    {
                                        PidgeonHeadHP = 0;
                                    }

                                    Console.WriteLine("PidgeonHead " + PidgeonHeadHP);
                            EnemyTurn = true;
                                playerTurn = false;
                           
                            Console.ReadLine();

                                

                            }
                        break;

                    case (PlayersTurn.MPAttack):
                        if (input == 2)
                        {
                           

                          Console.Clear();
                          MPAttack(ref PidgeonHeadHP);
                          if (PidgeonHeadHP <= 0)
                             {
                               PidgeonHeadHP = 0;
                             }
                         }

                        else
                                {
                                    Console.WriteLine("Wrong input");
                                    playerTurn = true;
                                }
                        break;

                    case (PlayersTurn.Inventory):
                              
                        if (input== 3)
                        {
                          int itemPick = 0;
                                    Console.WriteLine("Pick an Item");
                                    Console.WriteLine("If you have no items. Push any number to go back.");
                                    GrabInventory();

                                    do
                                    {


                                    itemPick = Utility.ReadInt();     
                         if(itemPick == 1 && Shop.Potion > 0)
                           {
                                            Console.Clear();
                                     Potions.UsePotion();
                                        Shop.Potion--;
                                    Console.WriteLine(username + " Recovered " + Potions.potion + " HP ");
                                        EnemyTurn = true;
                                        playerTurn = false;

                                        Console.ReadLine();

                              }

                          if(itemPick == 2 && Shop.medkit > 0)
                           {
                                            Console.Clear();
                                     MedKit.UseMedKit();
                                        Shop.medkit--;
                                    Console.WriteLine(username + " Recovered " + MedKit.medkit + " HP ");
                                        EnemyTurn = true;
                                        playerTurn = false;

                                        Console.ReadLine();

                              }

                              if(itemPick == 3 && Shop.medPotion > 0)
                           {
                                            Console.Clear();
                                     MedPotion.UseMedPotion();
                                        Shop.medPotion--;
                                    Console.WriteLine(username + " Recovered " + MedPotion.medPotion + " HP ");
                                        EnemyTurn = true;
                                        playerTurn = false;

                                        Console.ReadLine();

                              }

                               if(itemPick == 4 && Shop.bottlewine > 0)
                           {
                                            Console.Clear();
                                            bottleOfWine.UseBOF();
                                        Shop.bottlewine--;
                                    Console.WriteLine(username + " Recovered " + bottleOfWine.BOF + " MP ");
                                        EnemyTurn = true;
                                        playerTurn = false;

                                        Console.ReadLine();

                              }

                                if(itemPick == 5 && Shop.cleansingPowder > 0)
                           {
                                            Console.Clear();
                                     CleansingPowder.Usecleansingpowder();
                                        Shop.cleansingPowder--;
                                    Console.WriteLine(username + " Recovered " + CleansingPowder.cleansingpowder + " MP ");
                                        EnemyTurn = true;
                                        playerTurn = false;

                                        Console.ReadLine();

                              }

                            
                                 if(itemPick == 6 && Shop.senzubean > 0)
                           {
                                            Console.Clear();
                                     SenzuBean.Usesenzu();
                                        Shop.senzubean--;
                                    Console.WriteLine(username + " Revived and Recovered for " + SenzuBean.senzu + " HP ");
                                        EnemyTurn = true;
                                        playerTurn = false;

                                        Console.ReadLine();

                              }

                                  if(itemPick == 7 && Shop.featherPheonix > 0)
                           {
                                            Console.Clear();
                                     FeatherPheonix.Usefeatherpheonix();
                                        Shop.featherPheonix--;
                                    Console.WriteLine(username + " Revived and Recovered for " + FeatherPheonix.featherpheonix + " HP ");
                                        EnemyTurn = true;
                                        playerTurn = false;

                                        Console.ReadLine();

                              }

                            if(itemPick == 8 && Shop.enchantingJuice > 0)
                           {
                                            Console.Clear();
                                     enchantingJuice.UseenchantingJ();
                                       Shop.enchantingJuice--;
                                    Console.WriteLine(username + " Recovered " + enchantingJuice.enchantingjuice + " MP ");
                                        EnemyTurn = true;
                                        playerTurn = false;

                                        Console.ReadLine();

                              }

                             if(itemPick == 9 && Shop.turnaquette > 0)
                           {
                                            Console.Clear();
                                     Turnaquette.Useturnaquette();
                                        Turnaquette.turnaquettes--;
                                    Console.WriteLine(username + " Recovered " + Turnaquette.turnaquettes + " HP ");
                                        EnemyTurn = true;
                                        playerTurn = false;

                                        Console.ReadLine();

                              }

                                 if(itemPick == 10 && Shop.LiquorBottle > 0)
                           {
                                            Console.Clear();
                                    LiquorBottle.Useliquor();
                                       LiquorBottle.liquor--;
                                    Console.WriteLine(username + " Recovered " + LiquorBottle.liquor + " MP ");
                                        EnemyTurn = true;
                                        playerTurn = false;

                                        Console.ReadLine();

                              }

                                     if(itemPick == 11 && Shop.Soda > 0)
                           {
                                            Console.Clear();
                                     Soda.Usesoda();
                                        Soda.soda--;
                                    Console.WriteLine(username + " Recovered " + Turnaquette.turnaquettes + " MP ");
                                        EnemyTurn = true;
                                        playerTurn = false;

                                        Console.ReadLine();

                              }

                                   if(itemPick == 12 && Shop.PackofMagic > 0)
                           {
                                            Console.Clear();
                                     PackOfMagic.Usepackofmagic();
                                        PackOfMagic.packofmagic--;
                                    Console.WriteLine(username + " Recovered " + PackOfMagic.packofmagic + " MP ");
                                        EnemyTurn = true;
                                        playerTurn = false;

                                        Console.ReadLine();

                              }

                                       if(itemPick == 13 && Shop.RegeneratingWater > 0)
                           {
                                            Console.Clear();
                                     RegeneratingWater.Useregeneratingwater();
                                        RegeneratingWater.regeneratingwater--;
                                    Console.WriteLine(username + " Recovered " + RegeneratingWater.regeneratingwater + " HP ");
                                        EnemyTurn = true;
                                        playerTurn = false;

                                        Console.ReadLine();

                              }

                                  if(itemPick == 14 && Shop.SmoothingLotion > 0)
                           {
                                            Console.Clear();
                                     SmoothingLotion.Usesenzu();
                                        SmoothingLotion.smoothinglotion--;
                                    Console.WriteLine(username + " Recovered " + SmoothingLotion.smoothinglotion + " HP ");
                                        EnemyTurn = true;
                                        playerTurn = false;

                                        Console.ReadLine();

                              }

                                      if(itemPick == 15 && Shop.HotBandage > 0)
                           {
                                            Console.Clear();
                                     HotBandage.Usebandage();
                                        HotBandage.bandage--;
                                    Console.WriteLine(username + " Recovered " + HotBandage.bandage + " HP ");
                                        EnemyTurn = true;
                                        playerTurn = false;

                                        Console.ReadLine();

                              }

                                          if(itemPick == 16 && Shop.LargeKit > 0)
                           {
                                            Console.Clear();
                                     LargeKit.Uselargekit();
                                        LargeKit.largekit--;
                                    Console.WriteLine(username + " Recovered " + LargeKit.largekit + " HP ");
                                        EnemyTurn = true;
                                        playerTurn = false;

                                        Console.ReadLine();

                              }

                                  if(itemPick == 17 && Shop.LargePotion > 0)
                           {
                                            Console.Clear();
                                            LargePotion.UseLPotion();
                                        LargePotion.LPotion--;
                                    Console.WriteLine(username + " Recovered " + LargePotion.LPotion + " HP ");
                                        EnemyTurn = true;
                                        playerTurn = false;

                                        Console.ReadLine();

                              }
                              else
                                    {
                                            Console.WriteLine("Wrong Input");
                                            playerTurn = true;

                                    }
                                       
                                  } while (!Utility.IsReadGood());
                                }
                        break;


                    case (PlayersTurn.EndTurn):
                        if (input == 4)
                        {
                            playerTurn = false;
                            EnemyTurn = true;
                            //pigeonHead();
                        }

                       
                        break;
                    default:
                        {
                                EnemyTurn = true;
                                playerTurn = false;
                                   
                            }
                        break;


                }

            } while (playerTurn == true);

                   

    if (currentHP <=0)
            {
                Console.Clear();
                Console.WriteLine("You Lose!");
                Console.ReadLine();
                Menu();
            }

            else if(PidgeonHeadHP <= 0)
            {

                Console.Clear();
                Random rand1 = new Random();
                int expEarned = rand1.Next(125, 450);
                int goldEarned = 525;
                Console.WriteLine("You Win!");
                Console.ReadLine();
                        Console.WriteLine("You earned " + expEarned + " Exp!");
                        Console.WriteLine("You earned " + goldEarned + " Gold!");
                        Exp += expEarned;
                        Gold += goldEarned;
                        Console.ReadLine();
                        LevelChanger.LevelChange();
                 
                        Menu();
            }
                Console.WriteLine("NextTurn!");
                EnemyTurn = true;
                Console.ReadLine();
           
            }
            } while (true ||!Utility.IsReadGood());
            


            //playerTurn = true;

            //Console.WriteLine("Battling!");
            //Console.WriteLine("You have this much " + HP + " Left");
            //Console.ReadLine();

        }


        public static void GrabInventory()
        {
            Shop.ConvertItem();
           // Shop.CheckItems();
            

        }

        public static int GrabAttack()
        {
            int damage = 0;
             Shop.ConvertWeapons(ref Atk);
            foreach(int weapons in equip)
            {
               
                damage = damage += weapons;

                
                
            }

            
            Console.WriteLine("You attacked and did " + damage + " damage!");
            Console.ReadLine();
             return  damage;
            }

       

        public void ReflexDmgPlayer(ref int OppHealth, ref int oppAtk, ref int playerHealth)
        {

            Console.WriteLine("Reflex Activated!");
            Console.ReadLine();
            OppHealth = OppHealth - oppAtk;
            Console.WriteLine(Program.username + " reflexes the attack for " + oppAtk + " damage.");
            playerHealth = playerHealth + oppAtk;
            Console.WriteLine("You have " + Program.currentHP + "Left");
            Console.ReadLine();

        }



    }


}
