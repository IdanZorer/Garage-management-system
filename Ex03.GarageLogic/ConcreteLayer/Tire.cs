namespace GarageManagementSystem.GarageLogic
{
    public class Tire
    {
        private readonly float r_MaxAirPressure;
        private string m_Manufacturer;
        private float m_CurrentAirPressure;

        public Tire(float i_MaxAir)
        {
            r_MaxAirPressure = i_MaxAir;
        }

        public string Manufacturer
        {
            get { return m_Manufacturer; }
            set { m_Manufacturer = value; }
        }

        public float AirPressure
        {
            get { return m_CurrentAirPressure; }
            set 
            { 
                if(value > MaxAirPresure)
                {
                    throw new ValueOutOfRangeException(0, MaxAirPresure);
                }

                m_CurrentAirPressure = value; 
            }
        }

        public float MaxAirPresure
        {
            get { return r_MaxAirPressure; }
        }

        public void Inflate(float i_AirPressureToAdd)
        {
            m_CurrentAirPressure += i_AirPressureToAdd;
        }
    }
}