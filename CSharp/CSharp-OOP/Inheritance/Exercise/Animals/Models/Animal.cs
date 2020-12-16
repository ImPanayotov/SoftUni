

using System;
using System.Text;

namespace Animals.Models
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;
        protected Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.age = value;
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                if (value != "Male" && value != "Female")
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.gender = value;
            }
        }


        public abstract string ProduceSound();

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(GetType().Name);
            result.AppendLine($"{Name} {Age} {Gender}");
            result.AppendLine(ProduceSound());

            return result.ToString().TrimEnd();
        }
    }
}
