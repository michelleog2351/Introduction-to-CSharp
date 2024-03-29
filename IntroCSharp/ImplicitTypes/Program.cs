// See https://aka.ms/new-console-template for more information
Console.WriteLine("\nExamples of var implicit types\n`s");

// Let's declare some implicit types
var guessType1 = "Hello There";
var guessType2 = 234.4;

// Use the GetType method to get the type of the current instance
Console.WriteLine("The variable guessType1 has a value of \"{0}\" " + "and a type of \"{1}\"" , guessType1, guessType1.GetType());

Console.WriteLine("The variable guessType2 has a value of \"{0}\" " + "and a type of \"{1}\"", guessType2, guessType2.GetType());