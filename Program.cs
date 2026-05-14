var opel = new Car();

opel.Brand = "Opel";
opel.Model = "Sidan";
opel.Year = 2010;
opel.FuelLevel = 5;

opel.ShowInfo();
opel.Drive(100);
opel.Refuel(15);

Console.WriteLine();

var lada = new Car()
{
    Brand = "Lada",
    Model = "Largus",
    Year = 2020,
    FuelLevel = 0
};

lada.ShowInfo();
lada.Refuel(105);




class Car
{
    public string Brand;
    public string Model;
    public int Year;
    public int FuelLevel ;

    public void ShowInfo()
    {
        Console.WriteLine($"Brend: {Brand}, Model: {Model}, Year: {Year}, FuelLevel: {FuelLevel}% ");
    }

    public void Drive(int distance)
    {
        Console.Write($"Berilgan masofa: {distance}km \n");
        
        int countFuel = FuelLevel;
        int countDistance = distance;

        for (int i = 0; i <= FuelLevel; i++)
        {
            if (countFuel <= 0)
            {
                Console.WriteLine($"Not enough fuel. Qolgan masofa: {countDistance}km ");
                break;
            }

            else if(countFuel > 0)
            {
                countFuel--;
                countDistance -= 10;
                
                if(countDistance <= 0)
                {
                    Console.WriteLine($"Siz {distance}km masofani bosib utdingiz.Sizda {countFuel}% yoqilg'i qoldi.");
                    break;
                }
            }
        }
    }

    public void Refuel(int amount)
    {
        int sumFuel = FuelLevel + amount;

        if(sumFuel > 100)
        {
            sumFuel = 100;
        }
        Console.WriteLine($"Yoqilgi quyildi. Hozirgi holat: {sumFuel}%");
    }
}

