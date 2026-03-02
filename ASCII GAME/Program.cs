using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Runtime.ExceptionServices;
using System.Text;

namespace ASCII_GAME
{
    internal class Program
    {
        public static Random rand = new Random(); //PUBLICALLY AVAILABLE RANDOM VARIABLE
        public static void Intro()
        {

            string[] pizzaHutLogo = { "                                         ######++##                        \r\n                                  ############++++##                       \r\n                            ############++++++++++##                       \r\n                          #######+++++++++++++++++###                      \r\n                         ##++++++++++++++++++++++++###                     \r\n                        ##+++++++++++++++++++++++++##########              \r\n                       ##++++++++++++++++++++++++++++++###########         \r\n                      #++++++++++++++++++++++++++++++++++++++##########    \r\n                    ##++++++++++++++++++++++++++++++++++++++++++++######## \r\n                #####++++++++++++++++++++++++++++++++##############++++### \r\n             #####++++++++++++++++++++++###########################++++    \r\n          #####+++++++++++++++################################             \r\n       #####++++++++++###########+++######                                 \r\n     ####+++++#################+++++                                       \r\n  #####################      ++++++                                        \r\n##############               ++++             ############       ########  \r\n#######                       +               #############   ###########  \r\n            #######           ## ############# ##########   ######  ####   \r\n        ##############      #### ############    #######   ################\r\n        ###############    #####      ######   #######     ################\r\n          ####   #######  #####     ######   #####################         \r\n         #####     ##### #####   ########   ###############                \r\n        #####      ##### ##### ############# ##     ##                     \r\n       #####     ######  #### #########################   ###              \r\n      ######   ######    ###  #####################     #####              \r\n     ##############      ##      ###                   ############        \r\n    ######  #           ###     ####            # #############            \r\n    ######             ####    ####  ###       ### #######                 \r\n   ######             ####     ####  ####     ####   ####                  \r\n   #####             #####    ###########   ######  #####                  \r\n  #####             ############### #############   ####                   \r\n  #####        ###################  #############   ###          .-...     \r\n  ####         ###################  #######   ###   ##+..............-     \r\n   #             ######     #####     ##        ....+-..........    ###    \r\n                 ######     ####          ................          ###    \r\n                 #####       ##       ...............                      \r\n                 #####            .............                            \r\n                 ####        -............--                               \r\n                         -..............                                   \r\n                      .............                                        \r\n                      ........-                                            " };
            Console.ForegroundColor = ConsoleColor.DarkRed;
            foreach (string logo in pizzaHutLogo) { Console.WriteLine(logo); }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Pizza Hut Games");
            Thread.Sleep(1000);
            Console.Write("\n\n.");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("\x1b[3J");

        }
        public static void GuyatComputer()
        {
            //Ascii art for the games start screen
            string[] GuyatComputer = { "                                                                     MMMMMMMMMMMMMMMMM            \r\n                                                                     MMMMMMMMMMMMMMMMMMM          \r\n               WVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV        MOPPPPOMMMMMMMMMMMMMM        \r\n            ZZYWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW       ZYYYYYYWQMMMMMMMMMMMMM       \r\n            ZZXWZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZWWX      YYYYYYYYWQMMMMMMMMMMMM       \r\n            ZZXWYZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZWWX     ZYYYVWYYYXSMNNMMMMMMMMML      \r\n            ZZXWXZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZYWWX     ZYYVLPYYYXSMSXUNMMMMMMM       \r\n            ZZXWXZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZYWWX    ZZYYYYYYYYXTNSXYPMMMMMMN       \r\n            ZZXWXZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZYWWX   ZZZYYWVVYYYYYYYXRMMMMMMN        \r\n            ZZXWXZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZYWWX   ZZZZYYXXYYYYYYYYVOMMMMN         \r\n            ZZXWXZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZYWWX    YZYYYYYYYYYYYYYYUNMMN          \r\n            ZZXWXZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZYWWX      YYYYYYYYYYYYYYXW             \r\n            ZZXWXZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZYWWX      YYYYYYYYYYXWWWWW             \r\n            ZZXWXZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZYWWX        YYYYZXXXXXXXXXX            \r\n            ZZXWXZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZYWWX            VWWWWWWWWWUUT          \r\n            ZZXWXZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZYWWX         XXXXWVUUUUUUUUUUUUV       \r\n            ZZXWXZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZYWWX       XXXXXXXXWUUUUUUUUUUUUU      \r\n            ZZXWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWX     XXXXXXTTTTSRQQQQQQQQQQQQONONN \r\n            ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ     XXXXXTOOONKIIIIIIIIIIIIIIIIIIIK\r\n            ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ   XXXXXXXSOOONKIIIIIIIIIIIIIIIIIIII\r\n            ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ  XXXXXXXXSOOONKIIIIIIIIIIIIIIIIIIII\r\n                              ZZZZZZZZZZZZZZZZ                XXXXXXXXXXSOOONKIIIIIIJWWWWVNHIIIIII\r\n                              ZZZZZZZZZZZZZZZZZUUXXXXXXXXXXXXXXXXXXXXXXXROOONKIIIIIIJZZZZZOGGHIIII\r\n                              ZZZZZZZZZZZZZZZZZVUXXXXXXXXXXXXXXXXXXXXXWUQOOONKIIIIIIJZZZZZOFFGHHII\r\n                              ZZZZZZZZZZZZZZZZZVUXXXXXXXXXXXXXXXXXXXXXUUQOOONKIIIIIIJZZZZZOFFFFGHH\r\n                        ZZZZZZZZZZZZZZZZZZZZZZZVVXXXXXXXXXXXXXXXXXXXX UUUPONLHGGGGGGHZZZZZOFFFFFFG\r\nWWWWWWWWWWWWWWWWWWWWWWWTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTUUUTTTTTTTTTTUZZZZZWTSSSSTS\r\nWWWWWWWWWWWWWWWWWWWWWWWSRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRTVWUUUUUUUUUUUUZZZZZWUSRRRRR\r\nWWWWWWWWWWWVUTUVWWWWWWWSRRRRRRRRQRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRSRQTUUUUUUUUUUUUUUZZZZZWUTRRRRR\r\n           VTQPP             WURPPQ                               VVTQSUVUUUUUUUUUUUUZZZZZWTT     \r\n           WTRRQ             WUSRQQ                               VWTRTUVUUUUUUUUUUUUZZZZZWTT     \r\n           WTRRR             WUSRRR                       OPPQQQQQRUSRSTTTTTTTTTTTTTTZZZZZWTT     \r\n           WTRRR             WUSRRR                    OPPPPPPPPPPPPPPPPPPPPPPPPPPPPQZZZZZUPP     \r\n           WTRRR             WUSRRR                   QPPPPPPPPPPPPPPPPPPPPPPPPPPPPPQZZZZZUPP     \r\n           WTRRR             WUSRRR                  PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPQZZZZZY       \r\n           WTRRR             WUSRRR                  PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPQZZZZZZ       \r\n           WTRRR             WUSRRR                  QPPPOOOOOOOOOOOOOOOMIIIIIIIIIIIJZZZZZOGHHIIIH\r\n           WTRRR             WUSRRR                  QPPPOOOOOOOOOOOOOOOOJIIIIIIIIIIJZZZZZOFFGHIII\r\n           WTRRR             WUSRRR                  QPPPPOOOOOOOOOOOOOMIHGGGGGHJJJJOZZZZZOFFFFHHI\r\n           WTRRR             WUSRRR                  QPPPPPPPO  MMMMMMMMM  ZZYWWWXXVTTUZZ         \r\n           WTRRR             WUSRRR                  QPPPPPPPP  NMMMMMMMN  ZZYVVWWWUSRR           \r\n           WTRRR             WUSRRR                  QPPPPPPPP  NMMMMMMMN   ZZURRRWUSRR           \r\n           WTRRR             WUSRRR                  QPPPPPPPP  NMMMMMMMN   ZZXVTRVUSRR           \r\n           WTRRR             WUSRRR                  QPPPPPPPP  NMMMMMMMN   ZZYXWXVUSRR           \r\n           WTRRR             WUSRRR                  QPPPPPPPP  NMMMMMMMN   ZZYXWXVUSRR           \r\n           WTRRR             WUSRRR                  QPPPPPPPP  NMMMMMMMN   ZZYXWXVUSRR           \r\n           WTRRR             WUSRRR                  QPPPPPPPP  NMMMMMMMN   ZZYXWXVUSRR           \r\n           WTRRR             WUSRRR                  QPPPPPPPP  MMMMMMMMN   ZZYXWXVUSRR           \r\n           WTRRR             WUSRRR                KKMMMMMMMM GHJJOYZZZZZZUIJKNVYYYYXXYYYUKIIGG   \r\n           WTRRR             WUSRRR           LKKKKKKKKKKKKKKIHPZWIOUUUUZZIMZXJMXYYWWWWYWLMZZMGG  \r\n           WTRRR             WUSRRR           KKKKKKKKKKKKKKKIHHJIHJIIIIH GGJIGF  VUSRR  GHJJGG   " };
            foreach (string Guy in GuyatComputer)
            {
                Console.WriteLine(Guy);
            }
            Console.ReadLine();
        }

        public static void Menu()
        {
            int choice = 999;
            do
            {
                Console.WriteLine("\t\tI-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I");
                Console.WriteLine("\t\tI                                           I");
                Console.WriteLine("\t\tI              [Menu Options]               I");
                Console.WriteLine("\t\tI                                           I");
                Console.WriteLine("\t\tI-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I");
                //Console.WriteLine("\t\tI                                           I");
                //Console.WriteLine("\t\tI            1: Tic-tac-toe                 I");
                //Console.WriteLine("\t\tI            2: Battleships                 I");
                //Console.WriteLine("\t\tI            3: Minesweeper                 I");
                Console.WriteLine("\t\tI                                           I");
                Console.WriteLine("\t\tI              0: Adventure                 I");
                Console.WriteLine("\t\tI                                           I");
                Console.WriteLine("\t\tI-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I");
                Console.WriteLine();
                Console.Write("\tChoice: ");

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch 
                { 

                }
                

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Starting Adventure...");
                        Thread.Sleep(1000);
                        break;

                    //case 1:
                    //    break;

                    //case 2:
                    //    break;

                    //case 3:
                    //    break;

                    default:
                        Console.WriteLine("Invalid Input, Try Again");
                        Console.WriteLine("Press Enter to Continue");
                        Console.ReadLine();
                        break;

                }

                Console.Clear();
                Console.WriteLine("\x1b[3J");

            } while (choice != 0);
        }

        public class TextAdventure
        {
            // Text Adventure Code and Enemies

            //Character Stats
            public static int max_HP = 100, current_HP = 100, DEF = 2, ATT = 10, SPD = 10, LVL = 1, XP = 0, Required = 100; //PUBLICALLY AVAILABLE PLAYER STATS
            public static string Enemy_Name = "N/A";

            public static void Adventure()
            {
                //If Adding to Adventure Code use this method

                Console.WriteLine("Welcome to our text adventure game");
                Thread.Sleep(1000);
                Console.WriteLine("==========================================");
                Console.WriteLine("       MEMEVERSE: RISE OF THE DANK");
                Console.WriteLine("==========================================");
                Console.WriteLine("         Press Enter to continue");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("\x1b[3J");
                Thread.Sleep(600);
                Console.WriteLine("You awaken in a strange dimension...");
                Thread.Sleep(600);
                Console.WriteLine("Your mission: restore balance to the Memeverse");
                Thread.Sleep(600);
                Console.WriteLine("...before it’s consumed by cringe.");
                Thread.Sleep(3000);
                Console.WriteLine();
                Console.WriteLine("Press ENTER to begin your quest.");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("\x1b[3J");

                Console.WriteLine("You’ve heard the stories since you were young...");
                Thread.Sleep(800);
                Console.WriteLine("Tales from your grandfather — the old Meme Hunter.");
                Thread.Sleep(800);
                Console.WriteLine("He lost a limb fighting the one who shall not be named —");
                Console.WriteLine("a creature of pure distortion that shattered the Memeverse.");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("Now, years later, the legends stir again.");
                Thread.Sleep(800);
                Console.WriteLine("Frogs whisper in the ponds. Carrots vanish overnight.");
                Thread.Sleep(800);
                Console.WriteLine();
                Console.WriteLine("You grip your grandfather’s sword and take a breath.");
                Thread.Sleep(800);
                Console.WriteLine("It’s time to finish his fight.");
                Thread.Sleep(800);
                Console.WriteLine();
                Console.WriteLine("Press ENTER to begin your journey.");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("\x1b[3J");


                //initialise enemy stats
                int[] Enemy_Stats = new int[6];

                //Get pathway choice of left or right
                String choice = Pathway();
                
                //if choice is Left then fight big chungus
                if (choice == "L")
                {
                    Enemy_Stats = BigChungus();
                }
                //else fight pepefrog
                else
                {
                    Enemy_Stats = Pepefrog();
                }



                Console.ReadLine();
                Fight(Enemy_Stats);
                if (current_HP <= 0)
                {
                    // Player has Died
                    PlayerLoses();
                }
                Console.ReadLine();
                // Check New Stats after a Fight
                check();

                //Dat Boi fight
                Console.WriteLine("You have met the final boss: ");
                Console.Write("\n\n.");
                Thread.Sleep(1000);
                Console.Write(".");
                Thread.Sleep(1000);
                Console.Write(".");
                Thread.Sleep(1000);
                Console.Clear();

                Enemy_Stats = DatBoi();
                Fight(Enemy_Stats);


            }

            public static void Fight(int[] E_Stats)
            {
                int damage;
                //ORDER -- max_HP, current_HP, ATT, DEF, SPD, LVL
                if (SPD > E_Stats[4] || (SPD == E_Stats[4] && rand.Next(0, 2) == 0))  // Checks if Player has greater speed and makes a 50-50 roll if they are equal for the player to start first
                {
                    //Player starts first
                    FightMenu(E_Stats);
                    Console.WriteLine($"{Enemy_Name} HP: {E_Stats[1]}/{E_Stats[0]}");
                }
                while (E_Stats[1] > 0 && current_HP > 0) // While the enemy and player are both alive, loop
                {
                    //Enemy's Turn
                    damage = (E_Stats[2] - DEF);
                    if (damage <= 0)
                    { damage = 0;  }
                    current_HP -= damage;
                    Console.WriteLine($"The enemy deals {damage} damage!");
                    Console.WriteLine($"You now have {current_HP}HP");
                    Console.ReadLine();

                    if (current_HP >= 0)
                    {
                        //Player's Turn
                        FightMenu(E_Stats);
                        Console.WriteLine($"{Enemy_Name} HP: {E_Stats[1]}/{E_Stats[0]}");
                    } 
                }
                if (E_Stats[1] <= 0)
                {
                    // Player Has Defeated the Enemy
                }
            }

            public static void FightMenu(int[] E_Stats)
            {
                int choice, damage;

                do
                {
                    Console.WriteLine("\t\tI-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I");
                    Console.WriteLine("\t\tI                                           I");
                    Console.WriteLine("\t\tI            1: Attack                      I");
                    Console.WriteLine("\t\tI            2: Items                       I");
                    Console.WriteLine("\t\tI            3: Check                       I");
                    Console.WriteLine("\t\tI                                           I");
                    Console.WriteLine("\t\tI-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I-I");

                    string temp = Console.ReadLine();
                    choice = Convert.ToInt32(temp);
                    Console.Clear();
                    Console.WriteLine("\x1b[3J");


                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("You attack");
                            damage = (ATT - DEF);
                            if (damage <= 0)
                            { 
                                damage = 0; 
                            }
                            E_Stats[1] -= damage; //Enemy Current HP - Damage
                            if (E_Stats[1] <= 0)
                            { 
                                E_Stats[1] = 0; 
                            }
                            Console.WriteLine($"You deal {damage} damage!");
                            Console.ReadLine();
                            break;

                        case 2:
                            //check items
                            break;

                        case 3:
                            //check player stats
                            check();
                            break;

                        default:
                            Console.WriteLine("Invalid Input, Try Again");
                            Console.ReadLine();
                            break;

                    }
                    Console.Clear();
                    Console.WriteLine("\x1b[3J");
                } while (choice != 1);

            }

            public static void check()
            {
                while (XP > Required)
                {
                    LVL += 1;
                    DEF += 1;
                    ATT += 2;
                    current_HP = max_HP;

                    XP -= Required;
                    Required += 20;
                }
                Console.WriteLine("Player Stats:");
                Console.WriteLine($"\tHP  : {max_HP}/{current_HP}");
                Console.WriteLine($"\tATT : {ATT}");
                Console.WriteLine($"\tDEF : {DEF}");
                Console.WriteLine($"\tSPD : {SPD}");
                Console.WriteLine();
                Console.WriteLine($"\tLVL : {LVL}");
                Console.WriteLine($"\tXP  : {XP}");
                Console.WriteLine();
                Console.WriteLine($"\tArmed with Nothing but your GrandFather's Sword");
                Console.ReadLine();
            }

            public static int[] Items(int[] item_List)
            {

                return item_List;
            }

            // Enemies
            public static int[] Pepefrog()
            {
                //Pepe battle
                //ORDER -- max_HP, current_HP, ATT, DEF, SPD, LVL
                int[] Pepefrog_Stats = new int[6] { 50, 50, 3, 5, 5, 2};
                Enemy_Name = "Pepe Frog";

                string[] pepe = { "                     @%##******##%@          @@%###%@                 \r\n                   %#*++++++++++++**#%   @#***++++++***%              \r\n                 %**+++++++++++++++++**#**++++++++++++++*@            \r\n               %#*+++++++++++++++++++++***+++++++++++++++*%           \r\n              @*+++++++**#*+++++++*##*++**++++++++++++++++*@          \r\n             %*++++++*#+++++++++++++++**###################%%         \r\n            %*+++++++++++++++++++++++++++*#*+++++++++++++++++*#%%     \r\n           %*+++++++++++++++******###*******#**+++****######*****%    \r\n         %%*+++++++++++++*********************##*#*****************#@ \r\n      @#*+**++++++++++********+++++++++++++++*****+++++++**********#%@\r\n     %*++***+++++++********+++++++**++==-::::::=+**+=--:=%%%%#*:..:-+%\r\n    %*+++**++++++++***##***#*+=-::+%=*@@@@*....-:......*@@+#@@@@#....=\r\n   #*+++++++++++++++++++**=......#@@@@@+-%@%:.::......=@@@@@*:#@@+..=#\r\n  %*++++++++++++++++++++**++*=..-%@@*+@@@@@@%*+#*++=:.+@@@@@@@@%#**#% \r\n %#+++++++++++++++++++++++*##***+++++++++++*****++++++++++++++++*#@   \r\n #++++++++++++++++++++++++++++++***********+++++++++++++++++++*#@     \r\n@*+++++++++++++++++++++++++++++++++++***#*++++++************#%@       \r\n%++++++++++++++++++++++++++++++++*****+++++++++++++****++++++*%       \r\n%++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++#@     \r\n#+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*@    \r\n#+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*#    \r\n#+++++++++++++++++++++#######*++++++++++++++++++++++++++++++++++*%@   \r\n#++++++++++++++++++*#*************#####*++++++++++++++++++++*##***#%  \r\n%+++++++++++++++++******####*******************##########*********%   \r\n%+++++++++++++++++***************#####*************************#@     \r\n@*++++++++++++++**+**###**##************************************@     \r\n #*+++++++++++++****++++++++++++******************************#%      \r\n @%**+++++++++++++****+++++++++++++++++++++++++++********%@@@         \r\n@%###*#**+++++++++++++++++++++++++++++++++++++++++++++*#%             \r\n@#######***##*++++++++++++++++++++++++++++++++++++*#%%                \r\n@###########*+****#####***+++++++++++++++++**##%%%                    \r\n@#############%%%#**+++++++++++++++++++++++*#%##%@                    \r\n@############################%%%%%%%%%%###########%@                  \r\n@###################################################%%@               \r\n@#####################################################%@              \r\n@%##################%#%######%#%#######################@              " };
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(pepe[0]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Pepe the frog has appeared!!");

                return Pepefrog_Stats;
            }
            public static int[] BigChungus()
            {
                //big chungus battle
                //ORDER -- max_HP, current_HP, ATT, DEF, SPD, LVL
                int[] BigChungus_Stats = new int[6] { 40, 40, 3, 5, 5, 2 };
                Enemy_Name = "Big Chungus";

                string[] chungus = { "                                                                                                         \r\n                                            #               #                                            \r\n                                            #              ###                                           \r\n                                            ##             ###                                           \r\n                                            ###            ###                                           \r\n                                           #####          ####                                           \r\n                                           ######         #####                                          \r\n                                           ######        ######                                          \r\n                                          #### ##        #######                                         \r\n                                          #### ###      #### ###                                         \r\n                                          ####  ##      #### ###                                         \r\n                                          #### ####     ########                                         \r\n                                          #########    #########                                         \r\n                                          #########    #########                                         \r\n                                          ##########   #########                                         \r\n                                          ##########   #########                                         \r\n                                          #### #####   #########                                         \r\n                                          ##########   ########                                          \r\n                                           #########   ########                                          \r\n                                           ########    #######                                           \r\n                                            #######    #######                                           \r\n                                            #######     #####                                            \r\n                                             ######     #####                                            \r\n                                              #####      ###                                             \r\n                                              ####  ###### #                                             \r\n                                               ###############                                           \r\n                                                ################                                         \r\n                                               ##################                                        \r\n                                              ###################                                        \r\n                                              ####################                                       \r\n                                              ##########  ########                                       \r\n                                              ############ ######        #                               \r\n                                           # #####         #### ## ##                                    \r\n                                             ###########  #  ##  ######                                  \r\n                                             # #   ##########  ##   ##                                   \r\n                                             ###     #######      ####                                   \r\n                                            ######      ##########  ###                                  \r\n                                            ######       #######     ##                                  \r\n                                          #########                  #                                   \r\n                                       ################             ##                                   \r\n                                     ########################### ######                                  \r\n                                   ###########  #######   ###   #########                                \r\n                                 #############     ###  #       ###########                              \r\n                              ###############  #                        #####                            \r\n                            #################                          # #####                           \r\n                          #################                            ## ######                         \r\n                         #################                             ### #######                       \r\n                        #################  #                             # ########                      \r\n                       ################   ## ##                          ###########                     \r\n                      ###############   ####                             ############                    \r\n                     ##     ########  #######                             ######    ##                   \r\n                     ### #   ######  ###########                         #########  ##                   \r\n                    ## #       ##############  ##                        ##  ##   # # #                  \r\n                     # #  #        ############                          ##         # #                  \r\n                    ## #     ################## #                        #######      #                  \r\n                    ##        ################ # #                         ####  #   ##                  \r\n                     ##        ################# #                      ######  ## ###                   \r\n                      ###  ##   ################ ###     #            ######  ### ###                    \r\n                       ###   #   ################ #####             ###############                      \r\n                       #####  ################################################                           \r\n                       #######################################################                           \r\n                        #####################################################                            \r\n                        #####################################################                            \r\n                         ###################################################                             \r\n                          ################################################                               \r\n                           ################################################                              \r\n                            #################################################                            \r\n                              ##########################################   #  #                          \r\n                                 #####################################     #####                         \r\n                   ##############################################       ######                           \r\n                 #######    ###################     ######################                               \r\n                 #    ####     ##############                                                            \r\n                ##  ##              #####                                                                \r\n                #######     ########                                                                     \r\n                 ##############                                                                          \r\n                                                                                                         \r\n                                                                                                         " };
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(chungus[0]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Big Chungus has appeared!!");
                Console.WriteLine("HP 40/40");

                return BigChungus_Stats;
            }
            //public static int[] PeterGriffin()
            //{
                //Peter Griffin potential battle
                //ORDER -- max_HP, current_HP, ATT, DEF, SPD, LVL
                //int[] PeterGriffin_Stats = new int[6] { 60, 35, 3, 5, 5, 2 };

                //string[] Peter = { "                                  ypnoijlpll                                                        \r\n                                z0qssrnqsmnspt                                                      \r\n                                esrnrskqilllfn                                                      \r\n                               ykssqcdbf9ossrjy                                                     \r\n                               yjssssspfssssrhyzrg5XTPPTY5grz                                       \r\n                               zbssssrqrsssgfx4TQPQRSSSSSSSST6u                                     \r\n                               zassssssssssezp0nlnssofmmlpoVS9njz                                   \r\n                               zfsssssssssr2n7y  xicdx  z98Xdqormy                                  \r\n                               yksssssssqemsqs8qssrotz zrrssssssprz      z                          \r\n                               xnssssssnisssslnsssqssnlnrsssssssshw                                 \r\n                               xqsssssrissssqerrrrssl1HF6ssssssssse                                 \r\n                              ylmsssssnrssssssss4EEEEEEECrssssssssex                                \r\n                              vfsfsssshosssssssr2EEEECFImsssssssssst                                \r\n                              ymq zvkj9msssjeosssog40cfsssssssssssto                                \r\n                              ysxw    losssslrsssssssssssssssssssssisz                              \r\n                                0jyyyzpqsssqhmsssssssssssssssssssrl gqz                             \r\n                                uz  zxssssnrsssssssssqssssssssssoqzwozqpx                           \r\n                                z7   zressr0sss0isss0ssssssssss9xzqrz  zot                          \r\n                                 sy  zvzipsssssssnhnssssssssqjtwqmuz      my                        \r\n                                 zj   xkzwkssssssssssssssslluznw          xqz                       \r\n                                  rq    tsz mmrssssssspnht  ysy            zjz                      \r\n                                  zmyzy  xpu  vchrkblrx   xlnw               pw                     \r\n                                   zbxs     pmzyzm   ozykgz i             zz  qtz                   \r\n                                    zgq        whv   yqz   jy             vv    mw                  \r\n                                    wj         zvy         u              bqz   zpt                 \r\n                                   tm          ul        vmz    zqnpuz   rv       mz                \r\n                                  vqz       zryc         umtvux     zwpwyn        xp                \r\n                                  sz          p          vzyxxxyz     zsn         xn                \r\n                                 vp          xu          khpsssqlmnsz spjz        jz                \r\n                                 b          zgx          trsssssssssku nl        iIz                \r\n                                z1         tqz          tossssssssssserqy     sp4FHh                \r\n                                 3         zxy         znssssssssssrpvz      0QHFLPb                \r\n                                 vr         zwz     ztnirsssssssssskx     t6FGPMPPNs                \r\n                                  voz        tz    umssssssssssssshzwutaUJEEJNPPPP6                 \r\n                                    xdnuhx  yotw   wfe9sssssssssqnqVDEEEFJPPPPPPPXq                 \r\n                                     mGEFQU9mx ypq lksssssssssss0KPJILNPPPPPPPPPQo                  \r\n                                     w6PPPLIFEhkkkkgkssssssssssqPPPPPPPPPPPPPPPOx                   \r\n                                      wWPPPPPPPZ0bc03N0psrqssqaPPPPPPPPPPPPPPQ8x                    \r\n                                     lQPPPPPPPPPPPPPPPPQONU1URPPPPPPPPPPPPPPUtz                     \r\n                                    mQPPPPPPPPPPPPPPPPOOPPPPPPPPPPPPPPPPPPPdz                       \r\n" };
                //Console.WriteLine(Peter[0]);
                //Console.WriteLine("PeterGriffin has appeared!!");
                //Console.ReadLine();
                //return PeterGriffin_Stats;
            //}

            public static int[] DatBoi()
            {
                Console.Clear();
                Console.WriteLine("Dat Boi!!!");
                //ORDER -- max_HP, current_HP, ATT, DEF, SPD, LVL
                int[] DatBoi_Stats = new int[6] { 60, 60, 3, 5, 7, 4 };
                Enemy_Name = "Dat Boi";

                //potential final boss dat boi
                string[] datBoi = { "                                ++++++++++              \r\n                            +++++++++++$&Xxx            \r\n                            XXXXXx+++++XXxxxX           \r\n                             $$$$$$XXx+++++++x          \r\n                              $$$$$$$$$$Xx++++X         \r\n                                $$$$$XXXXx+++++         \r\n                                 XXXXXxxx++++++x        \r\n                                 XXxxxxx+++++++Xx       \r\n                                xXXxxxxxxxx++++Xxx      \r\n                           +XXx+xXXXxxxxxxxX+++++x      \r\n                      ++++++xxXX$$xXxxx+++++xX+++xX     \r\n                 +++++++xXXX$$$   XXx+++++++xxX+++++++  \r\n              ;+++xxX$$$$$        Xxx+++++++x++++xX+    \r\n         +xXXXXX$                xXXx++++xxxx++xXX$     \r\n           +XX$$                  XXXxxxxxxxxxxx++X     \r\n                                  XXXXXXXXXXXXXX+++x    \r\n                                 XxXXXXXXXXXXXXXx+++x   \r\n                                xxxxXXXXXXXXXX$$X++++x  \r\n                               XxxXXXX$$$$$$$$$$$++++xx \r\n                              XXXXXXX$$$&$$$$$$$$x++++xX\r\n                              XXXX$$$$$$&&&$$$$&$X+++++X\r\n                            xxX$$&&$ $X$$$$XX$$$&$x+++xX\r\n                           xxX$$$     $& x+x      X+++xX\r\n                           xxxX$$        +xX      Xx++xX\r\n                           XX+xXX$       +x        +++XX\r\n                             XxxxX$      ++       ++++xX\r\n                               XXxX$$   +x++     x++++XX\r\n                                  XX$$&&&$xx$&&  x+++xX \r\n                                 $$$$$$&$$xX&&&&$+++xXX \r\n                               $$$$$$$XX$x+X$&&&$+++xXX \r\n                              $$$$$$$$$XX++xX $$X+++X$  \r\n                             $$$X$  X$ +X;+X  &$x++xX   \r\n                            $$$$$$& $$X+x+++ &$x+++X$X  \r\n                           X$$x$ $$$ $X+X+++$$ x++x$$$  \r\n                           $$x$   &$$$xXX++$$ Xx+xX$$$$ \r\n                          X$$X$$$$$  $xxXX+XXXX++X$$$$$ \r\n                          $$X$  $&$&$$xX$$+xx$x+xX$$$$$ \r\n                          $$X&  &$$&&XX$$x++++++xX $$$$ \r\n                          $$X&$$$$&$&&$&$$x+ x++X$$$$$$ \r\n                          $$$$$   $&$$$$$$++;++XX$$$$$  \r\n                          X$$X$$$$$$$$$$$$+Xx++$  $$$$  \r\n                           $$X$$$$ $$$$$$$+Xx+X $$$$$   \r\n                           $$$$$  $$$ $$&X+++xX $$$$$   \r\n   &&&&&&&&&&&&&&&&&&&&&&&&&&$$$$$$$ $$$ $+++++X$$$$    \r\n            &&&&&&&&&&&&&&&&&&&$$$&&&&&& XxX$$$$Xx+     \r\n                           &&&&&&$$$$&&&&&&&$$$&&&      \r\n                      &&&&&   &&&&&&$$$$$&&&&&&&&       \r\n                      &&&&&&&&&&&&&&&&&&&&&&&&&         " };
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                foreach (string boi in datBoi)
                {
                    Console.WriteLine(boi);
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();

                return DatBoi_Stats;
            }

            // Rooms or Places
            public static String Pathway()
            {
                string choice;
                //Pathway Chosen ascii
                //When presented in story ask user to input L for left or R for right (path choice)
                string[] Pathway = { "                                                                                                    \r\n                                                                                                    \r\n                  AAAAAA                                                    AAAAAA                  \r\n                AAAAAAAAA                                                  AAAAAAAAA                \r\n              AAAAAAAAAAA                                                  AAAAAAAAAAA              \r\n            AAAAAAA AAAAA                                                  AAAAA AAAAAAA            \r\n          AAAAAAA   AAAAA                                                  AAAAA   AAAAAAA          \r\n        AAAAAAAA    AAAAAAAAAAAA                                    AAAAAAAAAAAA    AAAAAAAA        \r\n       AAAAAAA      AAAAAAAAAAAAAAAAA                          AAAAAAAAAAAAAAAAA      AAAAAAA       \r\n     AAAAAAA         AAAAAAAAAAAAAAAAAAAA                  AAAAAAAAAAAAAAAAAAAA         AAAAAAA     \r\n   AAAAAAA                       AAAAAAAAAAA            AAAAAAAAAAAA                      AAAAAAA   \r\n AAAAAAA                             AAAAAAAAA        AAAAAAAAA                             AAAAAAA \r\n AAAAAA                                 AAAAAAAA    AAAAAAAA                                  AAAAA \r\n AAAAAAA                                   AAAAAAAAAAAAAA                                   AAAAAAA \r\n  AAAAAAAA                                   AAAAAAAAAA                                   AAAAAAAA  \r\n    AAAAAAA                                    AAAAAA                                    AAAAAAA    \r\n      AAAAAAA       AAAAAAAAAAA                 AAAA                 AAAAAAAAAAA       AAAAAAA      \r\n        AAAAAAA     AAAAAAAAAAAAAAA                              AAAAAAAAAAAAAAA     AAAAAAA        \r\n          AAAAAAA   AAAAAAAAAAAAAAAAA                          AAAAAAAAAAAAAAAAA   AAAAAAA          \r\n            AAAAAAA AAAAA      AAAAAAAA                      AAAAAAAA      AAAAA AAAAAAAA           \r\n             AAAAAAAAAAAA        AAAAAAA                    AAAAAAA        AAAAAAAAAAAA             \r\n               AAAAAAAAAA          AAAAAAA                AAAAAAA          AAAAAAAAAA               \r\n                 AAAAAAA             AAAAAA               AAAAA             AAAAAAA                 \r\n                                      AAAAA              AAAAA                                      \r\n                                       AAAAA            AAAAA                                       \r\n                                       AAAAA            AAAAA                                       \r\n                                        AAAAA          AAAAA                                        \r\n                                        AAAAA          AAAAA                                        \r\n                                        AAAAA          AAAAA                                        \r\n                                        AAAAA          AAAAA                                        \r\n                                        AAAAA          AAAAA                                        \r\n                                        AAAAA          AAAAA                                        \r\n                                        AAAAA          AAAAA                                        \r\n                                        AAAAA          AAAAA                                        \r\n                                        AAAAA          AAAAA                                        \r\n                                        AAAAA          AAAAA                                        \r\n                                        AAAAA          AAAAA                                        \r\n                                        AAAAA          AAAAA                                        \r\n                                        AAAAA          AAAAA                                        \r\n                                        AAAAA          AAAAA                                        \r\n                                        AAAAA          AAAAA                                        \r\n                                        AAAAA          AAAAA                                        \r\n                                        AAAAAAAAAAAAAAAAAAAA                                        \r\n                                        AAAAAAAAAAAAAAAAAAAA                                        \r\n                                         AAAAAAAAAAAAAAAAAA                                         \r\n                                                                                                    " };
                foreach (string Path in Pathway)
                {
                    Console.WriteLine(Path);
                }
                Thread.Sleep(300);
                Console.WriteLine("You come up to path with 2 options Left or Right"); 
                Thread.Sleep(1000);
                Console.WriteLine("To your left is a field overflowing with carrots, but strangely, no rabbits.");
                Thread.Sleep(1000);
                Console.WriteLine("To your right, a mysterious forest with a large surrounding pond hums with energy.");
                Thread.Sleep(1000);
                
                do
                {
                    Console.Write("Please enter L for left or R for right: ");

                    choice = Console.ReadLine();
                    //Choose pathway to next encounter

                    switch (choice.ToUpper())
                    {
                        case "L":
                            Console.Clear();
                            Console.WriteLine("\x1b[3J");
                            Console.WriteLine("The grass is thick and there are so many carrots");
                            Thread.Sleep(2000);
                            Console.WriteLine("As you continue along suddenly something jumps out from the tall grass!!");
                            Thread.Sleep(3000);
                            BigChungus();
                            break;

                        case "R":
                            Console.Clear();
                            Console.WriteLine("\x1b[3J");
                            Console.WriteLine("You are walking along the path of the forest you notice ripples in the water...");
                            Thread.Sleep(2000);
                            Console.WriteLine("suddenly something jumps out of the water at you!!");
                            Thread.Sleep(3000);
                            Pepefrog();
                            break;


                        default:
                            Console.WriteLine("\nInvalid Input");
                            break;
                    }
                    
                } while (choice == "");
                Console.Clear();
                Console.WriteLine("\x1b[3J");

                return choice.ToUpper();
            }

                
            

                public static void PlayerWins()
            {
                //Ascii art for the games winning screen
                string[] WinningScreen = { " __   __           __        ___       _ \r\n \\ \\ / /__  _   _  \\ \\      / (_)_ __ | |\r\n  \\ V / _ \\| | | |  \\ \\ /\\ / /| | '_ \\| |\r\n   | | (_) | |_| |   \\ V  V / | | | | |_|\r\n   |_|\\___/ \\__,_|    \\_/\\_/  |_|_| |_(_)" };
                foreach (string Winning in WinningScreen)
                {
                    Console.WriteLine(Winning);
                }
                Console.ReadLine();
             }
                 public static void PlayerLoses()
             {
                //Ascii art for the games losing screen
                string[] LosingScreen = { " __   __            _                   _ \r\n \\ \\ / /__  _   _  | |    ___  ___  ___| |\r\n  \\ V / _ \\| | | | | |   / _ \\/ __|/ _ \\ |\r\n   | | (_) | |_| | | |__| (_) \\__ \\  __/_|\r\n   |_|\\___/ \\__,_| |_____\\___/|___/\\___(_)" };
                foreach (string Lose in LosingScreen)
                {
                    Console.WriteLine(Lose);
                }
                Console.ReadLine();
            }

            // Items
            public static int[] item1()
            {
                int[] item_stats = { };

                return item_stats;
            }
            public static int[] item2()
            {
                int[] item_stats = { };

                return item_stats;
            }
        }


        static void Main(string[] args)
        {
            //Game Code
            Intro();
           
            GuyatComputer();
            Console.WriteLine("You sit down at a computer. \nIt looks like this:\n");
            //Starting up Computer Animation?, before proceeding into Menu

            Menu();
            TextAdventure.Adventure();



            //bool win = true;

            ////play game

            ////if win
            //if (win == true)
            //{
            //    Console.WriteLine("You won! The pizza was delivered ahead of time and is still hot!");
            //}

            ////if lose
            //else
            //{
            //    Console.WriteLine("You lost! You take a bite of the pizza and pass away.");
            //}
            //insert animation


            //Console.Beep(2000, 1000);  

        }


        
    }
}
