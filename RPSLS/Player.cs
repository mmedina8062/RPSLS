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
        public bool roundWon;
        public bool gameWon;
        public int score;
        public string playerOption;

        //constructor (spawner)
        public Player()
        {
            this.name = "";
            this.roundWon = false;
            this.gameWon = false;
            this.playerOption = "";
        }

        //members method (can do)

        public abstract void Name();

        public abstract void playerOptions();

        public abstract void RoundWon();

        public abstract void GameWon();
    }
}