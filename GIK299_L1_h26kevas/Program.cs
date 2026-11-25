namespace GIK299_L1_h26kevas;

class Program
{
    public Program()
    {
    }

    static void Main(string[] args)
    {
        bool fortsätt = true;
        while (fortsätt)
        {
            Console.WriteLine("1. Beräkna vindavkylning");
            Console.WriteLine("2. Avsluta");
            Console.WriteLine("Välj ett alternativ:");
            
            string val = Console.ReadLine();
            switch (val)
            {
                case "1":

                    Console.Write("Ange temperaturen i Celsius: ");
                    string temperaturInput = Console.ReadLine();
                    double temperatur = double.Parse(temperaturInput);

                    Console.Write("Ange vindhastigheten: ");
                    string vindinput = Console.ReadLine();

                    double vind = double.Parse(vindinput);
                    Console.Write("Ange vindhastighetens enhet (km/h eller m/s: ");
                    string enhetInput = Console.ReadLine();
                    if (enhetInput == "m/s")
                    {
                        vind = vind * 3.6;
                    }
                    else if (enhetInput == "km/h")
                    {
                        Console.WriteLine("Vindhastigheten är redan i Km/h");
                    }
                    else
                    {
                        Console.WriteLine("Felaktig enhet");
                        return;
                    }

                    double vindavkylning = 13.12 + 0.6215 * temperatur
                                           - 11.37 * Math.Pow(vind, 0.16)
                                           + 0.3965 * temperatur * Math.Pow(vind, 0.16);
                    Console.WriteLine("Det känns som: " + vindavkylning.ToString("F1") + " °C");
                    if (vindavkylning > -25)
                    {
                        Console.WriteLine("Kallt");
                    }
                    else if (vindavkylning >= -35)
                    {
                        Console.WriteLine("Mycket Kallt");
                    }
                    else if (vindavkylning >= -60)
                    {
                        Console.WriteLine("Risk för frostskada");
                    }
                    else
                    {
                        Console.WriteLine("Stor risk för frostskada");
                    }

                    break;

            case "2":
            fortsätt = false;
            Console.WriteLine("Programmet avslutas");
            break;
            
            
        default:
            Console.WriteLine("Ogiltigt val");
            break;
        }
        }
    }
}

