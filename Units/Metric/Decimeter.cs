namespace RGIS.Units
{
    public class Decimeter : BaseDistance, IDistance
    {
        internal static double FromMeter { get { return 10; } }
        public Decimeter(double distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Decimeter(IDistance value)
        {
            Distance = value.ToDecimeter().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Decimeter()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToDecimeter().Distance;
        }
    }
}