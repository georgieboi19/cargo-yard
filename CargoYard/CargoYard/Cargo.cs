using System;
using System.Collections.Generic;
using System.Text;

namespace CargoYard
{
    public class Cargo
    {
        protected int iD;
        protected string companyName;
        protected DateTime addedDate;
        protected int weight;
        protected int sizeCategory;
        protected int typeCategory;

        public Cargo(int iD, string companyName, int weight, int sizeCategory, int typeCategory)
        {
            this.iD = iD;
            this.companyName = companyName;
            this.weight = weight;
            this.sizeCategory = sizeCategory;
            this.typeCategory = typeCategory;
            this.addedDate = DateTime.Now;
        }
        public int getSetId
        {
            get => iD;
            set => iD = value;
        }
    }

}
