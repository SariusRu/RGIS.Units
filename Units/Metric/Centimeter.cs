namespace RGIS.Units
{
    public class Centimeter : BaseDistance, IDistance
    {
        internal static double FromMeter { get { return 100; } }

        public Centimeter(double distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Centimeter(IDistance value)
        {
            Distance = value.ToCentimeter().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Centimeter()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToCentimeter().Distance;
        }
    }
}