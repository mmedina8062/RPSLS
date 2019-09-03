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
            Console.SetCursorPosition(33, Console.CursorTop);
            
        }
        static void Main(string[] args)
        {
            RulesOfGame rulesOfGame = new RulesOfGame();

            HumanPlayer humanPlayer = new HumanPlayer();

            ComputerPlayer computerPlayer = new ComputerPlayer();

            Game game = new Game();


            rulesOfGame.GameRules();

            game.NumberOfPlayers();

            game.CreatePlayers();

            computerPlayer.playerOptions();

            humanPlayer.Name();

            humanPlayer.playerOptions();

            game.CompareOptions();

























        }

    }
}
