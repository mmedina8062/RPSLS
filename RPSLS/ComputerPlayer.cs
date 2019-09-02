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
            
            this.gameWon = false;
            this.playerOption = "";

        }
            

        public override void Name()
        {
            name = "Todd";
        }

        public override void playerOptions()
        {
            
        }

       
    }
}
