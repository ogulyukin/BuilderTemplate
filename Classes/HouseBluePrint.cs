using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlegGulyukin.Hometask_01
{
    class HouseBluePrint
    {
        public List<HousePart> house;
        protected int currentStage;
        protected int stages;
        public int Stages
        {
            get { return stages; }
        }
        public int getCurrent()
        {
            return currentStage;
        }
        public void build(String item)
        {
            currentStage++;
            Console.WriteLine($"Creating {item}...");
        }
    }
}
