// See https://aka.ms/new-console-template for more information
Console.WriteLine("Demo of sizeOf various data types in C#\n");


Console.WriteLine($"Byte uses {sizeof(byte)} bytes andcan store numbers in the range of {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine(sizeof(char)); // output: 2
Console.WriteLine(sizeof(int));  // output: 4
Console.WriteLine(sizeof(float)); // output: 4
Console.WriteLine(sizeof(double)); // output: 8
Console.WriteLine(sizeof(decimal)); // output: 16