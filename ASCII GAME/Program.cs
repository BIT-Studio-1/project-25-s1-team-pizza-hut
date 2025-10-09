using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ASCII_GAME
{
    internal class Program
    {
        public static void Intro()
        {

            string[] pizzaHutLogo = { "                                         ######++##                        \r\n                                  ############++++##                       \r\n                            ############++++++++++##                       \r\n                          #######+++++++++++++++++###                      \r\n                         ##++++++++++++++++++++++++###                     \r\n                        ##+++++++++++++++++++++++++##########              \r\n                       ##++++++++++++++++++++++++++++++###########         \r\n                      #++++++++++++++++++++++++++++++++++++++##########    \r\n                    ##++++++++++++++++++++++++++++++++++++++++++++######## \r\n                #####++++++++++++++++++++++++++++++++##############++++### \r\n             #####++++++++++++++++++++++###########################++++    \r\n          #####+++++++++++++++################################             \r\n       #####++++++++++###########+++######                                 \r\n     ####+++++#################+++++                                       \r\n  #####################      ++++++                                        \r\n##############               ++++             ############       ########  \r\n#######                       +               #############   ###########  \r\n            #######           ## ############# ##########   ######  ####   \r\n        ##############      #### ############    #######   ################\r\n        ###############    #####      ######   #######     ################\r\n          ####   #######  #####     ######   #####################         \r\n         #####     ##### #####   ########   ###############                \r\n        #####      ##### ##### ############# ##     ##                     \r\n       #####     ######  #### #########################   ###              \r\n      ######   ######    ###  #####################     #####              \r\n     ##############      ##      ###                   ############        \r\n    ######  #           ###     ####            # #############            \r\n    ######             ####    ####  ###       ### #######                 \r\n   ######             ####     ####  ####     ####   ####                  \r\n   #####             #####    ###########   ######  #####                  \r\n  #####             ############### #############   ####                   \r\n  #####        ###################  #############   ###          .-...     \r\n  ####         ###################  #######   ###   ##+..............-     \r\n   #             ######     #####     ##        ....+-..........    ###    \r\n                 ######     ####          ................          ###    \r\n                 #####       ##       ...............                      \r\n                 #####            .............                            \r\n                 ####        -............--                               \r\n                         -..............                                   \r\n                      .............                                        \r\n                      ........-                                            " };
            foreach (string logo in pizzaHutLogo) { Console.WriteLine(logo); }
            Console.WriteLine("Pizza Hut Games");
            Thread.Sleep(1000);
            Console.Write("\n\n.");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Clear();

            //insert animation of person sitting at pc
            Console.WriteLine("You sit down at a computer. \nIt looks like this:");
            //Starting up Computer Animation?, before proceeding into Menu

            Thread.Sleep(1000);
        }
        public static void Menu()
        {
            int choice;
            do
            {
                Console.WriteLine("\tMenu Options:");

                Console.WriteLine("\t\t1 Tic Tac Toe");
                Console.WriteLine("\t\t2 Battleships");
                Console.WriteLine("\t\t3 Minesweeper");
                Console.WriteLine("\t\t0 Shutdown");
                Console.WriteLine();
                Console.Write("\tChoice: ");

                choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Shutting Down...");
                        Thread.Sleep(1000);
                        break;

                    case 1:
                        T_T_T();
                        break;

                    case 2:
                        Battleships();
                        break;

                    case 3:
                        Minesweeper();
                        break;

                    default:
                        Console.WriteLine("Invalid Input, Try Again");
                        Console.ReadLine();
                        break;

                }

                Console.Clear();
            } while (choice != 0);
        }

        public static void T_T_T()
        {
            //If Making Tic Tac Toe use this method
            Console.WriteLine("This is Tic Tac Toe");
            Console.ReadLine();

            char[] pos = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int player = 1;
            int choice;

            int flag = 0;
        }

        public static void Battleships()
        {
            //If Making Battleships use this method
            Console.WriteLine("This is Battleships");
            Console.ReadLine();

            //generate board of coordinates
            for (int i = 1; i <= 10; i++)
            {
                for (char letter = 'A'; letter < 'J'; letter++)
                {
                    Console.Write($"{letter}{i}".ToString().PadLeft(5));
                }
            }
        }

        public static void Minesweeper()
        {
            //If Making Minesweeper use this method
            Console.WriteLine("This is Minesweeper");
            Console.ReadLine();
        }

        public class TextAdventure
        {
            // Text Adventure Code and Enemies

            //Character Stats
            public static int max_HP = 100, current_HP = 100, DEF = 5, ATT = 10, SPD = 10, LVL = 1, XP = 0, Required = 100;

            public static void Adventure()
            {
                //If Adding to Adventure Code use this method

                Console.WriteLine("This is the TextAdventure");
                Console.ReadLine();

                // Check New Stats after a battle
                check();
            }
            public static void check()
            {
                while ( XP > Required)
                {
                    LVL += 1;
                    DEF += 1;
                    ATT += 2;
                    current_HP = max_HP;

                    XP -= Required;
                    Required += 20;
                }
                Console.WriteLine($"HP  : {max_HP}/{current_HP}");
                Console.WriteLine($"DEF : {DEF}");
                Console.WriteLine($"ATT : {ATT}");
                Console.WriteLine($"SPD : {SPD}");
                Console.WriteLine($"LVL : {LVL}");
                Console.WriteLine($"XP  : {XP}");
            }

            public static void BigChungus()
            {
                ///big chungus
                string[] chungus = { "                                                                                                         \r\n                                            #               #                                            \r\n                                            #              ###                                           \r\n                                            ##             ###                                           \r\n                                            ###            ###                                           \r\n                                           #####          ####                                           \r\n                                           ######         #####                                          \r\n                                           ######        ######                                          \r\n                                          #### ##        #######                                         \r\n                                          #### ###      #### ###                                         \r\n                                          ####  ##      #### ###                                         \r\n                                          #### ####     ########                                         \r\n                                          #########    #########                                         \r\n                                          #########    #########                                         \r\n                                          ##########   #########                                         \r\n                                          ##########   #########                                         \r\n                                          #### #####   #########                                         \r\n                                          ##########   ########                                          \r\n                                           #########   ########                                          \r\n                                           ########    #######                                           \r\n                                            #######    #######                                           \r\n                                            #######     #####                                            \r\n                                             ######     #####                                            \r\n                                              #####      ###                                             \r\n                                              ####  ###### #                                             \r\n                                               ###############                                           \r\n                                                ################                                         \r\n                                               ##################                                        \r\n                                              ###################                                        \r\n                                              ####################                                       \r\n                                              ##########  ########                                       \r\n                                              ############ ######        #                               \r\n                                           # #####         #### ## ##                                    \r\n                                             ###########  #  ##  ######                                  \r\n                                             # #   ##########  ##   ##                                   \r\n                                             ###     #######      ####                                   \r\n                                            ######      ##########  ###                                  \r\n                                            ######       #######     ##                                  \r\n                                          #########                  #                                   \r\n                                       ################             ##                                   \r\n                                     ########################### ######                                  \r\n                                   ###########  #######   ###   #########                                \r\n                                 #############     ###  #       ###########                              \r\n                              ###############  #                        #####                            \r\n                            #################                          # #####                           \r\n                          #################                            ## ######                         \r\n                         #################                             ### #######                       \r\n                        #################  #                             # ########                      \r\n                       ################   ## ##                          ###########                     \r\n                      ###############   ####                             ############                    \r\n                     ##     ########  #######                             ######    ##                   \r\n                     ### #   ######  ###########                         #########  ##                   \r\n                    ## #       ##############  ##                        ##  ##   # # #                  \r\n                     # #  #        ############                          ##         # #                  \r\n                    ## #     ################## #                        #######      #                  \r\n                    ##        ################ # #                         ####  #   ##                  \r\n                     ##        ################# #                      ######  ## ###                   \r\n                      ###  ##   ################ ###     #            ######  ### ###                    \r\n                       ###   #   ################ #####             ###############                      \r\n                       #####  ################################################                           \r\n                       #######################################################                           \r\n                        #####################################################                            \r\n                        #####################################################                            \r\n                         ###################################################                             \r\n                          ################################################                               \r\n                           ################################################                              \r\n                            #################################################                            \r\n                              ##########################################   #  #                          \r\n                                 #####################################     #####                         \r\n                   ##############################################       ######                           \r\n                 #######    ###################     ######################                               \r\n                 #    ####     ##############                                                            \r\n                ##  ##              #####                                                                \r\n                #######     ########                                                                     \r\n                 ##############                                                                          \r\n                                                                                                         \r\n                                                                                                         " };
                foreach (string chung in chungus) { Console.WriteLine(chung); }
                
                Console.ReadLine();
            }

            public static void DatBoi()
            {
                //potential final boss dat boi
                string[] datBoi = { "                                ++++++++++              \r\n                            +++++++++++$&Xxx            \r\n                            XXXXXx+++++XXxxxX           \r\n                             $$$$$$XXx+++++++x          \r\n                              $$$$$$$$$$Xx++++X         \r\n                                $$$$$XXXXx+++++         \r\n                                 XXXXXxxx++++++x        \r\n                                 XXxxxxx+++++++Xx       \r\n                                xXXxxxxxxxx++++Xxx      \r\n                           +XXx+xXXXxxxxxxxX+++++x      \r\n                      ++++++xxXX$$xXxxx+++++xX+++xX     \r\n                 +++++++xXXX$$$   XXx+++++++xxX+++++++  \r\n              ;+++xxX$$$$$        Xxx+++++++x++++xX+    \r\n         +xXXXXX$                xXXx++++xxxx++xXX$     \r\n           +XX$$                  XXXxxxxxxxxxxx++X     \r\n                                  XXXXXXXXXXXXXX+++x    \r\n                                 XxXXXXXXXXXXXXXx+++x   \r\n                                xxxxXXXXXXXXXX$$X++++x  \r\n                               XxxXXXX$$$$$$$$$$$++++xx \r\n                              XXXXXXX$$$&$$$$$$$$x++++xX\r\n                              XXXX$$$$$$&&&$$$$&$X+++++X\r\n                            xxX$$&&$ $X$$$$XX$$$&$x+++xX\r\n                           xxX$$$     $& x+x      X+++xX\r\n                           xxxX$$        +xX      Xx++xX\r\n                           XX+xXX$       +x        +++XX\r\n                             XxxxX$      ++       ++++xX\r\n                               XXxX$$   +x++     x++++XX\r\n                                  XX$$&&&$xx$&&  x+++xX \r\n                                 $$$$$$&$$xX&&&&$+++xXX \r\n                               $$$$$$$XX$x+X$&&&$+++xXX \r\n                              $$$$$$$$$XX++xX $$X+++X$  \r\n                             $$$X$  X$ +X;+X  &$x++xX   \r\n                            $$$$$$& $$X+x+++ &$x+++X$X  \r\n                           X$$x$ $$$ $X+X+++$$ x++x$$$  \r\n                           $$x$   &$$$xXX++$$ Xx+xX$$$$ \r\n                          X$$X$$$$$  $xxXX+XXXX++X$$$$$ \r\n                          $$X$  $&$&$$xX$$+xx$x+xX$$$$$ \r\n                          $$X&  &$$&&XX$$x++++++xX $$$$ \r\n                          $$X&$$$$&$&&$&$$x+ x++X$$$$$$ \r\n                          $$$$$   $&$$$$$$++;++XX$$$$$  \r\n                          X$$X$$$$$$$$$$$$+Xx++$  $$$$  \r\n                           $$X$$$$ $$$$$$$+Xx+X $$$$$   \r\n                           $$$$$  $$$ $$&X+++xX $$$$$   \r\n   &&&&&&&&&&&&&&&&&&&&&&&&&&$$$$$$$ $$$ $+++++X$$$$    \r\n            &&&&&&&&&&&&&&&&&&&$$$&&&&&& XxX$$$$Xx+     \r\n                           &&&&&&$$$$&&&&&&&$$$&&&      \r\n                      &&&&&   &&&&&&$$$$$&&&&&&&&       \r\n                      &&&&&&&&&&&&&&&&&&&&&&&&&         " };
                foreach (string boi in datBoi) { Console.WriteLine(boi); }
                Console.ReadLine();
            }
            public static void Pathway()
            {
                //Pathway Chosen ascii
                string[] Pathway = { "                                                                                                    \r\n                                                                                                    \r\n                  AAAAAA                                                    AAAAAA                  \r\n                AAAAAAAAA                                                  AAAAAAAAA                \r\n              AAAAAAAAAAA                                                  AAAAAAAAAAA              \r\n            AAAAAAA AAAAA                                                  AAAAA AAAAAAA            \r\n          AAAAAAA   AAAAA                                                  AAAAA   AAAAAAA          \r\n        AAAAAAAA    AAAAAAAAAAAA                                    AAAAAAAAAAAA    AAAAAAAA        \r\n       AAAAAAA      AAAAAAAAAAAAAAAAA                          AAAAAAAAAAAAAAAAA      AAAAAAA       \r\n     AAAAAAA         AAAAAAAAAAAAAAAAAAAA                  AAAAAAAAAAAAAAAAAAAA         AAAAAAA     \r\n   AAAAAAA                       AAAAAAAAAAA            AAAAAAAAAAAA                      AAAAAAA   \r\n AAAAAAA                             AAAAAAAAA        AAAAAAAAA                             AAAAAAA \r\n AAAAAA                                 AAAAAAAA    AAAAAAAA                                  AAAAA \r\n AAAAAAA                                   AAAAAAAAAAAAAA                                   AAAAAAA \r\n  AAAAAAAA                                   AAAAAAAAAA                                   AAAAAAAA  \r\n    AAAAAAA                                    AAAAAA                                    AAAAAAA    \r\n      AAAAAAA       AAAAAAAAAAA                 AAAA                 AAAAAAAAAAA       AAAAAAA      \r\n        AAAAAAA     AAAAAAAAAAAAAAA                              AAAAAAAAAAAAAAA     AAAAAAA        \r\n          AAAAAAA   AAAAAAAAAAAAAAAAA                          AAAAAAAAAAAAAAAAA   AAAAAAA          \r\n            AAAAAAA AAAAA      AAAAAAAA                      AAAAAAAA      AAAAA AAAAAAAA           \r\n             AAAAAAAAAAAA        AAAAAAA                    AAAAAAA        AAAAAAAAAAAA             \r\n               AAAAAAAAAA          AAAAAAA                AAAAAAA          AAAAAAAAAA               \r\n                 AAAAAAA             AAAAAA               AAAAA             AAAAAAA                 \r\n                                      AAAAA              AAAAA                                      \r\n                                       AAAAA            AAAAA                                       \r\n                                       AAAAA            AAAAA                                       \r\n                                        AAAAA          AAAAA                                        \r\n                                        AAAAA          AAAAA                                        \r\n                                        AAAAA          AAAAA                                        \r\n                                        AAAAA          AAAAA                                        \r\n                                        AAAAA          AAAAA                                        \r\n                                        AAAAA          AAAAA                                        \r\n                                        AAAAA          AAAAA                                        \r\n                                        AAAAA          AAAAA                                        \r\n                                        AAAAA          AAAAA                                        \r\n                                        AAAAA          AAAAA                                        \r\n                                        AAAAA          AAAAA                                        \r\n                                        AAAAA          AAAAA                                        \r\n                                        AAAAA          AAAAA                                        \r\n                                        AAAAA          AAAAA                                        \r\n                                        AAAAA          AAAAA                                        \r\n                                        AAAAA          AAAAA                                        \r\n                                        AAAAAAAAAAAAAAAAAAAA                                        \r\n                                        AAAAAAAAAAAAAAAAAAAA                                        \r\n                                         AAAAAAAAAAAAAAAAAA                                         \r\n                                                                                                    " };
                foreach (string Path in Pathway) { Console.WriteLine(Path); }

                Console.ReadLine();
            }
            public static void GuyatComputer()
            {
                //The games menu
                string[] GuyatComputer = { "                                                                     MMMMMMMMMMMMMMMMM            \r\n                                                                     MMMMMMMMMMMMMMMMMMM          \r\n               WVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV        MOPPPPOMMMMMMMMMMMMMM        \r\n            ZZYWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW       ZYYYYYYWQMMMMMMMMMMMMM       \r\n            ZZXWZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZWWX      YYYYYYYYWQMMMMMMMMMMMM       \r\n            ZZXWYZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZWWX     ZYYYVWYYYXSMNNMMMMMMMMML      \r\n            ZZXWXZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZYWWX     ZYYVLPYYYXSMSXUNMMMMMMM       \r\n            ZZXWXZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZYWWX    ZZYYYYYYYYXTNSXYPMMMMMMN       \r\n            ZZXWXZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZYWWX   ZZZYYWVVYYYYYYYXRMMMMMMN        \r\n            ZZXWXZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZYWWX   ZZZZYYXXYYYYYYYYVOMMMMN         \r\n            ZZXWXZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZYWWX    YZYYYYYYYYYYYYYYUNMMN          \r\n            ZZXWXZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZYWWX      YYYYYYYYYYYYYYXW             \r\n            ZZXWXZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZYWWX      YYYYYYYYYYXWWWWW             \r\n            ZZXWXZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZYWWX        YYYYZXXXXXXXXXX            \r\n            ZZXWXZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZYWWX            VWWWWWWWWWUUT          \r\n            ZZXWXZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZYWWX         XXXXWVUUUUUUUUUUUUV       \r\n            ZZXWXZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZYWWX       XXXXXXXXWUUUUUUUUUUUUU      \r\n            ZZXWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWX     XXXXXXTTTTSRQQQQQQQQQQQQONONN \r\n            ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ     XXXXXTOOONKIIIIIIIIIIIIIIIIIIIK\r\n            ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ   XXXXXXXSOOONKIIIIIIIIIIIIIIIIIIII\r\n            ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ  XXXXXXXXSOOONKIIIIIIIIIIIIIIIIIIII\r\n                              ZZZZZZZZZZZZZZZZ                XXXXXXXXXXSOOONKIIIIIIJWWWWVNHIIIIII\r\n                              ZZZZZZZZZZZZZZZZZUUXXXXXXXXXXXXXXXXXXXXXXXROOONKIIIIIIJZZZZZOGGHIIII\r\n                              ZZZZZZZZZZZZZZZZZVUXXXXXXXXXXXXXXXXXXXXXWUQOOONKIIIIIIJZZZZZOFFGHHII\r\n                              ZZZZZZZZZZZZZZZZZVUXXXXXXXXXXXXXXXXXXXXXUUQOOONKIIIIIIJZZZZZOFFFFGHH\r\n                        ZZZZZZZZZZZZZZZZZZZZZZZVVXXXXXXXXXXXXXXXXXXXX UUUPONLHGGGGGGHZZZZZOFFFFFFG\r\nWWWWWWWWWWWWWWWWWWWWWWWTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTUUUTTTTTTTTTTUZZZZZWTSSSSTS\r\nWWWWWWWWWWWWWWWWWWWWWWWSRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRTVWUUUUUUUUUUUUZZZZZWUSRRRRR\r\nWWWWWWWWWWWVUTUVWWWWWWWSRRRRRRRRQRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRSRQTUUUUUUUUUUUUUUZZZZZWUTRRRRR\r\n           VTQPP             WURPPQ                               VVTQSUVUUUUUUUUUUUUZZZZZWTT     \r\n           WTRRQ             WUSRQQ                               VWTRTUVUUUUUUUUUUUUZZZZZWTT     \r\n           WTRRR             WUSRRR                       OPPQQQQQRUSRSTTTTTTTTTTTTTTZZZZZWTT     \r\n           WTRRR             WUSRRR                    OPPPPPPPPPPPPPPPPPPPPPPPPPPPPQZZZZZUPP     \r\n           WTRRR             WUSRRR                   QPPPPPPPPPPPPPPPPPPPPPPPPPPPPPQZZZZZUPP     \r\n           WTRRR             WUSRRR                  PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPQZZZZZY       \r\n           WTRRR             WUSRRR                  PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPQZZZZZZ       \r\n           WTRRR             WUSRRR                  QPPPOOOOOOOOOOOOOOOMIIIIIIIIIIIJZZZZZOGHHIIIH\r\n           WTRRR             WUSRRR                  QPPPOOOOOOOOOOOOOOOOJIIIIIIIIIIJZZZZZOFFGHIII\r\n           WTRRR             WUSRRR                  QPPPPOOOOOOOOOOOOOMIHGGGGGHJJJJOZZZZZOFFFFHHI\r\n           WTRRR             WUSRRR                  QPPPPPPPO  MMMMMMMMM  ZZYWWWXXVTTUZZ         \r\n           WTRRR             WUSRRR                  QPPPPPPPP  NMMMMMMMN  ZZYVVWWWUSRR           \r\n           WTRRR             WUSRRR                  QPPPPPPPP  NMMMMMMMN   ZZURRRWUSRR           \r\n           WTRRR             WUSRRR                  QPPPPPPPP  NMMMMMMMN   ZZXVTRVUSRR           \r\n           WTRRR             WUSRRR                  QPPPPPPPP  NMMMMMMMN   ZZYXWXVUSRR           \r\n           WTRRR             WUSRRR                  QPPPPPPPP  NMMMMMMMN   ZZYXWXVUSRR           \r\n           WTRRR             WUSRRR                  QPPPPPPPP  NMMMMMMMN   ZZYXWXVUSRR           \r\n           WTRRR             WUSRRR                  QPPPPPPPP  NMMMMMMMN   ZZYXWXVUSRR           \r\n           WTRRR             WUSRRR                  QPPPPPPPP  MMMMMMMMN   ZZYXWXVUSRR           \r\n           WTRRR             WUSRRR                KKMMMMMMMM GHJJOYZZZZZZUIJKNVYYYYXXYYYUKIIGG   \r\n           WTRRR             WUSRRR           LKKKKKKKKKKKKKKIHPZWIOUUUUZZIMZXJMXYYWWWWYWLMZZMGG  \r\n           WTRRR             WUSRRR           KKKKKKKKKKKKKKKIHHJIHJIIIIH GGJIGF  VUSRR  GHJJGG   " };
                foreach (string Guy in GuyatComputer) { Console.WriteLine(Guy); }
    ;
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            //Game Code
            Intro();
            Menu();

            bool win = true;

            //play game

            //if win
            if (win == true)
            {
                Console.WriteLine("You won! The pizza was delivered ahead of time and is still hot!");
            }

            //if lose
            else
            {
                Console.WriteLine("You lost! You take a bite of the pizza and pass away.");
            }
            //insert animation


            //Console.Beep(2000, 1000);  

        }


        
    }
}
