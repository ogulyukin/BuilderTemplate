using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlegGulyukin.Hometask_01
{
    class House : HouseBluePrint
    {
        
        public House()
        {
            house = new List<HousePart>();
            currentStage = 0;
            stages = 12;
        }

    }
}
