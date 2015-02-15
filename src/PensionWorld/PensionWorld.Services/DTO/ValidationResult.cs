namespace PensionWorld.Services.DTO
{
    public class ValidationResult
    {
        public bool IsValid { get; set; }

        public string Reason { get; set; }

        public static ValidationResult Valid
        {
            get
            {
                return new ValidationResult { IsValid = true };
            }
        }

        public static ValidationResult Invalid(string reason)
        {
            return new ValidationResult { IsValid = false, Reason = reason };
        }
    }
}