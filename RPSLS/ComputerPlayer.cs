using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class ComputerPlayer : Player
    {
        public ComputerPlayer(string name) : base(name)
        {

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
