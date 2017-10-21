namespace air22
{
    abstract class Airplane
    {
        static Airplane()
        {
            MinAltitudeAuto = 2000;
            MaxAltitudeAuto = 10000;
        }
        public int Capacity { get; private set; }
        public bool AutoPilotOn { get; set; }
        public bool Forsage { get; set; }
        
        public float Consuption { get; private set; }

        public int Altitude { get; private set; }


        public static decimal TicketPrice { get; set; }
        public static int MinAltitudeAuto { get; set; }
        public static int MaxAltitudeAuto { get; set; }

        private int _altitudeIncrement;

        public Airplane(int capacity, float consuption, int altitudeIncrement)
        {
            Altitude = 1200;
            AutoPilotOn = false;
            Capacity = capacity;
            Consuption = consuption;
            _altitudeIncrement = altitudeIncrement;
        }

        private int Climb(int increment)
        {
            if (Forsage) increment *= 2;
            if (!AutoPilotOn) return Altitude += increment;

            if (Altitude + increment < MaxAltitudeAuto)
            {
                return Altitude += increment;
            }

            return Altitude = MaxAltitudeAuto;
        }

        private int Down(int increment)
        {
            if (AutoPilotOn)
            {
                if (Altitude - increment > MinAltitudeAuto)
                {
                    return Altitude -= increment;
                }
                if (Altitude < MinAltitudeAuto) return Altitude;
                return Altitude = MinAltitudeAuto;
            }

            if (Altitude - increment < 0) return Altitude = 0;
            return Altitude -= increment;
        }

        public void SetAltitude(int targetAlitude)
        {
            if (AutoPilotOn)
            {
                if (targetAlitude > MaxAltitudeAuto || targetAlitude < MinAltitudeAuto)
                {
                    if (Altitude < targetAlitude) Altitude = MaxAltitudeAuto;
                    else if (Altitude > targetAlitude) Altitude = MinAltitudeAuto;
                    else Altitude = Altitude;
                }
                else
                {
                    if (Altitude < targetAlitude) Altitude = Climb(targetAlitude - Altitude);
                    else if (Altitude > targetAlitude) Altitude = Down(Altitude - targetAlitude);
                    else Altitude = Altitude;
                }
            }
            else
            {
                if (Altitude < targetAlitude) Altitude = Climb(targetAlitude - Altitude);
                else if (Altitude > targetAlitude) Altitude = Down(Altitude - targetAlitude);
                else Altitude = Altitude;
            }
        }
    }
}
