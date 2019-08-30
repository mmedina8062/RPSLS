using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class HumanPlayer : Player
    {
        //member variables
    



        public HumanPlayer()
        {
            //constructor

        }

        public override void Name()
        {
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
        }

        public override void playerOptions()
        {
            Console.WriteLine("Choose your weapon: Rock, Paper, Scissor, Lizzard, or Spock");
            playerOption = Console.ReadLine();
        }

        public override void RoundWon()
        {

        
        }
    }
}
