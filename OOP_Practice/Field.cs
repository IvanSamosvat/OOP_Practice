using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    public class Field : Monitorable, StatusUpdatable
    {
        public int Id { get; private set; }
        public string Location { get; private set; }
        public string CropType { get; private set; }
        public FieldStatus Status { get; private set; }

        public Field(int id, string location, string cropType)
        {
            throw new NotImplementedException();
        }
        public void UpdateStatus(Enum status)
        {
            throw new NotImplementedException();
        }
        public string GetFieldDetails()
        {
            throw new NotImplementedException();
        }
        public bool NeedsMaintenance()
        {
            throw new NotImplementedException();
        }
        public void Monitor()
        {
            throw new NotImplementedException();
        }
    }
}
