using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
     class CarManager
    {
        public Car AddCar()
        {
            Console.WriteLine("Masini daxil edin");

            Console.Write("Marka :");
            string marka = Console.ReadLine();

            Console.WriteLine("Model :");
            string model = Console.ReadLine();

            Console.WriteLine("FuellEff");
            string fuelEff = Console.ReadLine();

            Console.WriteLine("MAx fuel :");
            string maxFuel = Console.ReadLine();

            Console.WriteLine("Current fuel :");
            string currentFuel = Console.ReadLine();
            try
            {
                decimal fuelEffdec = Convert.ToDecimal(fuelEff);
                decimal maxFueldec = Convert.ToDecimal(maxFuel);
                decimal currentFueldec = Convert.ToDecimal(currentFuel);

                Car newCar = new Car()
                {
                    Marka = marka,
                    Model = model,
                    FullEff = fuelEffdec,
                    MaxFuel = maxFueldec,
                    CurrentFuel = currentFueldec


                };
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Marka adi " + marka + "Ugurla yaradildi /n");
                return newCar;

            }
            catch (Exception)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Benzille bafli meliumatlari reqem daxil edin");
                return null;
            }

        }

        public void ShowInfo(Car isCorrect)
        {
            string right = "";
            do
            {

            if (isCorrect !=null)
            {

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Welcome");
                Console.WriteLine("1.Go");
                Console.WriteLine("2.toUp");
                Console.WriteLine("3.Stop");
                Console.WriteLine("4.Exit");
                right = Console.ReadLine();
                try
                {
                    int rightNumber = Convert.ToInt32(right);
                    Console.Clear();
                    //switc case

                    switch (rightNumber)
                    {
                        case 1:
                                Go(isCorrect);
                            break;
                        case 2:
                                TopUp(isCorrect);
                            break;
                        case 3:
                            Console.WriteLine("Stop");
                            break;
                        case 4:
                            Console.WriteLine("Yaxsi yol");
                            break;
                        default:
                            Console.WriteLine("Yuxardaki reqemlerden birini daxil edin");
                            break;

                    }


                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    Console.WriteLine("XAis edirik reqem daxil edin");
                }
            }
            }
            while (right!="4");
        }

        public void TopUp(Car selectedCar)
        {

            Console.WriteLine("Nece l benzin doldurmaq isteyirseniz?");
            decimal neededTopup = Convert.ToDecimal(Console.ReadLine());
            if (selectedCar.MaxFuel >= neededTopup + selectedCar.CurrentFuel)
            {
                selectedCar.CurrentFuel += neededTopup;
                Console.WriteLine($"Benzin ugurla dolduruldu.Masinda hal-hazırda {selectedCar.CurrentFuel}l");

            }

        }
        public void Go(Car selectedCar)
        {
            Console.WriteLine("Nece km getmek isteyirsiniz?");
            decimal neededKm =  Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine($"Sizin masininzda {selectedCar.CurrentFuel}l benzin var");

            decimal usedfuel = neededKm / 100 * selectedCar.FullEff;

            if (selectedCar.CurrentFuel >=usedfuel)
            {
                selectedCar.CurrentFuel -= usedfuel;
                Console.WriteLine($"Siz {neededKm} km yol qət etdiniz.Masinda {selectedCar.CurrentFuel}l benzin qaldi ");
            }
            else
            {
                Console.WriteLine("Benzin doldur!!!!");
            }
            //currentfuel= 40-masinda olan
            //fueleff=100-e 15 l istifade
            //neededkm - getmek istediyi km 



        }
    }
}
