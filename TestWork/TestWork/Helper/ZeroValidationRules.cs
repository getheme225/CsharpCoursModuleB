using System;
using System.Globalization;
using System.Windows.Controls;

namespace TestWork.Helper
{
    
    public class ZeroValidationRules:ValidationRule
    {
        public double MinValue { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            double v = 0.0;
            try
            {
                if (((string) value).Length > 0)
                    v = double.Parse((String) value);
            }
            catch (Exception e)
            {
                return new ValidationResult(false, "Illegal characters or " + e.Message);
            }

            return v > MinValue
                ? new ValidationResult(false,
                    $"Вводите значения больше{MinValue}")
                : new ValidationResult(true, null);
        }
    }
}