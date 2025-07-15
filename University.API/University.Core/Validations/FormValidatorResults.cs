using System.ComponentModel.DataAnnotations;

namespace University.Core.Validations
{
    public class FormValidatorResults
    {
        public bool IsValid { get; set; }
        public Dictionary<string, List<string>> Errors { get; set; }

        public FormValidatorResults(bool _isValid, List<ValidationResult> results)
        {

            IsValid = _isValid;
            if (!IsValid && results != null)
            {
                Errors = new Dictionary<string, List<string>>();
                foreach (var item in results)
                {
                    var message = item.ErrorMessage;
                    foreach (var member in item.MemberNames)
                    {
                        if (!Errors.ContainsKey(member))
                            Errors.Add(member, new List<string>());
                        Errors[member].Add(message ?? string.Empty);
                    }
                }
            }
        }
    }
}