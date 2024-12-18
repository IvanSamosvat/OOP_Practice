using OOP_Practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

public class Drone : Machine, StatusUpdatable, Monitorable, Assignable
{
    public DroneType Type { get; private set; }
    public int BatteryLevel { get; private set; }
    public DroneStatus Status { get; private set; }
    public string Location { get; private set; }

    public Drone(int id, DroneType type)
    {
        Id = id;
        Type = type;
        BatteryLevel = 100;
        Status = DroneStatus.ACTIVE;
        Location = "Base";
    }

    // Реалізація абстрактного методу Start з класу Machine
    public override void Start()
    {
        Status = DroneStatus.ACTIVE;
        Console.WriteLine($"Drone {Id} started.");
    }

    // Реалізація методу моніторингу з інтерфейсу Monitorable
    public void Monitor()
    {
        Console.WriteLine($"Drone {Id} monitoring at location {Location}.");
    }

    // Реалізація методу для оновлення статусу з інтерфейсу IStatusUpdatable
    public void UpdateStatus(Enum status)
    {
        Status = (DroneStatus)status;
        Console.WriteLine($"Drone {Id} status updated to {Status}.");
    }

    // Інші методи
    public void StartMission(Mission mission)
    {
        Status = DroneStatus.ACTIVE;
        Console.WriteLine($"Drone {Id} started mission {mission.Id}.");
    }

    public void ReturnToBase()
    {
        Location = "Base";
        Status = DroneStatus.CHARGING;
        Console.WriteLine($"Drone {Id} returned to base.");
    }

    public void UpdateBatteryLevel(int level) => BatteryLevel = level;

    public void UpdateLocation(string newLocation) => Location = newLocation;

    public void SelfCheck() => Console.WriteLine($"Drone {Id} is {Status} with {BatteryLevel}% battery.");

    public void Assign(object obj) => Console.WriteLine($"Drone {Id} assigned to object.");
}

