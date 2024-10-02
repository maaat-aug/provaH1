using System.ComponentModel.DataAnnotations;

namespace provaH1.Validation
{
    public class IdadeValidation : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value == null)
                return false;

            return (int)value >= 18;
        }
    }
}
