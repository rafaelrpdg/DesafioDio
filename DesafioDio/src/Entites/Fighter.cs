using System;

namespace DesafioDio.src.Entites
{
    internal class Fighter : Hero
    {
        public int Damage { get; private set; }
        public Fighter(string name, int level, string herotype, int damage, int life = 1000) : base(name, level, herotype, life)
        {
            Damage = damage;
        }

        public Fighter(){}

        public string Blow(Hero Enimy)
        {
            Enimy.Life -= Damage;
            return $"{this.Name} atacou {Enimy.Name} sofreu dano de -{Damage}. Vida: {Enimy.Life}";
        }

        public override string ToString()
        {
            return $@"
            Nome: {this.Name}
            Nivel: {this.Level}
            Tipo de Heroi: {this.HeroType}
            Dano: {this.Damage}
            Vida: {this.Life}";
        }
    }

}