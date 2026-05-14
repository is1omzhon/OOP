var opel = new Car();
opel.Brand = "Opel";
opel.Model = "Sidan";
opel.Year = 2010;
opel.FuelLevel = 20;
opel.ShowInfo();
opel.Drive(100);

class Car
{
    public string Brand;
    public string Model;
    public int Year;
    public int FuelLevel ;

    public void ShowInfo()
    {
        Console.WriteLine($"Brend: {Brand}, Model: {Model}, Year: {Year}, FuelLevel: {FuelLevel}%");
    }

    public void Drive(int distance)
    {
        Console.Write($"Berilgan masofa: {distance}km \n");

        for (int i = 0; i < FuelLevel; i++)
        {
            
            if(FuelLevel > 0)
            {
                FuelLevel--;
                distance-=10;
                
                if(distance == 0)
                {
                    Console.WriteLine($"Siz masofani bosib utdingiz.Sizda {FuelLevel}% yoqilg'i qoldi.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Not enough fuel");
                break;
            }
        }

    }
}
