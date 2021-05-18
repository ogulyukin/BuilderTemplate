using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlegGulyukin.Hometask_01
{
    class Worker
    {
        private TeamLeader teamLeader;
        private int stage;
        public string name;
        public Worker(string name, ref TeamLeader teamLeader)
        {
            this.stage = teamLeader.house.getCurrent();
            this.teamLeader = teamLeader;
            this.name = name;
        }
        public void build()
        {
            Console.WriteLine($"{name} worker. Begin building.");
            switch (stage)
            {
                case 0:
                    Basement basement = new Basement(1);
                    basement.addItem(ref teamLeader.house);
                    teamLeader.house.build("basement");
                    break;
                case 1:
                    Walls wall01 = new Walls(1);
                    wall01.addItem(ref teamLeader.house);
                    teamLeader.house.build("wall");
                    break;
                case 2:
                    Door door = new Door(1);
                    door.addItem(ref teamLeader.house);
                    teamLeader.house.build("door in first wall");
                    break;
                case 3:
                    Window window01 = new Window(1);
                    window01.addItem(ref teamLeader.house);
                    teamLeader.house.build("window on the wall");
                    break;
                case 4:
                    Walls wall02 = new Walls(2);
                    wall02.addItem(ref teamLeader.house);
                    teamLeader.house.build("wall");
                    break;
                case 5:
                    Roof roof01 = new Roof(1);
                    roof01.addItem(ref teamLeader.house);
                    teamLeader.house.build("roof between the wall");
                    break;
                case 6:
                    Window window02 = new Window(2);
                    window02.addItem(ref teamLeader.house);
                    teamLeader.house.build("window on the wall");
                    break;
                case 7:
                    Walls wall3 = new Walls(3);
                    wall3.addItem(ref teamLeader.house);
                    teamLeader.house.build("wall");
                    break;
                case 8:
                    Window window3 = new Window(3);
                    window3.addItem(ref teamLeader.house);
                    teamLeader.house.build("window on the wall");
                    break;
                case 9:
                    Walls wall04 = new Walls(4);
                    wall04.addItem(ref teamLeader.house);
                    teamLeader.house.build("wall");
                    break;
                case 10:
                    Window window4 = new Window(4);
                    window4.addItem(ref teamLeader.house);
                    teamLeader.house.build("window on the wall");
                    break;
                case 11:
                    Roof roof02 = new Roof(2);
                    roof02.addItem(ref teamLeader.house);
                    teamLeader.house.build("roof between the wall");
                    break;
                default:
                    Console.WriteLine("The house is alredy done. The worker is idle!");
                    break;
            }
            Console.WriteLine($"{name} worker. End working.");
        }
    }
}
