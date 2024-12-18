using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    public class Mission : Assignable, StatusUpdatable
    {
        public int Id { get; private set; }
        public MissionType Type { get; private set; }
        public string Area { get; private set; }
        public MissionStatus Status { get; private set; }
        public Drone AssignedDrone { get; private set; }

        public Mission(int id, MissionType type, string area)
        {
            throw new NotImplementedException();
        }
        public void AssignDrone(Drone drone)
        {
            throw new NotImplementedException();
        }
        public void CompleteMission()
        {
            throw new NotImplementedException();
        }
        public void UpdateArea(string newArea)
        {
            throw new NotImplementedException();
        }
        public void CancelMission()
        {
            throw new NotImplementedException();
        }
        public void Assign(object obj)
        {
            throw new NotImplementedException();
        }
        public void UpdateStatus(Enum status)
        {
            throw new NotImplementedException();
        }
    }
}
