namespace RGIS.Units
{
    public class Megameter : BaseDistance, IDistance
    {
        internal static double FromMeter { get { return 0.000001; } }
        public Megameter(double distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Megameter(IDistance value)
        {
            Distance = value.ToMegameter().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Megameter()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToMegameter().Distance;
        }
    }
}