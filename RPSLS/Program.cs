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
            Game game;
            game = new Game();

            game.NumberOfPlayers();
            game.CreateNumberofPlayers();

        }
    }
}
