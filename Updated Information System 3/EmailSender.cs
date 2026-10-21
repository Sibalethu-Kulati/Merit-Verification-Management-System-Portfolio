using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text.Json;
using System.Threading.Tasks;

namespace Updated_Information_System_3
{
    internal static class EmailSender
    {
        private class Settings
        {
            public string Host { get; set; }
            public int Port { get; set; }
            public string SenderEmail { get; set; }
            public string SenderName { get; set; }
            public string AppPassword { get; set; }
        }

        private static Settings LoadSettings()
        {
            string path = Path.Combine(AppContext.BaseDirectory, "emailsettings.json");

            if (!File.Exists(path))
                throw new InvalidOperationException(
                    "emailsettings.json was not found next to the application.");

            return JsonSerializer.Deserialize<Settings>(File.ReadAllText(path));
        }

        public static async Task SendLoginDetailsAsync(
            string toEmail, string adminName, string institutionName, string tempPassword)
        {
            Settings s = LoadSettings();

            string body =
                "Hello " + adminName + ",\n\n" +
                "Your request for " + institutionName + " has been approved.\n\n" +
                "Your login details:\n" +
                "Email: " + toEmail + "\n" +
                "Password: " + tempPassword + "\n\n" +
                "Please keep these details private.\n\n" +
                "Merit Certificate Verification System";

            using (var message = new MailMessage())
            {
                message.From = new MailAddress(s.SenderEmail, s.SenderName);
                message.To.Add(toEmail);
                message.Subject = "Your login details - Merit Certificate Verification";
                message.Body = body;

                using (var client = new SmtpClient(s.Host, s.Port))
                {
                    client.EnableSsl = true;
                    client.Credentials = new NetworkCredential(
                        s.SenderEmail, s.AppPassword.Replace(" ", ""));

                    await client.SendMailAsync(message);
                }
            }
        }
    }
}