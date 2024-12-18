using OOP_Practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class DroneSystemManager
{
    public List<Drone> Drones { get; private set; } = new List<Drone>();
    public List<Mission> Missions { get; private set; } = new List<Mission>();
    public List<Field> Fields { get; private set; } = new List<Field>();
    public List<BaseStation> BaseStations { get; private set; } = new List<BaseStation>();

    public void AddDrone(Drone drone) => Drones.Add(drone);
    public void RemoveDrone(Drone drone) => Drones.Remove(drone);
    public void AddMission(Mission mission) => Missions.Add(mission);
    public void CancelMission(Mission mission) => Missions.Remove(mission);
    public void AddField(Field field) => Fields.Add(field);
    public void AddBaseStation(BaseStation baseStation) => BaseStations.Add(baseStation);

    public void AssignMissionToDrone(Mission mission, Drone drone)
    {
        drone.StartMission(mission);
        mission.AssignDrone(drone);
    }

    public string GetSystemStatus() => $"Drones: {Drones.Count}, Missions: {Missions.Count}, Fields: {Fields.Count}, Base Stations: {BaseStations.Count}";
    public void MonitorSystem()
    {
        foreach (var drone in Drones)
            drone.SelfCheck();
    }
}
