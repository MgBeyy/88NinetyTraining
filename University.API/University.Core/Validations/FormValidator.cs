using System.ComponentModel.DataAnnotations;

namespace University.Core.Validations
{
    public class FormValidator
    {
        public static FormValidatorResults Validate(object Form) 
        {
            var context = new ValidationContext(Form);
            var results = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(Form, context, results, true);

            return new FormValidatorResults(isValid, results);
        }
    }
}
