using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlegGulyukin.Hometask_01
{
    class Window : HousePart, IBuilder
    {
        public Window(int number)
        {
            nameOfPart = "Window";
            this.numberOfPart = number;
        }

        public void addItem(ref House house)
        {
            house.house.Add(this);
        }
    }
}
