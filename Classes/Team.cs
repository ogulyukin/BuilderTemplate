using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlegGulyukin.Hometask_01
{
    class Team
    {
        private int builderQuantity;
        private House house;
        private string name;
        public Team(string name, ref House house, int builderQuantity)
        {
            this.name = name;
            this.house = house;
            this.builderQuantity = builderQuantity; 
        }
        public void Build()
        {
            TeamLeader tl = new TeamLeader(name, ref house);
            tl.PrintHouse();
            if (builderQuantity > 0)
            {
                Worker First = new Worker("First", ref tl);
                First.build();
            }
            if(builderQuantity > 1)
            {
                Worker Second = new Worker("Second", ref tl);
                Second.build();
            }
            if (builderQuantity > 2)
            {
                Worker Third = new Worker("Third", ref tl);
                Third.build();
            }
            tl.PrintHouse();
        }
        
    }
}
