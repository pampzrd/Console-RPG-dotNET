using System;
using RPG.src.Entities;

public class Ninja:Hero
{
	public Ninja(string Name, int Level,string HeroType):base(Name, Level, HeroType)
	{
	}

	public override string Attack()
	{
		return this.Name + " atacou furtivamente!";
	}

	public override string Attack(int bonus)
	{
        if (bonus > 6)
        {
            return this.HeroType + " " +  this.Name + " deu uma mega voadora matadora !!!";
        }
        else
        {
            return this.HeroType + " " +  this.Name + " caiu da árvore...";
        }
    }

}
