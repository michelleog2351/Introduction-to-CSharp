// See https://aka.ms/new-console-template for more information
Console.WriteLine("Dice roll");

// Create a random number generator
Random random = new Random();

int die1 = random.Next(7);
int die2 = random.Next(7);

// Keep rolling some dice until the player rolls 12
while (die1 + die2 != 12)
{ 
    Console.WriteLine($"You threw a {die1} and a {die2} unlucky");
    die1 = random.Next(7);
    die2 = random.Next(7);   
}

Console.WriteLine($"Congratulations you threw a {die1} and a {die2} for a 12");
