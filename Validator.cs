using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            var props = obj.GetType().GetProperties();

            foreach (var prop in props)
            {
                var attributes = prop
                    .GetCustomAttributes(true)
                    .Where(a => a is MyValidationAttribute)
                    .Cast<MyValidationAttribute>()
                    .ToArray();

                foreach (var attr in attributes)
                {
                    if (!attr.IsValid(prop.GetValue(obj)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
