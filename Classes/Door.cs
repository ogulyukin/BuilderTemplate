using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlegGulyukin.Hometask_01
{
    class Door : HousePart, IBuilder
    {
        public Door(int number)
        {
            nameOfPart = "Door";
            this.numberOfPart = number;
        }

            public void addItem(ref House house)
        {
            house.house.Add(this);
        }
    }
}
