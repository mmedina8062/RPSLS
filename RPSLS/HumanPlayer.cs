using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class HumanPlayer : Player
    {

        public HumanPlayer(string name):base(name)
        {
            //member variables

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
    }
}
