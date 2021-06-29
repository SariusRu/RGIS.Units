namespace RGIS.Units
{
    public class Kilometer : BaseDistance, IDistance
    {
        internal static double FromMeter { get { return 0.001; } }
        public Kilometer(double distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Kilometer(IDistance value)
        {
            Distance = value.ToKilometer().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Kilometer()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToKilometer().Distance;
        }
    }
}