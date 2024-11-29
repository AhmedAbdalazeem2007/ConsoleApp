
using System.ComponentModel.DataAnnotations;

namespace ConsolePractices
{
    public class EmailSetting
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string DisplayName { get; set; }
        public string Host { get; set; }
        public string Port { get; set; }
        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email && VerifyDomain(addr.Host);
            }
            catch { return false; }
        }
        private bool VerifyDomain(string domain)
        {
            try
            {
                var addresses = Dns.GetHostAddresses(domain);
                return addresses != null && addresses.Length > 0;
            }
            catch { return false; }
        }
        public bool isvalid(string email)
        {
            return new EmailAddressAttribute().IsValid(email);
        }
    }
}