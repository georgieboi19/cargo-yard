using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CargoYard
{
    class Ship
    {
        protected int maxCargo;
        protected int maxHazardous;
        protected int maxChilled;
        protected string shipName;
        protected List<Cargo> arrayList;
        protected int loadedChilled = 0;
        protected int loadedHazardous = 0;
        protected int k = 0;

        public Ship(int maxCargo, int maxHazardous, int maxChilled, string shipName)
        {
            this.maxCargo = maxCargo;
            this.maxHazardous = maxHazardous;
            this.maxChilled = maxChilled;
            this.shipName = shipName;
        }

        public void LoadShip(List<Cargo> cargoList)
        {
            var cargoVar = cargoList;
            foreach(var cargo in cargoVar)
            {
                if(cargo is ChilledCargo chilled)
                {
                    if(loadedChilled < maxChilled)
                    {
                        arrayList.Add(chilled);
                        loadedChilled++;
                    }
                }
                else if(cargo is HarardousCargo harardous)
                {
                    if(loadedHazardous < maxHazardous)
                    {
                        arrayList.Add(harardous);
                        loadedHazardous++;
                    }
                }
                else
                {
                    if(maxCargo - loadedHazardous - loadedChilled)
                }
            }
        }

    }
}
