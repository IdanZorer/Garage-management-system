namespace GarageManagementSystem.GarageLogic
{
    internal class Truck : FuelVehicle
    {
        private bool m_HasHazardousMaterials;
        private float m_CargoVolume;

        public Truck() : base(14, 34.0f, eFuelType.Soler, 120.0f) 
        {
        }

        public bool HasHazardousMaterials
        {
            get { return m_HasHazardousMaterials; }
            set { m_HasHazardousMaterials = value; }
        }

        public float CargoVolume
        {
            get { return m_CargoVolume; }
            set { m_CargoVolume = value; }
        }
    }
}
