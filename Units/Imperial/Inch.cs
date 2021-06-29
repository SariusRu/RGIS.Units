namespace RGIS.Units
{
    public class Inch : BaseDistance, IDistance
    {
        internal static double FromMeter { get { return 39.3700787; } }
        public Inch(double distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Inch(IDistance value)
        {
            Distance = value.ToInch().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Inch()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToInch().Distance;
        }
    }
}