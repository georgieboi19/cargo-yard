using System;
using System.Collections.Generic;
using System.Text;

namespace CargoYard
{
    public class NormalCargo : Cargo
    {
        protected int loadTime;
        protected double cost;
        public NormalCargo(int iD, string companyName, int weight, int sizeCategory, int typeCategory) : base(iD, companyName, weight, sizeCategory, typeCategory)
        {
            this.loadTime = 12;
            this.cost = 250.0;
        }

        public string getType()
        {
            return "Normal Cargo";
        }

        public int getSetContents
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
