using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void ClearLine()
        {
            Console.SetCursorPosition(34, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
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
