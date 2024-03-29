// See https://aka.ms/new-console-template for more information
Console.WriteLine("Simple Switch");

// Display some game options

Console.WriteLine("Greetings Professor Falken. ");
Console.WriteLine("Shall we play a game?");

Console.WriteLine("\nList of games");
Console.WriteLine("1.\t Chess");
Console.WriteLine("2.\t Checkers");
Console.WriteLine("3.\t Backgammon");
Console.WriteLine("4.\t Poker");
Console.WriteLine("5.\t Theaterwide Biotoxic and Chemical Warfare");
Console.WriteLine("6.\t Global Thermonuclear War");

// Ask the user for input
Console.Write("\n Please choose one: ");

// Get the input
int option = Convert.ToInt16(Console.ReadLine());

// Based on the input print out an appropiate message
switch(option)
{
    case 1:
        Console.WriteLine("You have decided to play: Chess");
        break;
    case 2:
        Console.WriteLine("You have decided to play: Checkers");
        break;
    case 3:
        Console.WriteLine("You have decided to play: Backgammon");
        break;
    case 4:
        Console.WriteLine("You have decided to play: Poker");
        break;
    case 5:
        Console.WriteLine("You have decided to play: Theaterwide Biotoxic and Chemical Warfare");
        break;
    case 6:
        Console.WriteLine("You have decided to play: Global Thermonuclear War");
        break;
    default:  
        Console.WriteLine("You have decided to play: tic-tac-toe");
        break;
}