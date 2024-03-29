// See https://aka.ms/new-console-template for more information
Console.WriteLine("If Selection");

float temperatureToday = 23.4f;
bool rainForecast = true;

if (temperatureToday < 15)
{
    Console.WriteLine("It is a chilly todAY, BRING A JACKET");
}

else if (temperatureToday > 15 && temperatureToday < 18)
{
    Console.WriteLine("The temperar=ture is going to be between 15'C and 18'C");

    if(rainForecast)
    {
        Console.WriteLine(", but rain is forecast so bring an umbrella ");
    }

    else
    {
        Console.WriteLine(", but rain isn't forecast so need for an umbrella ");
    }
}

else if (temperatureToday > 23 && rainForecast != true)
{
    Console.WriteLine(",It is going to be a great day, time to head to the shore?");
}

else
{
    Console.WriteLine("Hmm, it's going to be quite muggy today");
}
