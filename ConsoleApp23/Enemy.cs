using System;
namespace RpgLogicProject
{
    public class Enemy
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Hp { get; set; }
        public int Damage { get; set; }

        public Enemy(string name, int level, int damage, int hp)
        {
            Name = name;
            Level = level;
            Damage = damage;
            Hp = hp;

        }
    }
}
