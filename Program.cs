using System;
public class Dice
{
    private int numberOfSides;

    private static  Random rnd = new Random(); 
        
    public Dice(int numberOfSides)
    {
        if (numberOfSides < 4 || numberOfSides > 20)
        {
            throw new ArgumentOutOfRangeException("Should be in rnage [4,20] ");
        }
        this.numberOfSides = numberOfSides;

    }

    public int rollDie()
    {
        return rnd.Next(1, numberOfSides + 1);
    }

}
public class DiceTest
{
    public static void Main()
    {
        Dice dieOne = new Dice(6);
        Dice dieTwo = new Dice(6);

        int die1;
        int die2;
        int numberOfRolls = 0;

        do
        {
            die1 = dieOne.rollDie();
            die2 = dieTwo.rollDie();

            Console.WriteLine("Dice 1: " + die1 + ", Die 2: " + die2);

            ++numberOfRolls;
        }
        while (die1 != 1 || die2 != 1);

            Console.WriteLine("It took " + numberOfRolls + " rolls to get snake eyes!");
    }

}

