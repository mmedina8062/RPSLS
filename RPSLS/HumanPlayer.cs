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

        String Options; 

        
        
        
        


        public HumanPlayer()
        {

             

            


        }

        public override void Name()
        {
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            
        }

        public override void playerOptions()
        {
            Options = ("Rock, Paper, Scissor, Lizard, Spock");
            Console.WriteLine("Choose your option: Rock, Paper, Scissor, Lizzard, or Spock");
            playerOption = Console.ReadLine();



        }
        
        public string PlayerOptions()
        {
            if (playerOption == Options)
            { 
                return playerOption;

            }

            else
            {
                default;
                Console.WriteLine("Please enter in an option that corresponds to the list option");
            }
            return Options;
        }
    }
}
