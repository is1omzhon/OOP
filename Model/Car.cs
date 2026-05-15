namespace Model
{
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

            for (int i = 0; i < FuelLevel; i++)  
            {
                if (countFuel <= 0)
                {
                    Console.WriteLine($"Not enough fuel. Qolgan masofa: {countDistance}km ");
                    FuelLevel = countFuel;  
                    break;
                }

                else if (countFuel > 0)
                {
                    countFuel--;
                    countDistance -= 10;
                    
                    if (countDistance <= 0)
                    {
                        FuelLevel = countFuel;  
                        Console.WriteLine($"Siz {distance}km masofani bosib o'tdingiz. Sizda {countFuel}% yoqilg'i qoldi.");
                        break;
                    }
                }
            }
            
            
            if (countDistance > 0 && countFuel <= 0)
            {
                FuelLevel = countFuel;
                Console.WriteLine($"Not enough fuel. Qolgan masofa: {countDistance}km");
            }
        }

        public void Refuel(int amount)
        {
            int sumFuel = FuelLevel + amount;

            if(sumFuel > 100)
            {
                sumFuel = 100;
                Console.WriteLine($"Yoqilgi quyildi. Hozirgi holat: 100%");
            }
            else
            {
                Console.WriteLine($"Yoqilgi quyildi. Hozirgi holat: {sumFuel}%");
            }
        }
    }

}   
