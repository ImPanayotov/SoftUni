using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Telephony
{
    public class Smartphone : ICalling, IBrowsing
    {
        public string Browse(string url)
        {
            if (url.Any(c => char.IsDigit(c)))
            {
                throw new Exception("Invalid URL!");
            }

            return $"Browsing: {url}!";
        }

        public string Call(string number)
        {
            if (!number.All(c => char.IsDigit(c)))
            {
                throw new Exception("Invalid number!");
            }

            return $"Calling... {number}";
        }
    }
}
