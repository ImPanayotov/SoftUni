using _04.WildFarm.Common;
using _04.WildFarm.Models.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;

namespace _04.WildFarm.Factories
{
    public class FoodFactory
    {
        private SerializationInfo excepri;

        public Food CreateFood(string strType, int quantity)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            Type type = assembly.GetTypes().FirstOrDefault(t => t.Name == strType);

            if (type == null)
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidType);
            }

            object[] ctroParams = new object[] { quantity };

            Food food = (Food)Activator.CreateInstance(type, ctroParams);

            return food;
        }
    }
}
