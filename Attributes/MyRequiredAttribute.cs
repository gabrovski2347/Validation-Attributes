using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes.Attributes
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class MyRequiredAttribute : Attribute
    {
        bool IsValid(Object obj)
        {
            if (obj == null)
            {
                return false;
            }

            return true;
        }
    }
}
