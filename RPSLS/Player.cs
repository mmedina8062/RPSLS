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
        public string playerOption;
        public bool compareOptions;
        public bool gameWon;
        public int score;


        //constructor (spawner)
        public Player()
        {
            this.name = "";
            this.gameWon = false;
            this.playerOption = "";
            

        }

        //members method (can do)

        public abstract void Name();

        public abstract void playerOptions();

        

      
    }
}