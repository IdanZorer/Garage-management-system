namespace GarageManagementSystem.GarageLogic
{
    internal class FuelMotorcycle : FuelVehicle
    {
        private eLicenseType m_LicenseType;
        private int m_EngineCapacity;

        public FuelMotorcycle() : base(2, 28.0f, eFuelType.Octan98, 6.0f) 
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
