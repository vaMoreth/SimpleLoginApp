namespace SimpleLoginApp.Models
{
    public class CaptchaResponse
    {
        public bool Success { get; set; }
        public IEnumerable<string> ErrorCodes { get; set; }
    }
}
