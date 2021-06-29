namespace RGIS.Units
{
    public class Planck : BaseDistance, IDistance
    {
        internal static double FromMeter { get { return 6.187927353E+34; } }
        public Planck(double distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Planck(IDistance value)
        {
            Distance = value.ToPlanck().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Planck()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToPlanck().Distance;
        }
    }
}