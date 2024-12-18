using OOP_Practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BaseStation : Monitorable, StatusUpdatable
{
    public int Id { get; private set; }
    public List<Drone> availableDrones = new List<Drone>();
    public Queue<Mission> missionQueue = new Queue<Mission>();

    public BaseStation(int id)
    {
        Id = id;
    }

    public void AddDrone(Drone drone) => availableDrones.Add(drone);
    public void RemoveDrone(Drone drone) => availableDrones.Remove(drone);

    public void AssignMission(Mission mission)
    {
        if (availableDrones.Count > 0)
        {
            var drone = availableDrones[0];
            availableDrones.RemoveAt(0);
            drone.StartMission(mission);
        }
        else
        {
            missionQueue.Enqueue(mission);
        }
    }

    public void MonitorDrones()
    {
        foreach (var drone in availableDrones)
            drone.SelfCheck();
    }
    public void Monitor()
    {
        Console.WriteLine("BaseStation is monitoring.");
    }

    public void UpdateStatus(Enum status)
    {
        Console.WriteLine($"BaseStation status updated to {status}");
    }
    public string GetStationDetails() => $"BaseStation {Id} with {availableDrones.Count} drones available.";
}
