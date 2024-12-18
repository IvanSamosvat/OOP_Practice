using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Machine
{
    // Загальні властивості для всіх машин
    public int Id { get; protected set; }
    public string Name { get; protected set; }

    // Абстрактний метод для роботи з машиной (наприклад, початок роботи)
    public abstract void Start();

    // Може бути інший загальний метод, наприклад, для моніторингу
    public void Monitor()
    {
        Console.WriteLine($"{Name} (ID: {Id}) is being monitored.");
    }
}