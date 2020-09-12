using System;

namespace CargoYard
{
    public class Program
    {
        static void Main(string[] args)
        {
            CargoYardManager manager = new CargoYardManager();
            Console.WriteLine("Loading...");
            bool exit = false;
                manager.ShowMenu();

        }
    }
}
