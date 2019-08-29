using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class ComputerPlayer : Player
    {
       

        public ComputerPlayer()
        {
            this.name = "";
            this.isWinner = false;
            this.playerOption = "";
            this.score = 0;

        }
            

        public override void Name()
        {
            name = "Todd";
        }

        public override void playerOptions()
        {
            Console.WriteLine(); //might have to override class to add random to playerOptions
        }
    }
}
