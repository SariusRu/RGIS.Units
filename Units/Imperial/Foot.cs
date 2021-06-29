namespace RGIS.Units
{
    public class Foot : BaseDistance, IDistance
    {
        internal static double FromMeter { get { return 3.2808399; } }
        public Foot(double distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Foot(IDistance value)
        {
            Distance = value.ToFoot().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Foot()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToFoot().Distance;
        }
    }
}