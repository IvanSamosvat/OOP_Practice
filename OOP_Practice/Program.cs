using OOP_Practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example usage of the system
            var manager = new DroneSystemManager();
            var drone = new Drone(1, DroneType.SEEDING);
            var mission = new Mission(1, MissionType.SEEDING, "Field A");

            manager.AddDrone(drone);
            manager.AddMission(mission);
            manager.AssignMissionToDrone(mission, drone);

            Console.WriteLine(manager.GetSystemStatus());
        }
    }
}
