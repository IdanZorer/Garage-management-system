namespace GarageManagementSystem.GarageLogic
{
    internal abstract class ElectricVehicle : Vehicle
    {
        private readonly float r_MaxBatteryTime;
        private float m_BatteryTimeLeft;

        public ElectricVehicle(int i_tires, float i_maxAirPressure, float i_maxBatteryTime) : base(i_tires, i_maxAirPressure) 
        {
            r_MaxBatteryTime = i_maxBatteryTime;
        }

        public float BatteryHoursLeft
        {
            get { return m_BatteryTimeLeft; }
            set
            {
                if (value > MaxBatteryHours)
                {
                    throw new ValueOutOfRangeException(0, MaxBatteryHours);
                }

                m_BatteryTimeLeft = value;
                SetEnergyPersentageLeft((m_BatteryTimeLeft / MaxBatteryHours) * 100);
            }
        }

        public float MaxBatteryHours
        {
            get { return r_MaxBatteryTime; }
        }

        public void Charge(float i_NumOfHoursToAdd)
        {
            BatteryHoursLeft += i_NumOfHoursToAdd;
        }
    }
}
