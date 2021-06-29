namespace RGIS.Units
{
    public class Terameter : BaseDistance, IDistance
    {
        internal static double FromMeter { get { return 1.0000E-12; } }
        public Terameter(double distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Terameter(IDistance value)
        {
            Distance = value.ToTerameter().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Terameter()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToTerameter().Distance;
        }
    }
}