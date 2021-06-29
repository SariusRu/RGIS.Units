namespace RGIS.Units
{
    public class Dekameter : BaseDistance, IDistance
    {
        internal static double FromMeter { get { return 0.1; } }
        public Dekameter(double distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Dekameter(IDistance value)
        {
            Distance = value.ToDekameter().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Dekameter()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToDekameter().Distance;
        }
    }
}