using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boca_Danut_Lab6
{
    //validator pentru camp required
    public class StringNotEmpty : ValidationRule
    {
        //mostenim din clasa ValidationRule
        //suprascriem metoda Validate ce returneaza un
        //ValidationResult
        public override ValidationResult Validate(object value,
        System.Globalization.CultureInfo cultureinfo)
        {
            string aString = value.ToString();
            if (aString == "")
                return new ValidationResult(false, "String cannot be empty");
            return new System.Windows.Controls.ValidationResult(true, null);
        }
    }
    //validator pentru lungime minima a string-ului
    public class StringMinLengthValidator : ValidationRule
    {
        public override ValidationResult Validate(object value,
        System.Globalization.CultureInfo cultureinfo)
        {
            string aString = value.ToString();
            if (aString.Length < 3)
                return new ValidationResult(false, "String must have at least 3 characters!");
            return new ValidationResult(true, null);
        }
    }
}
