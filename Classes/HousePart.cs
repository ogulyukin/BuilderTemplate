using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlegGulyukin.Hometask_01
{
    class HousePart : IPart
    {
        protected string nameOfPart;
        protected int numberOfPart;
        public void PrintName()
        {
            Console.WriteLine(nameOfPart + " " + Convert.ToString(numberOfPart));
        }
    }
}
