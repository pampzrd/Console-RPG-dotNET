using System;
using RPG.src.Entities;

public class Wizard:Hero
{
	public Wizard(string Name,int Level,string HeroType):base(Name, Level, HeroType)
	{
	}

	public override string Attack()
	{
		return this.HeroType +" "+ this.Name + " " + " soltou magia!";
	}

	public override string Attack(int bonus)
	{
		if(bonus>6)
		{
			return this.HeroType + " " + this.Name + " soltou uma magia muito forte!!!";
		}else
		{
			return this.HeroType + " " + this.Name+" soltou uma magia muito fraca...";
		}
	}

}
