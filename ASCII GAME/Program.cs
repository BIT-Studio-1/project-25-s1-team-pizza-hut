namespace ASCII_GAME
{
    internal class Program
    {
        public static void Intro()
        {
            Console.WriteLine("Welcome to Pizza Hut Computer!");
            string[] pizzaHutLogo = { "                                         ######++##                        \r\n                                  ############++++##                       \r\n                            ############++++++++++##                       \r\n                          #######+++++++++++++++++###                      \r\n                         ##++++++++++++++++++++++++###                     \r\n                        ##+++++++++++++++++++++++++##########              \r\n                       ##++++++++++++++++++++++++++++++###########         \r\n                      #++++++++++++++++++++++++++++++++++++++##########    \r\n                    ##++++++++++++++++++++++++++++++++++++++++++++######## \r\n                #####++++++++++++++++++++++++++++++++##############++++### \r\n             #####++++++++++++++++++++++###########################++++    \r\n          #####+++++++++++++++################################             \r\n       #####++++++++++###########+++######                                 \r\n     ####+++++#################+++++                                       \r\n  #####################      ++++++                                        \r\n##############               ++++             ############       ########  \r\n#######                       +               #############   ###########  \r\n            #######           ## ############# ##########   ######  ####   \r\n        ##############      #### ############    #######   ################\r\n        ###############    #####      ######   #######     ################\r\n          ####   #######  #####     ######   #####################         \r\n         #####     ##### #####   ########   ###############                \r\n        #####      ##### ##### ############# ##     ##                     \r\n       #####     ######  #### #########################   ###              \r\n      ######   ######    ###  #####################     #####              \r\n     ##############      ##      ###                   ############        \r\n    ######  #           ###     ####            # #############            \r\n    ######             ####    ####  ###       ### #######                 \r\n   ######             ####     ####  ####     ####   ####                  \r\n   #####             #####    ###########   ######  #####                  \r\n  #####             ############### #############   ####                   \r\n  #####        ###################  #############   ###          .-...     \r\n  ####         ###################  #######   ###   ##+..............-     \r\n   #             ######     #####     ##        ....+-..........    ###    \r\n                 ######     ####          ................          ###    \r\n                 #####       ##       ...............                      \r\n                 #####            .............                            \r\n                 ####        -............--                               \r\n                         -..............                                   \r\n                      .............                                        \r\n                      ........-                                            " };
            foreach (string logo in pizzaHutLogo) { Console.WriteLine(logo); }
            Console.ReadLine();

            Console.WriteLine("You sit down at a computer. \nIt looks like this:");

            //insert animation of person sitting at pc
            Console.ReadLine();
        }
        public static void Menu()
        {
            int choice;
            do
            {
                Console.WriteLine("Menu Options:");

                Console.WriteLine("\t1 Task 1");
                Console.WriteLine("\t2 Task 2");
                Console.WriteLine("\t3 Task 3");
                Console.WriteLine("\t4 Task 4");
                Console.WriteLine("\t0 Exit menu system");
                Console.WriteLine();

                choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Shutting Down...");
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
                        Console.WriteLine("Invalid Input");
                        break;

                }

                Console.ReadLine();
                Console.Clear();
            } while (choice != 0);
        }

        public static void T_T_T()
        {
            //If Making Tic Tac Toe use this method
            Console.WriteLine("This is Tic Tac Toe");
        }
        public static void Battleships()
        {
            //If Making Battleships use this method
            Console.WriteLine("This is Battleships");
        }
        public static void Minesweeper()
        {
            //If Making Minesweeper use this method
            Console.WriteLine("This is Minesweeper");
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
