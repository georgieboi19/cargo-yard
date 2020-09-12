using System;
using System.Collections.Generic;
using System.Text;

namespace CargoYard
{
    class HarardousCargo : Cargo
    {
        protected int loadTime;
        protected double cost;
        public HarardousCargo(int iD, string companyName, int weight, int sizeCategory, int typeCategory) : base(iD, companyName, weight, sizeCategory, typeCategory)
        {
            this.loadTime = 60;
            this.cost = 370.0;
        }

        public string getType()
        {
            return "Harzardous Cargo";
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
