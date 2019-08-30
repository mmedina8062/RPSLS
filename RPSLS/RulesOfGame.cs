using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class RulesOfGame
    {

        //members variable (has a)
        
        //constructor



        //member method (can do)
        public void GameRules()
        {
            Console.WriteLine("Game: Rock, Paper, Scissors, Lizard, Spock\n");

            Console.WriteLine("Rules:\n");

            Console.WriteLine("This is a two player game, each player will get the opportunity to choose an option.");
            Console.WriteLine("The options are Rock, Paper, Scissor, Lizard, or Spock.");
            Console.WriteLine("Choose an option that you think will defeat the opponents choice.\n");

            List<string> OptionRules = new List<string>();
            OptionRules.Add("1. Rock crushes Scissors\n");
            OptionRules.Add("2. Scissors cuts Paper\n");
            OptionRules.Add("3. Paper covers Rock\n");
            OptionRules.Add("4. Rock crushes Lizard\n");
            OptionRules.Add("5. Lizard poisons Spock\n");
            OptionRules.Add("6. Spock smashes Scissors\n");
            OptionRules.Add("7. Scissors decapitates Lizard\n");
            OptionRules.Add("8. Lizard eats Paper\n");
            OptionRules.Add("9. Paper disproves Spock\n");
            OptionRules.Add("10. Spock vaporizes Rock\n");

            foreach (string rules in OptionRules)
            {
                Console.WriteLine(rules);
            }
        }

    }
}
