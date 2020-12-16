using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {
        private string name;

        private int badges;

        private List<Pokemon> pokemons;


        public Trainer(string name)
        {
            this.Name = name;
            this.Pokemons = new List<Pokemon>();
            this.Badges = 0;
        }
        public Trainer(string name, int badges, List<Pokemon> pokemons)
            : this(name)
        {

            this.Badges = badges;
            this.Pokemons = pokemons;
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Badges
        {
            get { return badges; }
            set { badges = value; }
        }

        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
            set { pokemons = value; }
        }

    }
}
