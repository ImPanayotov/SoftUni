using _01.Logger.Common;
using _01.Logger.Models.Interfaces;
using System;
using System.Linq;
using System.Reflection;

namespace _01.Logger.Factories
{
    public class LayoutFactory
    {
        public LayoutFactory()
        {

        }

        public ILayout CreateLayout(string layoutTypeStr)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            Type layoutType = assembly.GetTypes().FirstOrDefault(t => t.Name.Equals(layoutTypeStr, StringComparison.InvariantCultureIgnoreCase));

            if (layoutType == null)
            {
                throw new InvalidOperationException(GlobalConstants.InvalidLayOutType);
            }

            object[] ctorArgs = new object[] { };

            ILayout layout = (ILayout)Activator.CreateInstance(layoutType, BindingFlags.Public | BindingFlags.Instance, ctorArgs);

                return layout;
        }
    }
}
