using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeowMix
{
    class Program
    {
       public static void Main()
        {
            GameMenu.Menu();
            

          
            Console.ReadLine();

            //FelineWarrior WhiskerBrute = new FelineWarrior("WhiskerBrute", 5, "wields itchy as hell whiskers!");
            //WhiskerBrute.Run();

            //FelineWarrior FurBawlz = new FelineWarrior("FurBawlz", 12, "releases a volley of fur bawls!");
            //FurBawlz.Run();

            HumanHunter HunterGuy = new HumanHunter();

        }
    }

    class k9
    {
        string CharName;
        int SprintSpeed;
        string SpecialMove;

        void Run()
        {

        }
        void Bark()
        {

        }
        void Bite()
        {

        }

        

    }

    class FelineWarrior
    {
        string CharName;
        int SprintSpeed;
        string SpecialMove;

        public FelineWarrior(string _charName, int _sprintSpeed, string _specialMove)
        {
            CharName = _charName;
            SprintSpeed = _sprintSpeed;
            SpecialMove = _specialMove;
        }

        public void Run()
        {
            Console.Write("\n" + CharName + " " + SprintSpeed + " " + SpecialMove + "\n");
            Console.ReadLine();
        }
        void Hiss()
        {

        }
        void Scratch()
        {

        }



    }
    class HumanHunter
    {
        string HunterName;
        int SmackRadius;
        string Job;

        void Catch()
        {
            Console.WriteLine("");
        }
        void Release()
        {
            Console.WriteLine("");
        }
        void Search()
        {
            Console.WriteLine("");
        }

    }
}
