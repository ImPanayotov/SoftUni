using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Telephony
{
    public class StationaryPhone : ICalling
    {

        public string Call(string number)
        {
            if (!number.All(c => char.IsDigit(c)))
            {
                throw new Exception("Invalid number!");
            }

            return $"Dialing... {number}";
        }
    }
}
