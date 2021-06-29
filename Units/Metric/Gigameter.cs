namespace RGIS.Units
{
    public class Gigameter : BaseDistance, IDistance
    {
        internal static double FromMeter { get { return 1.0000E-9; } }
        public Gigameter(double distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Gigameter(IDistance value)
        {
            Distance = value.ToGigameter().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Gigameter()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToGigameter().Distance;
        }
    }
}