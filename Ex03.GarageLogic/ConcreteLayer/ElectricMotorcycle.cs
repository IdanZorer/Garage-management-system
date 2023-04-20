namespace GarageManagementSystem.GarageLogic
{
    internal class ElectricMotorcycle : ElectricVehicle
    {
        private eLicenseType m_LicenseType;
        private int m_EngineCapacity;

        public ElectricMotorcycle() : base(2, 28.0f, 1.6f) 
        { 
        }

        public eLicenseType LicenseType
        {
            get { return m_LicenseType; }
            set { m_LicenseType = value; }
        }

        public int EngineCapacity
        {
            get { return m_EngineCapacity; }
            set { m_EngineCapacity = value; }
        }
    }
}
