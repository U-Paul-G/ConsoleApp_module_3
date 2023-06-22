using System;

class MainClass
{
    public static void Main(string[] args)
    {

        ////const string myName = "Paul";
        ////Console.WriteLine(myName);
        //Console.WriteLine("\t Привет, \n мир");
        ////Console.WriteLine('\x23');
        ////Console.WriteLine(0x0A);
        ////Console.ReadKey();

        //string MyName = "Paul";
        //byte MyAge = 36;
        //bool HaveIApet = false;
        //double MyShoeSize = 42.5;

        //Console.WriteLine("My name is " + MyName);
        //Console.WriteLine("MyAge " + MyAge);
        //Console.WriteLine("Do I have a pet? " + HaveIApet);
        //Console.WriteLine("My shoe size is " + MyShoeSize);


        //        enum DaysOfWeek : byte
        //{
        //    Tuesday,
        //    Monday,
        //    Wednesday,
        //    Friday
        //}
        //enum Semaphore
        //{
        //    Red = 100,
        //    Yellow = 200,
        //    Green = 300
        //}


        Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

        var color = Console.ReadLine();

        if (color == "red")
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Your color is red!");
        }

        else if (color == "green")
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Your color is green!");
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Your color is cyan!");

        }
    }
}

