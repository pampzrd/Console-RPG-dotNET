using System;

namespace RPG.src.Entities
{

    public abstract class Hero
    {
        public Hero(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;

        }

        public string Name; //{ get; set; }
        public int Level;
        public string HeroType;

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack()
        {
            return this.HeroType + " " + this.Name + " " + "atacou com sua espada!";
        }

        public virtual string Attack(int bonus)
        {
            if (bonus > 6)
            {
               return this.HeroType + " " + this.Name+" deu um golpe muito forte!!!";
            }
            else
            {
               return this.HeroType + " " + this.Name+" deu um golpe muito fraco...";
            }
        }


    }
}
