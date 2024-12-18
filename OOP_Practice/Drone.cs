using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{   public class Drone
    {
        public int Id { get; private set; }
        public DroneType Type { get; private set; }
        public int BatteryLevel { get; private set; }
        public DroneStatus Status { get; private set; }
        public string Location { get; private set; }

        public Drone(int id, DroneType type)
        {

            throw new NotImplementedException();
        }

        public void StartMission(Mission mission)
        {

            throw new NotImplementedException();
        }

        public void ReturnToBase()
        {

            throw new NotImplementedException();
        }

        public void UpdateBatteryLevel(int level)
        {

            throw new NotImplementedException();
        }

        public void UpdateLocation(string newLocation)
        {

            throw new NotImplementedException();
        }

        public void SelfCheck()
        {

            throw new NotImplementedException();
        }

        public void Monitor()
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
