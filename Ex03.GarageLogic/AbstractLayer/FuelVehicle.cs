using System;

namespace GarageManagementSystem.GarageLogic
{
    public enum eFuelType
    {
        Octan98,
        Octan96,
        Octan95,
        Soler
    }

    internal abstract class FuelVehicle : Vehicle
    {
        private readonly eFuelType r_FuelType;
        private readonly float r_MaxFuelLevel;
        private float m_CurrentFuelLevel;

        public FuelVehicle(int i_Tires, float i_MaxAirPressure, eFuelType i_FuelType, float i_MaxFuelLevel) : base(i_Tires, i_MaxAirPressure)
        {
            r_FuelType = i_FuelType;
            r_MaxFuelLevel = i_MaxFuelLevel;
        }

        public float CurrentFuelLevel
        {
            get { return m_CurrentFuelLevel; }
            set
            {
                if (value > MaxFuelLevel)
                {
                    throw new ValueOutOfRangeException(0, MaxFuelLevel);
                }

                m_CurrentFuelLevel = value;
                SetEnergyPersentageLeft((CurrentFuelLevel / MaxFuelLevel) * 100);
            }
        }

        public float MaxFuelLevel
        {
            get { return r_MaxFuelLevel; }
        }

        public eFuelType FuelType
        {
            get { return r_FuelType; }
        }

        public void Refuel(float i_FuelLitersToAdd, eFuelType i_FuelType)
        {
            if (i_FuelType != FuelType)
            {
                throw new ArgumentException(string.Format("An error has occured, The expected fuel type is {0} but recieved {1}.", FuelType, i_FuelType));
            }

            CurrentFuelLevel += i_FuelLitersToAdd;
        }
    }
}
