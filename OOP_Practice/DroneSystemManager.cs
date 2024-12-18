using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    public class DroneSystemManager
    {
        private List<Drone> drones = new List<Drone>();
        private List<Mission> missions = new List<Mission>();
        private List<Field> fields = new List<Field>();
        private List<BaseStation> baseStations = new List<BaseStation>();

        public void AddDrone(Drone drone) {
            throw new NotImplementedException();
        }
        public void RemoveDrone(Drone drone)
        {
            throw new NotImplementedException();
        }

        public void AddMission(Mission mission)
        {
            throw new NotImplementedException();
        }

        public void CancelMission(Mission mission)
        {
            throw new NotImplementedException();
        }

        public void MonitorSystem()
        {
            throw new NotImplementedException();
        }

        public void AssignMissionToDrone(Mission mission, Drone drone)
        {
            throw new NotImplementedException();
        }

        public string GetSystemStatus()
        {
            throw new NotImplementedException();
        }

        public int GetDronesCount()
        {
            throw new NotImplementedException();
        }
    }
}
