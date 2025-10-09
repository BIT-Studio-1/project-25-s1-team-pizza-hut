using System;
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
        }

        public static void Battleships()
        {
            //If Making Battleships use this method
            Console.WriteLine("This is Battleships");
            Console.ReadLine();
        }

        public static void Minesweeper()
        {
            //If Making Minesweeper use this method
            Console.WriteLine("This is Minesweeper");
            Console.ReadLine();
        }


        // Text Adventure Code and Enemies
        public static void TextAdventure()
        {
            //If Adding to TextAdventure Code use this method
            Console.WriteLine("This is the TextAdventure");
            Console.ReadLine();
        }
            public static void BigChungus()
            {
                ///big chungus
                string[] chungus = { "                                                                                                         \r\n                                            #               #                                            \r\n                                            #              ###                                           \r\n                                            ##             ###                                           \r\n                                            ###            ###                                           \r\n                                           #####          ####                                           \r\n                                           ######         #####                                          \r\n                                           ######        ######                                          \r\n                                          #### ##        #######                                         \r\n                                          #### ###      #### ###                                         \r\n                                          ####  ##      #### ###                                         \r\n                                          #### ####     ########                                         \r\n                                          #########    #########                                         \r\n                                          #########    #########                                         \r\n                                          ##########   #########                                         \r\n                                          ##########   #########                                         \r\n                                          #### #####   #########                                         \r\n                                          ##########   ########                                          \r\n                                           #########   ########                                          \r\n                                           ########    #######                                           \r\n                                            #######    #######                                           \r\n                                            #######     #####                                            \r\n                                             ######     #####                                            \r\n                                              #####      ###                                             \r\n                                              ####  ###### #                                             \r\n                                               ###############                                           \r\n                                                ################                                         \r\n                                               ##################                                        \r\n                                              ###################                                        \r\n                                              ####################                                       \r\n                                              ##########  ########                                       \r\n                                              ############ ######        #                               \r\n                                           # #####         #### ## ##                                    \r\n                                             ###########  #  ##  ######                                  \r\n                                             # #   ##########  ##   ##                                   \r\n                                             ###     #######      ####                                   \r\n                                            ######      ##########  ###                                  \r\n                                            ######       #######     ##                                  \r\n                                          #########                  #                                   \r\n                                       ################             ##                                   \r\n                                     ########################### ######                                  \r\n                                   ###########  #######   ###   #########                                \r\n                                 #############     ###  #       ###########                              \r\n                              ###############  #                        #####                            \r\n                            #################                          # #####                           \r\n                          #################                            ## ######                         \r\n                         #################                             ### #######                       \r\n                        #################  #                             # ########                      \r\n                       ################   ## ##                          ###########                     \r\n                      ###############   ####                             ############                    \r\n                     ##     ########  #######                             ######    ##                   \r\n                     ### #   ######  ###########                         #########  ##                   \r\n                    ## #       ##############  ##                        ##  ##   # # #                  \r\n                     # #  #        ############                          ##         # #                  \r\n                    ## #     ################## #                        #######      #                  \r\n                    ##        ################ # #                         ####  #   ##                  \r\n                     ##        ################# #                      ######  ## ###                   \r\n                      ###  ##   ################ ###     #            ######  ### ###                    \r\n                       ###   #   ################ #####             ###############                      \r\n                       #####  ################################################                           \r\n                       #######################################################                           \r\n                        #####################################################                            \r\n                        #####################################################                            \r\n                         ###################################################                             \r\n                          ################################################                               \r\n                           ################################################                              \r\n                            #################################################                            \r\n                              ##########################################   #  #                          \r\n                                 #####################################     #####                         \r\n                   ##############################################       ######                           \r\n                 #######    ###################     ######################                               \r\n                 #    ####     ##############                                                            \r\n                ##  ##              #####                                                                \r\n                #######     ########                                                                     \r\n                 ##############                                                                          \r\n                                                                                                         \r\n                                                                                                         " };
                foreach (string chung in chungus) { Console.WriteLine(chung); };
                Console.ReadLine();
            }

            public static void DatBoi()
            {
            //potential final boss dat boi
            string[] datBoi = { "                                ++++++++++              \r\n                            +++++++++++$&Xxx            \r\n                            XXXXXx+++++XXxxxX           \r\n                             $$$$$$XXx+++++++x          \r\n                              $$$$$$$$$$Xx++++X         \r\n                                $$$$$XXXXx+++++         \r\n                                 XXXXXxxx++++++x        \r\n                                 XXxxxxx+++++++Xx       \r\n                                xXXxxxxxxxx++++Xxx      \r\n                           +XXx+xXXXxxxxxxxX+++++x      \r\n                      ++++++xxXX$$xXxxx+++++xX+++xX     \r\n                 +++++++xXXX$$$   XXx+++++++xxX+++++++  \r\n              ;+++xxX$$$$$        Xxx+++++++x++++xX+    \r\n         +xXXXXX$                xXXx++++xxxx++xXX$     \r\n           +XX$$                  XXXxxxxxxxxxxx++X     \r\n                                  XXXXXXXXXXXXXX+++x    \r\n                                 XxXXXXXXXXXXXXXx+++x   \r\n                                xxxxXXXXXXXXXX$$X++++x  \r\n                               XxxXXXX$$$$$$$$$$$++++xx \r\n                              XXXXXXX$$$&$$$$$$$$x++++xX\r\n                              XXXX$$$$$$&&&$$$$&$X+++++X\r\n                            xxX$$&&$ $X$$$$XX$$$&$x+++xX\r\n                           xxX$$$     $& x+x      X+++xX\r\n                           xxxX$$        +xX      Xx++xX\r\n                           XX+xXX$       +x        +++XX\r\n                             XxxxX$      ++       ++++xX\r\n                               XXxX$$   +x++     x++++XX\r\n                                  XX$$&&&$xx$&&  x+++xX \r\n                                 $$$$$$&$$xX&&&&$+++xXX \r\n                               $$$$$$$XX$x+X$&&&$+++xXX \r\n                              $$$$$$$$$XX++xX $$X+++X$  \r\n                             $$$X$  X$ +X;+X  &$x++xX   \r\n                            $$$$$$& $$X+x+++ &$x+++X$X  \r\n                           X$$x$ $$$ $X+X+++$$ x++x$$$  \r\n                           $$x$   &$$$xXX++$$ Xx+xX$$$$ \r\n                          X$$X$$$$$  $xxXX+XXXX++X$$$$$ \r\n                          $$X$  $&$&$$xX$$+xx$x+xX$$$$$ \r\n                          $$X&  &$$&&XX$$x++++++xX $$$$ \r\n                          $$X&$$$$&$&&$&$$x+ x++X$$$$$$ \r\n                          $$$$$   $&$$$$$$++;++XX$$$$$  \r\n                          X$$X$$$$$$$$$$$$+Xx++$  $$$$  \r\n                           $$X$$$$ $$$$$$$+Xx+X $$$$$   \r\n                           $$$$$  $$$ $$&X+++xX $$$$$   \r\n   &&&&&&&&&&&&&&&&&&&&&&&&&&$$$$$$$ $$$ $+++++X$$$$    \r\n            &&&&&&&&&&&&&&&&&&&$$$&&&&&& XxX$$$$Xx+     \r\n                           &&&&&&$$$$&&&&&&&$$$&&&      \r\n                      &&&&&   &&&&&&$$$$$&&&&&&&&       \r\n                      &&&&&&&&&&&&&&&&&&&&&&&&&         " };  
                
            foreach (string boi in datBoi) { Console.WriteLine(boi); };
            Console.ReadLine();
            }


        static void Main(string[] args)
        {
            //Game Code
            Intro();
            Menu();


            //play game

            //if win
            Console.WriteLine("You won! The pizza was delivered ahead of time and is still hot!");

            //if lose
            Console.WriteLine("You lost! You take a bite of the pizza and pass away.");
            //insert animation


            //Console.Beep(2000, 1000);  
        
        }

        
    }
}
