using System;

namespace GarageManagementSystem.GarageLogic
{
    public class ValueOutOfRangeException : Exception
    {
        private float m_MaxValue;
        private float m_MinValue;

        public float MaxValue
        {
            get { return m_MaxValue; }
        }

        public float MinValue
        {
            get { return m_MinValue; }
        }

        public ValueOutOfRangeException(float i_MinValue, float i_MaxValue)
        : base(string.Format("An error occured while trying to set the value, the allowed range is {0} to {1}.", i_MinValue, i_MaxValue))
        {
            m_MaxValue = i_MaxValue;
            m_MinValue = i_MinValue;
        }
    }
}
