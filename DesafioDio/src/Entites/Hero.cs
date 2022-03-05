using System;

namespace DesafioDio.src.Entites
{
    internal abstract class Hero
    {
        public string Name { get; private set; }
        public int Level { get; private set; }
        public string HeroType { get; private set; }
        public int Life { get; set; }


        public Hero(string name, int level, string herotype, int life)
        {
            Name = name;
            Level = level;
            HeroType = herotype;
            Life = life;
        }
        public Hero(){}

    }
}
