using System;
namespace RpgLogicProject
{
    public class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Damage { get; private set; }
        public int Hp { get; set; }

        public Hero(string name, int level, int hp)
        {
            Name = name;
            Level = level;
            Hp = hp;
            Damage = 1*Damage;
        }
    }
}
