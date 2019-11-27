using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BossRaid;

namespace Minions
{
     class babyEyeman
    {
        public static int babyeyeHealth = 35;
        public static int babyeyeAtk = 3;
        public enum eyemenState
        {
            suckerPunch = 1,
            Picksword = 2,
            eyeBeam = 3,
        }        
        public static void EyemenBattle(ref int oppHealth)
        {

          

          

           

                Random rand1 = new Random();
                        int Enematk = 7;
                        int attackState = (rand1.Next(1, 4));


                        eyemenState state = (eyemenState)(attackState);


                        switch (state)
                        {

                            case (eyemenState.Picksword):
                                if (attackState == 1)
                                {

                                    int picksword = 4;

                                    Enematk = picksword += Enematk;
                                    oppHealth = oppHealth -= Enematk;
                                    Console.WriteLine("baby EyeMen slashed with its picksword for " + Enematk + " Damage");
                                    Console.WriteLine("You have " + oppHealth + "Left");
                                    


                                }
                                break;

                            case (eyemenState.suckerPunch):
                                if (attackState == 2)
                                {
                                    int suckerPunch = 5;
                                    Enematk = suckerPunch += Enematk;
                                    oppHealth = oppHealth -= Enematk;
                                    Console.WriteLine("baby EyeMen sucker punched you for " + Enematk + " Damage");
                                    Console.WriteLine("You have " + oppHealth + " Left");
                                   


                                }
                                break;

                            case (eyemenState.eyeBeam):
                                if (attackState == 3)
                                {


                                   oppHealth = oppHealth -= (Enematk * 2);

                                    Console.WriteLine("Special: baby EyeMen attacked with his signature Ice Beam for " + Enematk + " Damage");
                                    Console.WriteLine("You have " + oppHealth + " Left");
                                   

                                }
                                break;



                        }

                  

                Console.WriteLine("NextTurn!");
                Program.playerTurn = true;
                Console.ReadLine();


           
}
    }
}