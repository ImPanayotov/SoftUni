using System;
using System.Collections.Generic;
using System.Text;

namespace _04.BorderControl
{
    public class Citizens : IId
    {
        public Citizens(string name, int age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get; private set; }
    }
}
