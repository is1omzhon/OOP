namespace Model
{
    class Car
    {
        public string Brand;
        public string Model;
        public int Year;
        private int fuelLevel;

        private int Increase;
        private int decrease;



        public void ShowInfo()
        {
            Console.WriteLine($"Brend: {Brand}, Model: {Model}, Year: {Year}, FuelLevel: {fuelLevel}% ");
        }

        public void SetSpeed(int inputSpeed)
        {
            if (inputSpeed < 0)
            {
                Console.WriteLine("Tezlik manfiy son bula olmaydi");
                return;
            }
            else if (inputSpeed > 200)
            {
                Console.WriteLine("Mashinaning maksilmal tezligi 200");
            }

            this.Increase = inputSpeed;
        }
        public int GetSpeed() => this.Increase;


        public int Decrease
        {
            get
            {
                return this.decrease;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Tezlik manfiy son bula olmaydi");
                    return;
                }
                else if (value > 200)
                {
                    Console.WriteLine("Mashinaning maksilmal tezligi 200");
                }
            }
        }

        public int FuelLevel
        {
            get
            {
                return this.decrease;
            }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Yoqilg'i manfiy bula olmaydi!!");
                }
                else if (value == 0)
                {
                    Console.WriteLine("Yoqilgi tugadi, tezda tuldiring!!!");
                }
                else
                {
                    this.decrease = value;
                }
            }
        }

        public void Drive(int distance)
        {
            Console.Write($"Berilgan masofa: {distance}km \n");

            int countFuel = fuelLevel;
            int countDistance = distance;

            for (int i = 0; i < fuelLevel; i++)
            {
                if (countFuel <= 0)
                {
                    Console.WriteLine($"Not enough fuel. Qolgan masofa: {countDistance}km ");
                    fuelLevel = countFuel;
                    break;
                }

                else if (countFuel > 0)
                {
                    countFuel--;
                    countDistance -= 10;

                    if (countDistance <= 0)
                    {
                        fuelLevel = countFuel;
                        Console.WriteLine($"Siz {distance}km masofani bosib o'tdingiz. Sizda {countFuel}% yoqilg'i qoldi.");
                        break;
                    }
                }
            }


            if (countDistance > 0 && countFuel <= 0)
            {
                fuelLevel = countFuel;
                Console.WriteLine($"Not enough fuel. Qolgan masofa: {countDistance}km");
            }
        }

        public void Refuel(int amount)
        {
            int sumFuel = fuelLevel + amount;

            if (sumFuel > 100)
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
