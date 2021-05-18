using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlegGulyukin.Hometask_01
{
    class Basement : HousePart, IPart, IBuilder
    {
        public Basement(int number)
        {
            nameOfPart = "Basement";
            numberOfPart = number;
        }

        public void addItem(ref House house)
        {
            house.house.Add(this);
        }
    }
}
