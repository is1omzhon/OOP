var opel = new Car();
opel.Brand = "Opel";
opel.Model = "Sidan";
opel.Year = 2010;
opel.FuelLevel = 20;

opel.ShowInfo();

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
}
