
namespace _06FoodShortage.Models
{
    public class Robot
    {
        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }

        public string Model { get; set; }
        public string Id { get; }
    }
}
