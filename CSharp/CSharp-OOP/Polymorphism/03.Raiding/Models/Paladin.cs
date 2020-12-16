namespace _03.Raiding
{
   public class Paladin : BaseHero
    {
        public Paladin(string name, int power) : base(name, power)
        {
            this.Name = name;
            this.Power = power;
        }

        

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} healed for {this.Power}";
        }
    }
}
