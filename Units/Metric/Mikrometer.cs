﻿namespace RGIS.Units
{
    public class Mikrometer : BaseDistance, IDistance
    {
        internal static double FromMeter { get { return 1000000; } }
        public Mikrometer(double distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Mikrometer(IDistance value)
        {
            Distance = value.ToMikrometer().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Mikrometer()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToMikrometer().Distance;
        }
    }
}