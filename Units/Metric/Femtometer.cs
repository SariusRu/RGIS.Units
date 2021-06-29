namespace RGIS.Units
{
    public class Femtometer : BaseDistance, IDistance
    {
        internal static double FromMeter { get { return 1.0000E+15; } }
        public Femtometer(double distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Femtometer(IDistance value)
        {
            Distance = value.ToFemtometer().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Femtometer()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToFemtometer().Distance;
        }
    }
}