using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlegGulyukin.Hometask_01
{
    class TeamLeader
    {
        public string name;
        public House house;
        public TeamLeader(string name, ref House house)
        {
            this.name = name;
            this.house = house;
        }
        public void PrintHouse()
        {
            Console.WriteLine($"I am a {name} team leader.");
            if (house.house == null)
            {
                Console.WriteLine("The building of house is not started yet.");
                return;
            }
            Console.WriteLine("The part of House done : ");
            foreach(HousePart i in house.house)
            {
                i.PrintName();
            }
            Console.WriteLine($"It is {GetCurrentStage()} of {GetStage()} ready.");
        }
        public int GetCurrentStage() { return this.house.getCurrent(); }
        public int GetStage() => this.house.Stages;
    }
}
