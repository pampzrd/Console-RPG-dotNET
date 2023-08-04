using RPG.src.Entities;

Knight arus = new Knight("Arus",10,"Knight");
Wizard jenica = new Wizard("Jenica", 10, "White Wizard");
Wizard topapa = new Wizard("Topapa", 10, "Black Wizard");
Ninja wedge = new Ninja("Wedge", 20, "Ninja");


Console.WriteLine(arus.ToString());
//Console.WriteLine(arus.Attack());
Console.WriteLine(arus.Attack(2));
Console.WriteLine(jenica.Attack(90));
Console.WriteLine(topapa.Attack(30));
Console.WriteLine(wedge.Attack(50));
Console.WriteLine("O montro ataca ! ! ! ");
Console.WriteLine(arus.Attack(32));
Console.WriteLine(jenica.Attack(5));
Console.WriteLine(topapa.Attack(13));
Console.WriteLine(wedge.Attack(2));



