using System;
using System.Collections.Generic;

// possible object:
// deck of cards
// cards
// die
// player
// board or game class
// marker

public class Die
{
	public bool isRed;
	public int val;
	public int sides;
	public Random rand;
	
	public Die(int sides, bool isRed)
	{
		this.sides = sides;
		this.isRed = isRed;
		this.val = 1;
	}
	
	public Die(bool isRed)
	{
		this.sides = 6;
		this.isRed = isRed;
		this.val = 1;
	}
	
	public void Roll(Random rand)
	{
		this.val = rand.Next(1, this.sides + 1);
	}
}

public class Card
{
	public string suits;
	public int val;
	private dict<int, string>;
}

public class Program
{
	public static void Main()
	{
		var redDie = new Die(6, true);
		Die blackDie = new Die();
		var bigDie = new Die(100, true)
		var rand = new Random();
		Console.WriteLine("Hello World");
	}
}