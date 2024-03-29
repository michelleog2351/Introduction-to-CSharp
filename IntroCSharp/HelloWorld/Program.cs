// See https://aka.ms/new-console-template for more information
Console.WriteLine("Declaring Variables");

int aSimpleNumber = 232;

char c = 'c';

// Error message: Unsafe conversion...cannot implicitly convert int to a character
// we can set a cast instead to perform a safe operation
// c = aSimpleNumber;

// method 1
c = (char)aSimpleNumber;

Console.WriteLine(c);
