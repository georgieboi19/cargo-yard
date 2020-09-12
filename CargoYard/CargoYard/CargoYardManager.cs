using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace CargoYard
{
    public class CargoYardManager : CargoYardInterface
    {

        private ArrayList cargoList;
        private ArrayList shipList;
        public void ShowMenu()
        {
            //throw new NotImplementedException();

            Console.WriteLine("1. View Cargo");
            Console.WriteLine("2. Add cargo");
            Console.WriteLine("3. View Ships");
            Console.WriteLine("4. Add ships");

            int menuItem = Console.Read();
            menu1Choice(Convert.ToChar(menuItem));
        }

        public void menu1Choice(int menuOption)
        {
            switch (menuOption)
            {
                case 1:
                    break;
                case 50:
                    AddCargo();
                    break;
                case 3:
                    addShip();
                    break;
                case 4:
                    break;
            }
        }

        private void AddCargo()
        {
            Console.WriteLine("Add your cargo:");
            Console.WriteLine("ID:");
            string iD = Console.ReadLine();
            int cId = Convert.ToInt32(iD);

            Console.WriteLine("Company:");
            string company = Console.ReadLine();

            Console.WriteLine("Size Category (1 = small, 2 = medium, 3 = large):");
            string size = Console.ReadLine();
            int cSize = Convert.ToInt32(size);

            Console.WriteLine("Weight: (round to nearest kg)");
            string weight = Console.ReadLine();
            int cWeight = Convert.ToInt32(weight);

            Console.WriteLine("Contents:");
            string contents = Console.ReadLine();

            Console.WriteLine("Cargo Category (1 = normal, 2 = chilled, 3 = hazardous):");
            string category = Console.ReadLine();
            int cCategory = Convert.ToInt32(category);
            
            switch (cCategory)
            {
                case 1:
                    NormalCargo normalCargo = new NormalCargo(cId, company, cWeight, cSize, cCategory);
                    addCargo(normalCargo);
                    break;
                case 2:
                    ChilledCargo chilledCargo = new ChilledCargo(cId, company, cWeight, cSize, cCategory);
                    addCargo(chilledCargo);
                    break;
                case 3:
                    HarardousCargo harardousCargo = new HarardousCargo(cId, company, cWeight, cSize, cCategory);
                    addCargo(harardousCargo);
                    break;
            }
        }

        private void addCargo(Cargo cargo)
        {
            Random rnd = new Random();
            int quantity = rnd.Next(5, 35);

            for(int i = 0; i <= quantity; i++)
            {
                cargoList.Add(cargo);
            }
        }

        private void addShip()
        {
            Console.WriteLine("Ship name:");
            string shipName = Console.ReadLine();

            Random rnd = new Random();
            int maxCargo = rnd.Next(10, 20);
            int maxChilled = rnd.Next(maxCargo);
            int maxHazardous = rnd.Next(maxCargo - maxChilled);

            Ship ship = new Ship(maxCargo, maxHazardous, maxChilled, shipName);
            shipList.Add(ship);

        }
    }
}
