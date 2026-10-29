using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace Updated_Information_System_3
{
    internal class Validations
    {
        // Keeps your existing robust email validation method exactly as is
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            email = email.Trim();

            try
            {
                var addr = new MailAddress(email);
                if (addr.Address != email) return false;

                string host = addr.Host;
                return host.Contains(".") && !host.StartsWith(".") && !host.EndsWith(".");
            }
            catch (FormatException)
            {
                return false;
            }
        }
        // Postal code validation: Must be digits only and exactly 4 digits long
        public static bool IsValidPostalCode(string postalCode)
        {
            return !string.IsNullOrWhiteSpace(postalCode) &&
                   postalCode.Length == 4 &&
                   Regex.IsMatch(postalCode, @"^\d+$");
        }

        // Checks if a textbox is empty and shows a warning message
        public static bool IsTextBoxEmpty(TextBox textBox, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show($"Please fill in the '{fieldName}' field.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
                return true;
            }
            return false;
        }

        // Phone number validation: Must be 10 digits and start with '0'
        public static bool IsValidPhoneNumber(string phone)
        {
            return !string.IsNullOrWhiteSpace(phone) &&
                   phone.StartsWith("0") &&
                   phone.Length == 10 &&
                   Regex.IsMatch(phone, @"^\d+$");
        }

        // Name validation: Letters and spaces only (no numbers or symbols)
        public static bool IsValidName(string name)
        {
            return !string.IsNullOrWhiteSpace(name) && Regex.IsMatch(name, @"^[a-zA-Z\s]+$");
        }

        // EMIS Number validation for High Schools (exactly 9 digits)
        public static bool IsValidEmisNumber(string emis)
        {
            return !string.IsNullOrWhiteSpace(emis) && emis.Length == 9 && Regex.IsMatch(emis, @"^\d+$");
        }
    }
}