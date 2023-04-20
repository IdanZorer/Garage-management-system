namespace GarageManagementSystem.GarageLogic
{
    public enum eVehicleState
    {
        InRepair,
        Repaired,
        Paid
    }

    public class VehicleOwner
    {
        private readonly string r_OwnerName;
        private readonly string r_OwnerPhoneNumber;
        private eVehicleState m_VehicleState = eVehicleState.InRepair;

        public VehicleOwner(string i_OwnerName, string i_OwnerPhoneNumber)
        {
            r_OwnerName = i_OwnerName;
            r_OwnerPhoneNumber = i_OwnerPhoneNumber;
        }

        public string OwnerName
        {
            get { return r_OwnerName; }
        }

        public string OwnerPhoneNumber
        {
            get { return r_OwnerPhoneNumber; }
        }

        public eVehicleState VehicleState
        {
            get { return m_VehicleState; }
            set { m_VehicleState = value; }
        }
    }
}
