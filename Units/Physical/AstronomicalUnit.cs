namespace RGIS.Units
{
    public class AstronomicalUnit : BaseDistance, IDistance
    {
        internal static double FromMeter { get { return 6.6846E-12; } }
        public AstronomicalUnit(double distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public AstronomicalUnit(IDistance value)
        {
            Distance = value.ToAstronomicalUnit().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public AstronomicalUnit()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToAstronomicalUnit().Distance;
        }
    }
}