namespace RGIS.Units
{
    public class Yottameter : BaseDistance, IDistance
    {
        internal static double FromMeter { get { return 1.0000E-24; } }
        public Yottameter(double distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Yottameter(IDistance value)
        {
            Distance = value.ToYottameter().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Yottameter()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToYottameter().Distance;
        }
    }
}