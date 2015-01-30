using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    public class Cities
    {
        public City Citadel { get; set; }
        public City Omno { get; set; }
        public City IlluraniaFirst { get; set; }
        public City IlluraniaLast { get; set; }

        public int CountGPS()
        {
            int overallGPS = 0;

            if (Citadel.Conquered) overallGPS += (Citadel.CityGPS * Citadel.GoldMineLevel);
            else if (Omno.Conquered) overallGPS += (Omno.CityGPS * Omno.GoldMineLevel);
            else if (IlluraniaFirst.Conquered) overallGPS += (IlluraniaFirst.CityGPS * IlluraniaFirst.GoldMineLevel);

            return overallGPS;
        }
    }

