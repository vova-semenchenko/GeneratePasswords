using System;
using System.Security.Cryptography;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Password_Generator
{
    public  class Password
    {
        private StringBuilder stringBuilder;
        private SHA256Managed manager;

        public Password()
        {
            stringBuilder = new StringBuilder();
            manager = new SHA256Managed();
        }

        public StringBuilder GetStringBuilder { get => stringBuilder; }

        public void AppendChar(char _char)
        {
            stringBuilder.Append(_char);
            GetSHA256();
        }

        public void AppendString(string _string)
        {
            stringBuilder.Append(_string);
            GetSHA256();
        }

        public string GetSHA256()
        {
            byte[] bytes = Encoding.Unicode.GetBytes(stringBuilder.ToString());
            byte[] hash = manager.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj is Password);
        }

        public bool Equals(Password passwordGenerator)
        {
            return passwordGenerator != null && GetSHA256() == passwordGenerator.GetSHA256();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(stringBuilder);
        }

        public override string ToString()
        {
            return stringBuilder.ToString();
        }
    }
}
