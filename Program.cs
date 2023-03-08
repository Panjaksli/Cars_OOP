namespace Cars_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto truck = new Nakladni(Auto.TypPaliva.Nafta);
            Auto car = new Osobni(Auto.TypPaliva.Benzin);

            car.PrepravovaneOsoby = 5;
            car.PrepravovanyNaklad = 800;
            car.Natankuj(Auto.TypPaliva.Benzin, 10);
            car.AutoRadio.Zapnuto = true;
            car.AutoRadio.NastavPredvolbu(3, 88.1);
            car.AutoRadio.NastavPredvolbu(5, 92.5);
            car.AutoRadio.PreladPredvolbu(5);

            truck.PrepravovaneOsoby = 1;
            truck.PrepravovanyNaklad = 1000;
            truck.Natankuj(Auto.TypPaliva.Nafta,10);
            truck.AutoRadio.Zapnuto = false;
            truck.AutoRadio.NastavPredvolbu(2, 95.6);
            truck.AutoRadio.NastavPredvolbu(1, 75.3);
            truck.AutoRadio.PreladPredvolbu(1);

            //car.PrepravovaneOsoby = 6; //Exception
            //car.PrepravovanyNaklad = 1500; //Exception
            //car.Natankuj(Auto.TypPaliva.Nafta, 10); //Exception
            //car.Natankuj(Auto.TypPaliva.Benzin, 100); //Exception
            //car.AutoRadio.PreladPredvolbu(1); //Exception
            //truck.PrepravovanyNaklad = 20000; //Exception
            //truck.PrepravovaneOsoby = 20; //Exception
            //truck.Natankuj(Auto.TypPaliva.Benzin, 100); //Exception
            //truck.Natankuj(Auto.TypPaliva.Nafta, 2000); //Exception
            //truck.AutoRadio.PreladPredvolbu(5); //Exception

            Console.WriteLine(truck);
            Console.WriteLine(truck.AutoRadio);
            Console.WriteLine(car);
            Console.WriteLine(car.AutoRadio);
        }
    }
}