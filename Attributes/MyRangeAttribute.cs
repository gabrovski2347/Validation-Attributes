using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes.Attributes
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
    sealed class MyRangeAttribute : Attribute
    {
        private int minValue;
        private int maxValue;

        public MyRangeAttribute(int minValue, int maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
        }

        public bool IsValid(object obj)
        {
            var number = Convert.ToInt32(obj);
            if (number < minValue || number > maxValue)
            {
                return false;
            }

            return true;
        }
    }
}
