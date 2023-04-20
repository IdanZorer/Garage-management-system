using System;
using System.Collections.Generic;

namespace GarageManagementSystem.GarageLogic
{
    public class Garage
    {
        private VehicleFactory m_VehicleFactory = new VehicleFactory();
        private Dictionary<VehicleOwner, Vehicle> m_VehiclesInGarage = new Dictionary<VehicleOwner, Vehicle>();

        public bool CheckIfInGarage(string i_LicenseNumber, bool i_ChangeVehicleState = true)
        {
            bool inGarage = false;
            if (m_VehiclesInGarage != null)
            {
                foreach (KeyValuePair<VehicleOwner, Vehicle> pair in m_VehiclesInGarage)
                {
                    if (pair.Value.LicenseNumber == i_LicenseNumber)
                    {
                        if (i_ChangeVehicleState == true)
                        {
                            pair.Key.VehicleState = eVehicleState.InRepair;
                        }

                        inGarage = true;
                        break;
                    }
                }
            }

            return inGarage;
        }

        public void AddToGarage(VehicleOwner i_VehicleOwner, Vehicle i_Vehicle)
        {
            m_VehiclesInGarage.Add(i_VehicleOwner, i_Vehicle);
        }
        
        public List<string> GetLicenseNumbers()
        {
            List<string> licenseNumbers = new List<string>();
            foreach (KeyValuePair<VehicleOwner, Vehicle> pair in m_VehiclesInGarage)
            {
                licenseNumbers.Add(pair.Value.LicenseNumber);
            }

            return licenseNumbers;
        }

        public List<string> SortVehiclesBySate(eVehicleState i_VehicleState)
        {
            List<string> sortedVehicles = new List<string>();
            foreach (KeyValuePair<VehicleOwner, Vehicle> pair in m_VehiclesInGarage)
            {
                if (pair.Key.VehicleState == i_VehicleState)
                {
                    sortedVehicles.Add(pair.Value.LicenseNumber);
                }
            }

            return sortedVehicles;
        }

        public void ChangeVehicleState(string i_LicenseNumber, eVehicleState i_VehicleState)
        {
            foreach (KeyValuePair<VehicleOwner, Vehicle> pair in m_VehiclesInGarage)
            {
                if (pair.Value.LicenseNumber == i_LicenseNumber)
                {
                    pair.Key.VehicleState = i_VehicleState;
                    break;
                }
            }
        }

        public void InflateTiresToMax(string i_LicenseNumber)
        {
            foreach (KeyValuePair<VehicleOwner, Vehicle> pair in m_VehiclesInGarage)
            {
                if (pair.Value.LicenseNumber == i_LicenseNumber)
                {
                    foreach (Tire vehicleTire in pair.Value.Tires)
                    {
                        vehicleTire.Inflate(vehicleTire.MaxAirPresure - vehicleTire.AirPressure);
                    }

                    break;
                }
            }
        }

        public void RefuelVehicle(string i_LicenseNumber, eFuelType i_FuelType, float i_AmountOfLitersToAdd)
        {
            foreach (KeyValuePair<VehicleOwner, Vehicle> pair in m_VehiclesInGarage)
            {
                if (pair.Value.LicenseNumber == i_LicenseNumber)
                {
                    if (pair.Value is FuelVehicle)
                    {
                        (pair.Value as FuelVehicle).Refuel(i_AmountOfLitersToAdd, i_FuelType);
                        break;
                    }
                    else
                    {
                        throw new ArgumentException("Electric vehicle can not be refueled.");
                    }
                }
            }
        }

        public void ChargeVehicle(string i_LicenseNumber, float i_AmountOfMinutesToAdd)
        {
            foreach (KeyValuePair<VehicleOwner, Vehicle> pair in m_VehiclesInGarage)
            {
                if (pair.Value.LicenseNumber == i_LicenseNumber)
                {
                    if (pair.Value is ElectricVehicle)
                    {
                        (pair.Value as ElectricVehicle).Charge(i_AmountOfMinutesToAdd / 60);
                        break;
                    }
                    else
                    {
                        throw new ArgumentException("Fuel vehicle can not be charged.");
                    }
                }
            }
        }

        public KeyValuePair<VehicleOwner, Vehicle> GetVehicleDetailsByLicenseNumber(string i_LicenseNumber)
        {
            KeyValuePair<VehicleOwner, Vehicle> vehicleDetailsPair = new KeyValuePair<VehicleOwner, Vehicle>();
            foreach (KeyValuePair<VehicleOwner, Vehicle> pair in m_VehiclesInGarage)
            {
                if (pair.Value.LicenseNumber == i_LicenseNumber)
                {
                    vehicleDetailsPair = pair;
                }
            }

            return vehicleDetailsPair;
        }
    }
}
