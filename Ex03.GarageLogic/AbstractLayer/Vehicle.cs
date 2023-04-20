namespace GarageManagementSystem.GarageLogic
{
    public abstract class Vehicle
    {
        private readonly Tire[] r_Tires;
        private string m_ModelName;
        private string m_LicenseNumber;
        private float m_EnergyPercentageLeft;

        public Vehicle(int i_Tires, float i_MaxAirPressure)
        {
            r_Tires = new Tire[i_Tires];
            for (int i = 0; i < Tires.Length; i++)
            {
                Tires[i] = new Tire(i_MaxAirPressure);
            }
        }

        public string LicenseNumber
        {
            get { return m_LicenseNumber; }
            set { m_LicenseNumber = value; }
        }

        public string ModelName
        {
            get { return m_ModelName; }
            set { m_ModelName = value; }
        }

        public float EnergyPercentageLeft
        {
            get { return m_EnergyPercentageLeft; }
        }
        
        public void SetEnergyPersentageLeft(float i_EnergyPersentageLeft)
        {
            m_EnergyPercentageLeft = i_EnergyPersentageLeft;
        }

        public Tire[] Tires
        {
            get { return r_Tires; }
        }

        public void SetTireManufacturer(int i_TireIndex, string i_Manufacturer)
        {
            Tires[i_TireIndex].Manufacturer = i_Manufacturer;
        }

        public void SetTireAirPressure(int i_TireIndex, float i_AirPressure)
        {
            Tires[i_TireIndex].AirPressure = i_AirPressure;
        }

        public void SetAllTiresAirPressure(float i_AirPressure)
        {
            for (int i = 0; i < Tires.Length; i++)
            {
                SetTireAirPressure(i, i_AirPressure);
            }
        }

        public void SetAllTiresManufacturer(string i_Manufacturer)
        {
            for (int i = 0; i < this.Tires.Length; i++)
            {
                SetTireManufacturer(i, i_Manufacturer);
            }
        }
    }
}
