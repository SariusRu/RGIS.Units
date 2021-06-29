namespace RGIS.Units
{
    public class Zeptometer : BaseDistance, IDistance
    {
        internal static double FromMeter { get { return 1.0000E+21; } }
        public Zeptometer(double distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Zeptometer(IDistance value)
        {
            Distance = value.ToZeptometer().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Zeptometer()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToZeptometer().Distance;
        }
    }
}