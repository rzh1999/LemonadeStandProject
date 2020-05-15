using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public string name;
        public Inventory inventory;
        public Wallet wallet;
        public Recipie recipie;
        public Pitcher pitcher;

        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            recipie = new Recipie();
            pitcher = new Pitcher();        }
    }

   
}
