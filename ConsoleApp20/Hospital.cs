namespace ConsoleApp20;

public class Hospital
{
    public void TransplantKidney(Person donor, Person patient)
    {
        if (donor.NumberOfKidney > 1 && patient.HealthStatus == "need kidney transplant")
        {
            Console.WriteLine("*** status : under transplant ***");
            donor.HealthStat("under transplant");
            patient.HealthStat("under transplant");
            
            donor.DonateKidney();
            patient.ReceiveKidney();
            donor.HealthStat("fit to discharge after transplant from Hospital");
            patient.HealthStat("under observation after transplant");
            
            Console.WriteLine($"*** status: Kidney transplant completed ***");
            Console.Write("\tPatient info: ");
            patient.ShowStatus();
            Console.Write("\tDonor info: ");
            donor.ShowStatus();
        }
        else
        {
            Console.WriteLine($"*** Check health status and number of kidney ***");
        }

    }
}