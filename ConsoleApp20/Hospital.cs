namespace ConsoleApp20;

public class Hospital
{
    public void TransplantKidney(Person donor, Person patient)
    {
        if (donor.NumberOfKidney > 1 && patient.HealthStatus == "need kidney transplant")
        {
            donor.HealthStat("under transplant");
            patient.HealthStat("under transplant");
            donor.DonateKidney();
            patient.ReceiveKidney();
            donor.HealthStat("fit after transplant");
            patient.HealthStat("under observation after transplant");
        }
        else
        {
            Console.WriteLine($"Check health status and number of kidney");
        }

    }
}