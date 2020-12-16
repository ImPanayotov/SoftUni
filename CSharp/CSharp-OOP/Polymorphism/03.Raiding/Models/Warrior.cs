namespace _03.Raiding
{
    public class Warrior : BaseHero
    {
        public Warrior(string name, int power) : base(name, power)
        {
            this.Name = name;
            this.Power = power;
        }

        

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} hit for {this.Power} damage";
        }
    }
}
