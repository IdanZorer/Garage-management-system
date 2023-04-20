namespace GarageManagementSystem.GarageLogic
{
    internal class FuelCar : FuelVehicle
    {
        private eColor m_Color;
        private eNumberOfDoors m_NumOfDoors;

        public FuelCar() : base(5, 32.0f, eFuelType.Octan95, 50.0f) 
        {
        }

        public eColor Color
        {
            get { return m_Color; }
            set { m_Color = value; }
        }

        public eNumberOfDoors NumberOfDoors
        {
            get { return m_NumOfDoors; }
            set { m_NumOfDoors = value; }
        }
    }
}
