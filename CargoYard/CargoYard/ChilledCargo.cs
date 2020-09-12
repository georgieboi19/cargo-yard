using System;
using System.Collections.Generic;
using System.Text;

namespace CargoYard
{
    class ChilledCargo : Cargo
    {
        protected int loadTime;
        protected double cost;
        public ChilledCargo(int iD, string companyName, int weight, int sizeCategory, int typeCategory) : base(iD, companyName, weight, sizeCategory, typeCategory)
        {
            this.loadTime = 45;
            this.cost = 370.0;
        }

        public string getType()
        {
            return "Chilled Cargo";
        }

        public int getSetLoadTime
        {
            get => loadTime;
            set => loadTime = value;
        }

        public double getSetCost
        {
            get => cost;
            set => cost = value;
        }
    }
}
