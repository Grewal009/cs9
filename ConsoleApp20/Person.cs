namespace ConsoleApp20;

public class Person
{
    public string Name { get; private set; }
    public int NumberOfKidney { get; private set; }
    public string HealthStatus { get; private set; }
    
    public Person(string name, int numberOfKidney, string healthStatus)
    {
        Name = name;
        NumberOfKidney = numberOfKidney;
        HealthStatus = healthStatus;
    }

    public void ShowStatus()
    {
        Console.WriteLine($"Name:{Name}, No of kidney:{NumberOfKidney}, Health Status {HealthStatus}");
    }

    public void DonateKidney()
    {
        NumberOfKidney--;
    }

    public void ReceiveKidney()
    {
        NumberOfKidney++;
    }

    public void HealthStat(string status)
    {
        HealthStatus = status;
    }


}