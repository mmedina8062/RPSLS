using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            RulesOfGame rulesOfGame = new RulesOfGame();

            HumanPlayer humanPlayer = new HumanPlayer();

            Game game = new Game();


            rulesOfGame.GameRules();

            game.NumberOfPlayers();

            game.CreatePlayers();

            humanPlayer.Name();

            humanPlayer.playerOptions();

            game.CompareOptions();

            
            

            

            

           













        }

    }
}
