namespace RGIS.Units
{
    public class Hektometer : BaseDistance, IDistance
    {
        internal static double FromMeter { get { return 0.01; } }
        public Hektometer(double distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Hektometer(IDistance value)
        {
            Distance = value.ToHektometer().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Hektometer()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToHektometer().Distance;
        }
    }
}