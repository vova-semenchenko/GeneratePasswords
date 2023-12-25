using System;
using System.Text;

namespace Password_Generator
{
    public  class Password
    {
        private StringBuilder stringBuilder;

        public Password()
        {
            stringBuilder = new StringBuilder();
        }

        public StringBuilder GetStringBuilder { get => stringBuilder; }

        public void AppendChar(char _char)
        {
            stringBuilder.Append(_char);
        }

        public void AppendString(string _string)
        {
            stringBuilder.Append(_string);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj is Password);
        }

        public bool Equals(Password passwordGenerator)
        {
            return passwordGenerator != null &&
                stringBuilder.ToString() == passwordGenerator.stringBuilder.ToString();
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
