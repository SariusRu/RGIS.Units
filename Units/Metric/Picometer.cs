﻿namespace RGIS.Units
{
    public class Picometer : BaseDistance, IDistance
    {
        internal static double FromMeter { get { return 1.0000E+12; } }
        public Picometer(double distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Picometer(IDistance value)
        {
            Distance = value.ToPicometer().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Picometer()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToPicometer().Distance;
        }
    }
}