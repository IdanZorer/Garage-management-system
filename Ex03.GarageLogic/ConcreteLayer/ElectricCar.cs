namespace GarageManagementSystem.GarageLogic
{
    internal class ElectricCar : ElectricVehicle
    {
        private eColor m_Color;
        private eNumberOfDoors m_NumOfDoors;

        public ElectricCar() : base(5, 32.0f, 4.7f) 
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
