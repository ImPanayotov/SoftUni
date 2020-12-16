using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Computers;
using OnlineShop.Models.Products.Peripherals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.Models.Products
{
    public abstract class Computer : Product, IComputer
    {
        private readonly List<IComponent> components;
        private readonly List<IPeripheral> peripherals;

        protected Computer(int id, string manufacturer, string model, decimal price, double overallPerformance) : base(id, manufacturer, model, price, overallPerformance)
        {
            components = new List<IComponent>();
            peripherals = new List<IPeripheral>();
        }

        public IReadOnlyCollection<IComponent> Components => components.AsReadOnly();

        public IReadOnlyCollection<IPeripheral> Peripherals => peripherals.AsReadOnly();



        public void AddComponent(IComponent component)
        {
            if (components.Any(x => x.GetType() == component.GetType()))
            {
                throw new ArgumentException($"Component {component.GetType().Name} already exists in {GetType().Name} with Id {Id}.");
            }

            components.Add(component);
        }

        public void AddPeripheral(IPeripheral peripheral)
        {
            if (peripherals.Any(x => x.GetType() == peripheral.GetType()))
            {
                throw new ArgumentException($"Peripheral {peripheral.GetType().Name} already exists in {GetType().Name} with Id {Id}.");
            }

            peripherals.Add(peripheral);
        }

        public IComponent RemoveComponent(string componentType)
        {
            if (!components.Any(x => x.GetType().Name == componentType))
            {
                throw new ArgumentException($"Component {componentType} does not exist in {GetType().Name} with Id {Id}.");
            }

            var componentToRemove = components.FirstOrDefault(x => x.GetType().Name == componentType);

            components.Remove(componentToRemove);

            return componentToRemove;
        }

        public IPeripheral RemovePeripheral(string peripheralType)
        {
            if (!peripherals.Any(x => x.GetType().Name == peripheralType))
            {
                throw new ArgumentException($"Peripheral {peripheralType} does not exist in {GetType().Name} with Id {Id}.");
            }

            var peripheralToRemove = peripherals.FirstOrDefault(x => x.GetType().Name == peripheralType);

            peripherals.Remove(peripheralToRemove);

            return peripheralToRemove;
        }

        public override double OverallPerformance
        {
            get
            {
                return CalculateOverallPerformance();
            }
        }

        private double CalculateOverallPerformance()
        {
            if (Components.Count == 0)
            {
                return base.OverallPerformance;
            }

            var result = base.OverallPerformance + Components.Average(x => x.OverallPerformance);

            return result;
        }

        public override decimal Price => Peripherals.Sum(x => x.Price) + Components.Sum(x => x.Price);

        public override string ToString() // Check if errors occurred
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(base.ToString());
            result.AppendLine($" Components ({components.Count}):");

            foreach (var component in components)
            {
                result.AppendLine($"  {component}");
            }

            result.AppendLine($" Peripherals ({peripherals.Count}); Average Overall Performance ({peripherals.Average(x => x.OverallPerformance)}):");

            foreach (var peripheral in peripherals)
            {
                result.AppendLine($"  {peripheral}");
            }

            return result.ToString().TrimEnd();
        }
    }
}