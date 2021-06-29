namespace RGIS.Units
{
    public class Yoctometer : BaseDistance, IDistance
    {
        internal static double FromMeter { get { return 1.0000E+24; } }
        public Yoctometer(double distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Yoctometer(IDistance value)
        {
            Distance = value.ToYoctometer().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Yoctometer()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToYoctometer().Distance;
        }
    }
}