using OOP_Practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Mission : Assignable, StatusUpdatable
{
    public int Id { get; private set; }
    public MissionType Type { get; private set; }
    public string Area { get; private set; }
    public MissionStatus Status { get; private set; }
    public Drone AssignedDrone { get; private set; }

    public Mission(int id, MissionType type, string area)
    {
        Id = id;
        Type = type;
        Area = area;
        Status = MissionStatus.QUEUED;
    }

    public void AssignDrone(Drone drone)
    {
        AssignedDrone = drone;
        Status = MissionStatus.IN_PROGRESS;
        Console.WriteLine($"Mission {Id} assigned to drone {drone.Id}.");
    }

    public void CompleteMission()
    {
        Status = MissionStatus.COMPLETED;
        Console.WriteLine($"Mission {Id} completed.");
    }

    public void UpdateArea(string newArea) => Area = newArea;

    public void CancelMission() => Status = MissionStatus.QUEUED;

    public void Assign(object obj) => Console.WriteLine($"Mission {Id} assigned to object.");

    public void UpdateStatus(Enum status) => Status = (MissionStatus)status;
}
