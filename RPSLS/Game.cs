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
        string Rock;
        string Paper;
        string Scissor;
        String Lizard;
        string Spock;

        public Game()
        {



        }


        public void NumberOfPlayers()
        {
            Console.WriteLine("Choose how many players: 1 or 2 players?");
            string userInput = Console.ReadLine();
            numberOfPlayers = int.Parse(userInput);

        }

        public string CreatePlayers()
        {

            if (numberOfPlayers == 1)
            {
                player1 = new HumanPlayer();
                player2 = new ComputerPlayer();

            }
            else if (numberOfPlayers == 2)
            {
                player1 = new HumanPlayer();
                player2 = new HumanPlayer();
            }
            return CreatePlayers();

        }
        public void CompareOptions()
        {

            if (player1.playerOption == Rock && player2.playerOption == Rock)
            {
                Console.WriteLine("Its a tie");

            }
            else if (player1.playerOption == Rock && player2.playerOption == Scissor || player2.playerOption == Lizard)
            {
                Console.WriteLine(player1 + "Wins");
            }
            else if (player1.playerOption == Scissor && player2.playerOption == Scissor)
            {
                Console.WriteLine("It's a tie");
            }
            else if (player1.playerOption == Scissor && player2.playerOption == Paper || player2.playerOption == Lizard)
            {
                Console.WriteLine(player1 + "Wins");
            }

        }
    }
}
