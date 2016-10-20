using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeowMix
{
    class GameMenu
    {
       public static void Menu()
        {
            Console.Clear();
            string userInput; 
            Console.Title = "MeowMix";
            Console.ForegroundColor = ConsoleColor.DarkRed;
            string title = @"                                                                            
            @@@@@@@@@@   @@@@@@@@   @@@@@@   @@@  @@@  @@@  @@@@@@@@@@   @@@  @@@  @@@  
            @@@@@@@@@@@  @@@@@@@@  @@@@@@@@  @@@  @@@  @@@  @@@@@@@@@@@  @@@  @@@  @@@  
            @@! @@! @@!  @@!       @@!  @@@  @@!  @@!  @@!  @@! @@! @@!  @@!  @@!  !@@  
            !@! !@! !@!  !@!       !@!  @!@  !@!  !@!  !@!  !@! !@! !@!  !@!  !@!  @!!  
            @!! !!@ @!@  @!!!:!    @!@  !@!  @!!  !!@  @!@  @!! !!@ @!@  !!@   !@@!@!   
            !@!   ! !@!  !!!!!:    !@!  !!!  !@!  !!!  !@!  !@!   ! !@!  !!!    @!!!    
            !!:     !!:  !!:       !!:  !!!  !!:  !!:  !!:  !!:     !!:  !!:   !: :!!   
            :!:     :!:  :!:       :!:  !:!  :!:  :!:  :!:  :!:     :!:  :!:  :!:  !:!  
            :::     ::    :: ::::  ::::: ::   :::: :: :::   :::     ::    ::   ::  :::  
             :      :    : :: ::    : :  :     :: :  : :     :      :    :     :   ::   ";
            Console.WriteLine(title);           
           // Console.ReadLine();


            Console.WriteLine("\n Cats and dogs are at constant war. They don't want to kill but rather piss eachother off...You must decide which faction is best suited for you and continue the cycle of peskering one another!\n");

            Console.WriteLine("Choose a faction to begin your mission!\n");
            Console.Write("Choose between the FelineWarrior, Human Hunter or k9 faction\n");
            userInput = Console.ReadLine().ToLower();


            if (userInput == "felinewarrior")
            {
                string message = "NIIIIIICE! This factions uses hulking Whisker Brute and dander infested Fur Bawlz as its field troops. They have mind tricks naturally produced by their cuteness";
                Console.WriteLine(message);
                Console.ReadLine();
                GamePartOne();
                
            }
            else if (userInput == "human hunter")
            {
                string message = "Interesting choice, you have chosen to be a one man army. This pet hater of a human being roams the earth bagging and tagging stray pets. You will be frowned upon.";
                Console.WriteLine(message);
                Console.ReadLine();
                GamePartOne();
            }
            else if (userInput == "k9")
            {
                string message = "Awesome sawce! You chose the cunning but also wreckless faction. Uses all natural senses as well as fleas to annoy their foes!";
              
                Console.WriteLine(message);
                Console.ReadLine();
                GamePartTwo();
            }
            else 
            {
                string message = "What? That's not an option. Maybe in the next game...";

                Console.WriteLine(message);
                Menu();
            }
            Console.WriteLine("\n Welcome to the game " + userInput + "!");
            Console.ReadLine();
        }

        public static void GamePartOne()
        {
            Console.Clear();
            Console.WriteLine("fgfjkasdgbfjksdbkfjbsdjkfbsdbfjksdbjkfbsdjkbfksd");
            Console.WriteLine("fgfjkasdgbfjksdbkfjbsdjkfbsdbfjksdbjkfbsdjkbfksd");
            Console.WriteLine("fgfjkasdgbfjksdbkfjbsdjkfbsdbfjksdbjkfbsdjkbfksd");
            Console.WriteLine("fgfjkasdgbfjksdbkfjbsdjkfbsdbfjksdbjkfbsdjkbfksd");
            Console.WriteLine("fgfjkasdgbfjksdbkfjbsdjkfbsdbfjksdbjkfbsdjkbfksd");

            //Another choice like above
        }


        public static void GamePartTwo()
        {
            Console.Clear();
            Console.WriteLine("sdffgfjkasdgbfjksdbkfjbsdjkfbsdbfjksdbjkfbsdjkbfksd");
            Console.WriteLine("fsdfsfgfjkasdgbfjksdbkfjbsdjkfbsdbfjksdbjkfbsdjkbfksd");
            Console.WriteLine("fgfjkasdgbfjksdbkfjbsdjkfbsdbfjksdbjkfbsdjkbfksd");
            Console.WriteLine("fgfjkasdgbfjksdbkfjbsdjkfbsdbfjksdbjkfbsdjkbfksd");
            Console.WriteLine("fgfjkasdgbfjksdbkfjbsdjkfbsdbfjksdbjkfbsdjkbfksd");

            //Another choice like above
        }
        public static void IWENTLEFT()
        {
            Console.Clear();
            Console.WriteLine("sdffgfjkasdgbfjksdbkfjbsdjkfbsdbfjksdbjkfbsdjkbfksd");
            Console.WriteLine("fsdfsfgfjkasdgbfjksdbkfjbsdjkfbsdbfjksdbjkfbsdjkbfksd");
            Console.WriteLine("fgfjkasdgbfjksdbkfjbsdjkfbsdbfjksdbjkfbsdjkbfksd");
            Console.WriteLine("fgfjkasdgbfjksdbkfjbsdjkfbsdbfjksdbjkfbsdjkbfksd");
            Console.WriteLine("fgfjkasdgbfjksdbkfjbsdjkfbsdbfjksdbjkfbsdjkbfksd");

            //Another choice like above
            Console.ReadLine();
            MOREGENERALSTORY();
        }
        public static void IWENTRIGHT()
        {
            Console.Clear();
            Console.WriteLine("sdffgfjkasdgbfjksdbkfjbsdjkfbsdbfjksdbjkfbsdjkbfksd");
            Console.WriteLine("fsdfsfgfjkasdgbfjksdbkfjbsdjkfbsdbfjksdbjkfbsdjkbfksd");
            Console.WriteLine("fgfjkasdgbfjksdbkfjbsdjkfbsdbfjksdbjkfbsdjkbfksd");
            Console.WriteLine("fgfjkasdgbfjksdbkfjbsdjkfbsdbfjksdbjkfbsdjkbfksd");
            Console.WriteLine("fgfjkasdgbfjksdbkfjbsdjkfbsdbfjksdbjkfbsdjkbfksd");

            //Another choice like above
            Console.ReadLine();
            MOREGENERALSTORY();
        }

        public static void MOREGENERALSTORY()
        {
            Console.Clear();
            Console.WriteLine("sdffgfjkasdgbfjksdbkfjbsdjkfbsdbfjksdbjkfbsdjkbfksd");
            Console.WriteLine("fsdfsfgfjkasdgbfjksdbkfjbsdjkfbsdbfjksdbjkfbsdjkbfksd");
            Console.WriteLine("fgfjkasdgbfjksdbkfjbsdjkfbsdbfjksdbjkfbsdjkbfksd");
            Console.WriteLine("fgfjkasdgbfjksdbkfjbsdjkfbsdbfjksdbjkfbsdjkbfksd");
            Console.WriteLine("fgfjkasdgbfjksdbkfjbsdjkfbsdbfjksdbjkfbsdjkbfksd");

            //Another choice like above
        }
    }
}
