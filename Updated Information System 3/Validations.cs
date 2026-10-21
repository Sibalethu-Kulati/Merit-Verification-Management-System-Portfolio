using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Updated_Information_System_3
{
    internal class Validations
    {
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            email = email.Trim();

            try
            {
                var addr = new MailAddress(email);
                if (addr.Address != email) return false;

                string host = addr.Host;
                return host.Contains(".")&& !host.StartsWith(".")&& !host.EndsWith(".");
  
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
