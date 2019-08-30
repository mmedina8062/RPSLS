using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        // instantiate two players as member variables
        Player player1;
        Player player2;
        int numberOfPlayers;
        

        public void NumberOfPlayers()
        {
            Console.WriteLine("Choose how many players: 1 or 2 players?");
            string userInput = Console.ReadLine();
            numberOfPlayers = int.Parse(userInput);
       
        }

        public void CreatePlayers()
        {
            if (numberOfPlayers == 1)
            {
                player1 = new HumanPlayer();
                player2 = new ComputerPlayer();

            }
            else if(numberOfPlayers == 2)
            {
                player1 = new HumanPlayer();
                player2 = new HumanPlayer();
            }
        }
    }
}
