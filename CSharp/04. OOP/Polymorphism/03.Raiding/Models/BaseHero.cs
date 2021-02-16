namespace _03.Raiding
{
    public abstract class BaseHero
    {
        protected BaseHero(string name, int power)
        {
            Name = name;
        }

        public string Name { get; set; }

        public virtual int Power { get; set; }


        public virtual string CastAbility()
        {
            return null;
        }
    }
}
