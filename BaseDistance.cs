using System;

namespace RGIS.Units
{
    public abstract class BaseDistance
    {
        internal double Distance;

        internal double toMeterConversion;

        public string Description;

        public Uri DescriptionLink;

        /// <summary>
        /// Returns to temporary Distance in Meter. Needed for the conversion into the different Units.
        /// The conversion is always IDistance (Origin) --> Meter --> IDistance (Destination).
        /// </summary>
        /// <returns>The distance in Meter</returns>
        private double InMeter()
        {
            return Distance * toMeterConversion;
        }

        /// <summary>
        /// Returns the Distance in the unit of the instance.
        /// </summary>
        /// <returns>Double: The Distance in the unit of the Instance. Full range of double.</returns>
        public double Get()
        {
            return Distance;
        }

        /// <summary>
        /// Sets the distance to the given value in the unit of the instance.
        /// </summary>
        /// <param name="value">The new value of the Distance-Field as double. Has to be in the unit of the instance.</param>
        public void Set(double value)
        {
            Distance = value;
        }

        /// <summary>
        /// Returns the Distance in Parsec.
        /// </summary>
        /// <returns>Distance as Parsec-Instance</returns>
        public Parsec ToParsec()
        {
            return new(InMeter() * Parsec.FromMeter);
        }

        public Centimeter ToCentimeter()
        {
            return new(InMeter() * Centimeter.FromMeter);
        }

        public Decimeter ToDecimeter()
        {
            return new(InMeter() * Decimeter.FromMeter);
        }

        public Milimeter ToMilimeter()
        {
            return new(InMeter() * Milimeter.FromMeter);
        }

        public Foot ToFoot()
        {
            return new(InMeter() * Foot.FromMeter);
        }

        public Inch ToInch()
        {
            return new(InMeter() * Inch.FromMeter);
        }

        public Kilometer ToKilometer()
        {
            return new(InMeter() * Kilometer.FromMeter);
        }

        public Meter ToMeter()
        {
            return new(InMeter());
        }

        public Mile ToMiles()
        {
            return new(InMeter() * Mile.FromMeter);
        }

        public NauticalMile ToNauticMiles()
        {
            return new(InMeter() * NauticalMile.FromMeter);
        }

        public Yard ToYard()
        {
            return new(InMeter() * Yard.FromMeter);
        }

        public LightYear ToLightYear()
        {
            return new(InMeter() * LightYear.FromMeter);
        }

        public Planck ToPlanck()
        {
            return new(InMeter() * Planck.FromMeter);
        }

        public Dekameter ToDekameter()
        {
            return new(InMeter() * Dekameter.FromMeter);
        }

        public Hektometer ToHektometer()
        {
            return new(InMeter() * Hektometer.FromMeter);
        }

        public Mikrometer ToMikrometer()
        {
            return new(InMeter() * Mikrometer.FromMeter);
        }

        public Nanometer ToNanometer()
        {
            return new(InMeter() * Nanometer.FromMeter);
        }

        public AstronomicalUnit ToAstronomicalUnit()
        {
            return new(InMeter() * AstronomicalUnit.FromMeter);
        }

        public Picometer ToPicometer()
        {
            return new(InMeter() * Picometer.FromMeter);
        }

        public Femtometer ToFemtometer()
        {
            return new(InMeter() * Femtometer.FromMeter);
        }

        public Attometer ToAttometer()
        {
            return new(InMeter() * Attometer.FromMeter);
        }

        public Zeptometer ToZeptometer()
        {
            return new(InMeter() * Zeptometer.FromMeter);
        }

        public Yoctometer ToYoctometer()
        {
            return new(InMeter() * Yoctometer.FromMeter);
        }

        public Megameter ToMegameter()
        {
            return new(InMeter() * Megameter.FromMeter);
        }

        public Gigameter ToGigameter()
        {
            return new(InMeter() * Gigameter.FromMeter);
        }

        public Terameter ToTerameter()
        {
            return new(InMeter() * Terameter.FromMeter);
        }

        public Petameter ToPetameter()
        {
            return new(InMeter() * Petameter.FromMeter);
        }

        public Exameter ToExameter()
        {
            return new(InMeter() * Exameter.FromMeter);
        }

        public Zettameter ToZettameter()
        {
            return new(InMeter() * Zettameter.FromMeter);
        }

        public Yottameter ToYottameter()
        {
            return new(InMeter() * Yottameter.FromMeter);
        }
    }
}
