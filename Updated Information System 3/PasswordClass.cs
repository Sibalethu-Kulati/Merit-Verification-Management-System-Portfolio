using System;
using System.Collections.Generic;
using System.Text;
using BCrypt.Net;
using System.Security.Cryptography;

namespace Updated_Information_System_3
{
    internal class PasswordClass
    {
        private const string Upper = "ABCDEFGHJKLMNPQRSTUVWXYZ";
        private const string Lower = "abcdefghijkmnopqrstuvwxyz";
        private const string Digits = "23456789";
        private const string Symbols = "!@#$%*?";

        // Random password that always has upper, lower, digit and symbol.
        public static string GenerateTemporaryPassword(int length = 12)
        {
            string all = Upper + Lower + Digits + Symbols;
            char[] chars = new char[length];

            chars[0] = Pick(Upper);
            chars[1] = Pick(Lower);
            chars[2] = Pick(Digits);
            chars[3] = Pick(Symbols);

            for (int i = 4; i < length; i++)
                chars[i] = Pick(all);

            // Shuffle so the first four aren't always in the same order.
            for (int i = chars.Length - 1; i > 0; i--)
            {
                int j = RandomNumberGenerator.GetInt32(i + 1);
                (chars[i], chars[j]) = (chars[j], chars[i]);
            }

            return new string(chars);
        }
        public static string Hash(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        private static char Pick(string set)
        {
            return set[RandomNumberGenerator.GetInt32(set.Length)];
        }
        public static bool Verify(string typed, string stored)
        {
            // BCrypt hashes start with "$2"
            if (stored.StartsWith("$2"))
                return BCrypt.Net.BCrypt.Verify(typed, stored);

            // Old accounts: plain text
            return stored == typed;
        }
    }
}
