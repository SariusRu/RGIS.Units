namespace RGIS.Units
{
    public class Mile : BaseDistance, IDistance
    {
        internal static double FromMeter { get { return 0.00062137; } }
        public Mile(double distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Mile(IDistance value)
        {
            Distance = value.ToMiles().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Mile()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToMiles().Distance;
        }
    }
}