using Model;

var opel = new Car();

opel.Brand = "Opel";
opel.Model = "Sidan";
opel.Year = 2010;

opel.ShowInfo();

opel.SetSpeed(-15);
opel.SetSpeed(205);
opel.SetSpeed(175);

Console.WriteLine($"Car speed is {opel.GetSpeed()}");



Console.WriteLine();

var lada = new Car()
{
    Brand = "Lada",
    Model = "Largus",
    Year = 2020,
};

lada.ShowInfo();

lada.Decrease = -25;
lada.Decrease = 210;
lada.Decrease = 100;

lada.FuelLevel = 15;
lada.FuelLevel = 0;



