using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        //member variables (has a)
        public string name;
        public bool isWinner;
        public int score;
        public string playerOption;

        //constructor (spawner)
        public Player()
        {
            this.name = "";
            this.isWinner = false;
            this.playerOption = "";
            this.score = 0;
        }

        //members method (can do)

        public abstract void Name();

        public abstract void playerOptions();
    }
}