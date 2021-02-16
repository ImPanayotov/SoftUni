

namespace _06FoodShortage.Interfaces
{
    public interface IBuyer
    {
        string Name { get; }
        int Food { get; set; }
        void BuyFood();
    }
}
