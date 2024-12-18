using OOP_Practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Field : Monitorable, StatusUpdatable
{
    public int Id { get; private set; }
    public string Location { get; private set; }
    public string CropType { get; private set; }
    public FieldStatus Status { get; private set; }

    public Field(int id, string location, string cropType)
    {
        Id = id;
        Location = location;
        CropType = cropType;
        Status = FieldStatus.NORMAL;
    }

    public void UpdateStatus(Enum status) => Status = (FieldStatus)status;

    public string GetFieldDetails() => $"Field {Id}: {CropType} at {Location} with status {Status}.";
    public bool NeedsMaintenance() => Status != FieldStatus.NORMAL;

    public void Monitor() => Console.WriteLine($"Field {Id} at {Location} is being monitored.");
}
