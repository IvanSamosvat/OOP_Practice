using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    public class BaseStation
    {
        private List<Drone> availableDrones = new List<Drone>();
        private Queue<Mission> missionQueue = new Queue<Mission>();
        public int Id { get; private set; }

        public BaseStation(int id)
        {
            Id = id;
        }

        public void AddDrone(Drone drone)
        {
            throw new NotImplementedException();
        }

        public void RemoveDrone(Drone drone)
        {
            throw new NotImplementedException();
        }

        public void AssignMission(Mission mission)
        {
            throw new NotImplementedException();
        }

        public void MonitorDrones()
        {
            throw new NotImplementedException();
        }

        public string GetStationDetails()
        {
            throw new NotImplementedException();
        }
        public int GetAvailableDronesCount()
        {
            throw new NotImplementedException();
        }
    }
}
