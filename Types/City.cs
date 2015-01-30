using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    public class City
    {
        
        public int FireAffinity { get; set; }
        public int WindAffinity { get; set; }
        public int EarthAffinity { get; set; }
        public int WaterAffinity { get; set; }
        public int MetalAffinity { get; set; }

        public int ArmyPower { get; set; }
        public bool Conquered { get; set; }
        public int MagesTurned { get; set; }

        public int CityGPS { get; set; }
        public int GoldMineLevel { get; set; }

        public City(int fireAff, int windAff, int earthAff, int waterAff, int metalAff, int armyPow, bool conq, int magesTurn, int cityGPS, int goldMineLvl)
        {
            this.FireAffinity = fireAff;
            this.WindAffinity = windAff;
            this.EarthAffinity = earthAff;
            this.WaterAffinity = waterAff;
            this.MetalAffinity = metalAff;

            this.ArmyPower = armyPow;
            this.Conquered = conq;
            this.MagesTurned = magesTurn;

            this.CityGPS = cityGPS;
            this.GoldMineLevel = goldMineLvl;
        }
    }

