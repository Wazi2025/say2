namespace say2;

class Program
{
    static void Main(string[] args)
    {
        //int apples = 4;
        //double oranges = 8.25;

        //int sum = apples + (int)oranges;
        //double sum2 = apples + oranges;
        //Console.WriteLine(sum);
        //Console.WriteLine(sum2);

        // int playerHealth = 100;
        // double fallDmg = 0;
        //double charWeight = 150.7;
        //double fallDistance = 18.5;
        //fallDmg = charWeight * (fallDistance - 5);
        //int currentHealth = playerHealth - (int)fallDmg;
        // while (true)
        // {
        //     Console.WriteLine("Guess a number between 1 and 3:");
        //     int numberGuessed = 0;
        //     string userInput = Console.ReadLine();

        //     if (int.TryParse(userInput, out numberGuessed) && numberGuessed == 2)
        //     {
        //         Console.WriteLine($"Correct, you guessed {numberGuessed}");
        //         break;
        //     }
        //     else
        //     {
        //         Console.WriteLine("Read the instructions again");
        //     }
        // }

        // string numberInput = "11";

        // if (int.TryParse(numberInput, out int number))
        // {
        //     Console.WriteLine($"Our number input is {number}");
        // }
        // else
        // {
        //     Console.WriteLine("The input was not a number!");
        // }

        // string userInput = "SpongeBobMeMe";
        // //string cut = userInput.Substring(6, 8);
        // string replaced = userInput.Replace("Sponge", "Patrick");

        // //Console.WriteLine(userInput);
        // Console.WriteLine(replaced);
        int fahrenheit = 94;
        decimal celsius2 = (fahrenheit - 32m) * (5m / 9m);
        decimal celcius = (decimal)(fahrenheit - 32m) * 5m / 9m;
        //decimal celcius = (fahrenheit - 32) * 5 / 9;
        //Console.WriteLine(message + celcius);
        Console.WriteLine($"The temperature is {celcius:F2} Celcius"); //F2 formats to decimal places
        Console.WriteLine($"The temperature is {celsius2} Celcius");
    }
}
