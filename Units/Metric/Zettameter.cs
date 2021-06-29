namespace RGIS.Units
{
    public class Zettameter : BaseDistance, IDistance
    {
        internal static double FromMeter { get { return 1.0000E-21; } }
        public Zettameter(double distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Zettameter(IDistance value)
        {
            Distance = value.ToZettameter().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Zettameter()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToZettameter().Distance;
        }
    }
}