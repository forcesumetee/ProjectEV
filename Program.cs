using System;

namespace ProjectEV
{
    public class Program
    {

        static Menu menu;

        static void Main(string[] args)
        {
            ListUsersWhenLogin();

            ShowMenu();
        }

        static void ListUsersWhenLogin()
        {
            Program.menu = new Menu();
        }

        static void ShowMenu()
        {
            Program.menu.ShowMenu();
        }


        static void ShowMenuSpec()
        {
            Console.WriteLine("Car");
            Console.WriteLine("***************");
            Speccar S1 = new Speccar();
            S1.Car = "1.MG EP";
            S1.Price = 215;
            Speccar S2 = new Speccar();
            S2.Car = "2.MG ZS EV";
            S2.Price = 192;

            Speccar S3 = new Speccar();
            S3.Car = "3.Nisan Leaf";
            S3.Price = 172;

            Speccar S4 = new Speccar();
            S4.Car = "4.Audi e-Tron";
            S4.Price = 399;

            Console.WriteLine(S1.Car);
            Console.WriteLine(S2.Car);
            Console.WriteLine(S3.Car);
            Console.WriteLine(S4.Car);
            Console.WriteLine("Input Car");
            Console.WriteLine("***************");
            int C = int.Parse(Console.ReadLine());

            if (C == 1)
            {
                Console.WriteLine("***************");
                Console.WriteLine(S1.Car);
                Console.WriteLine(S1.Price + "Bath");
                Console.WriteLine("***************");


            }
            if (C == 2)
            {
                Console.WriteLine("***************");
                Console.WriteLine(S2.Car);
                Console.WriteLine(S2.Price + "Bath");
                Console.WriteLine("***************");
            }

            if (C == 3)
            {
                Console.WriteLine("***************");
                Console.WriteLine(S3.Car);
                Console.WriteLine(S3.Price + "Bath");
                Console.WriteLine("***************");
            }
            if (C == 4)
            {
                Console.WriteLine("***************");
                Console.WriteLine(S4.Car);
                Console.WriteLine(S4.Price + "Bath");
                Console.WriteLine("***************");
            }
        }

        static void StartCharge()
        {
            Console.WriteLine("Car");
            Console.WriteLine("***************");
            Speccar A1 = new Speccar();
            A1.Car = "1.MG EP";
            A1.Price = 215;
            Speccar A2 = new Speccar();
            A2.Car = "2.MG ZS EV";
            A2.Price = 192;

            Speccar A3 = new Speccar();
            A3.Car = "3.Nisan Leaf";
            A3.Price = 172;

            Speccar A4 = new Speccar();
            A4.Car = "4.Audi e-Tron";
            A4.Price = 399;

            Console.WriteLine(A1.Car);
            Console.WriteLine(A2.Car);
            Console.WriteLine(A3.Car);
            Console.WriteLine(A4.Car);
            Console.WriteLine("Input Car");
            Console.WriteLine("***************");
            int C = int.Parse(Console.ReadLine());

            if (C == 1)
            {
                Console.WriteLine("***************");
                Console.WriteLine(A1.Car);
                Console.WriteLine(A1.Price + "Bath");
                Console.WriteLine("***************");


            }
            if (C == 2)
            {
                Console.WriteLine("***************");
                Console.WriteLine(A2.Car);
                Console.WriteLine(A2.Price + "Bath");
                Console.WriteLine("***************");
            }
            if (C == 3)
            {
                Console.WriteLine("***************");
                Console.WriteLine(A3.Car);
                Console.WriteLine(A3.Price + "Bath");
                Console.WriteLine("***************");
            }
            if (C == 4)
            {
                Console.WriteLine("***************");
                Console.WriteLine(A4.Car);
                Console.WriteLine(A4.Price + "Bath");
                Console.WriteLine("***************");
            }

            Console.ReadLine();
        }

        static void Payment()
        {
            const double car1 = 50.3, car2 = 44.5, car3 = 40, car4 = 95;
            const double ElectricityBill = 4.2;
            double Percentage, number, TotalPrice = 0;

            Console.WriteLine("'Enter the payment process'");
            Console.ReadLine();
            Console.Write("Please Input percent:");
            double.TryParse(Console.ReadLine(), out Percentage);

            Percentage /= 100;

            Console.Write("Please Choose Model :");
            double.TryParse(Console.ReadLine(), out number);
            if (number == 1)
            {
                Console.WriteLine("Model is MG EP");
                TotalPrice = Percentage * car1 * ElectricityBill;
            }
            else if (number == 2)
            {
                Console.WriteLine("Model is MG ZS EV");
                TotalPrice = Percentage * car2 * ElectricityBill;
            }
            else if (number == 3)
            {
                Console.WriteLine("Model is Nissan Leaf");
                TotalPrice = Percentage * car3 * ElectricityBill;
            }
            else if (number == 4)
            {
                Console.WriteLine("Model is Audi e-Tron");
                TotalPrice = Percentage * car4 * ElectricityBill;
            }

            Console.Write("TotalPrice : ");
            Console.WriteLine(TotalPrice);
            Console.WriteLine("Pay at Promptpay : 083-089-5092");
            Console.WriteLine("---Thank you for using the service---");
            Console.ReadKey();
        }

    }



}
