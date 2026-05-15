using Model;

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


