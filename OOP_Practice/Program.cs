using OOP_Practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var manager = new DroneSystemManager();

        // Example for testing DroneSystemManager, Drone, Mission, BaseStation, Field
        bool running = true;
        while (running)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add Drone");
            Console.WriteLine("2. Add Mission");
            Console.WriteLine("3. Assign Mission to Drone");
            Console.WriteLine("4. Add Base Station");
            Console.WriteLine("5. Monitor System");
            Console.WriteLine("6. Show System Status");
            Console.WriteLine("7. Exit");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter Drone ID and Type (1 - SEEDING, 2 - MONITORING, 3 - IRRIGATION):");
                    int droneId = int.Parse(Console.ReadLine());
                    DroneType droneType = (DroneType)Enum.Parse(typeof(DroneType), Console.ReadLine().ToUpper());
                    var drone = new Drone(droneId, droneType);
                    manager.AddDrone(drone);
                    break;

                case "2":
                    Console.WriteLine("Enter Mission ID, Type (SEEDING, IRRIGATION, MONITORING), Area:");
                    int missionId = int.Parse(Console.ReadLine());
                    MissionType missionType = (MissionType)Enum.Parse(typeof(MissionType), Console.ReadLine().ToUpper());
                    string area = Console.ReadLine();
                    var mission = new Mission(missionId, missionType, area);
                    manager.AddMission(mission);
                    break;

                case "3":
                    Console.WriteLine("Enter Mission ID and Drone ID to assign:");
                    int missionAssignId = int.Parse(Console.ReadLine());
                    int droneAssignId = int.Parse(Console.ReadLine());

                    var assignedMission = manager.Missions.FirstOrDefault(m => m.Id == missionAssignId);
                    var assignedDrone = manager.Drones.FirstOrDefault(d => d.Id == droneAssignId);

                    if (assignedMission != null && assignedDrone != null)
                    {
                        manager.AssignMissionToDrone(assignedMission, assignedDrone);
                    }
                    else
                    {
                        Console.WriteLine("Mission or Drone not found.");
                    }
                    break;

                case "4":
                    Console.WriteLine("Enter Base Station ID:");
                    int stationId = int.Parse(Console.ReadLine());
                    var baseStation = new BaseStation(stationId);
                    manager.AddBaseStation(baseStation);
                    break;

                case "5":
                    manager.MonitorSystem();
                    break;

                case "6":
                    Console.WriteLine(manager.GetSystemStatus());
                    break;

                case "7":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
