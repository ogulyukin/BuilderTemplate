using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlegGulyukin.Hometask_01
{
    class Walls : HousePart, IPart, IBuilder
    {
        public Walls(int number)
        {
            nameOfPart = "Wall";
            this.numberOfPart = number;
        }
            public void addItem(ref House house)
        {
            house.house.Add(this);
        }
    }
}
