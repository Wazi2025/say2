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


        decimal celcius = (decimal)(fahrenheit - 32m) * (5m / 9m);
        decimal celcius2 = (fahrenheit - 32) * 5 / 9;
        decimal celcius3 = (decimal)(fahrenheit - 32m) * 5m / 9m;
        //celcius = Math.Round(celcius, 2); //round down to 2 digits
        //Console.WriteLine(message + celcius);
        Console.WriteLine($"The temperature is {celcius} Celcius");
        Console.WriteLine($"The temperature is {celcius2:f2} Celcius2"); //F2 formats to 2 decimal places
        Console.WriteLine($"The temperature is {celcius3} Celcius3\n");
        // int result = 3 + 1 * 5 / 2;
        // double result2 = 5 / 10;
        // Console.WriteLine($"Result: {result}");
        // Console.WriteLine($"Result2: {result2}");
        // initialize variables - graded assignments 

        int currentAssignments = 5;

        int sophia1 = 93;
        int sophia2 = 87;
        int sophia3 = 98;
        int sophia4 = 95;
        int sophia5 = 100;

        int nicolas1 = 80;
        int nicolas2 = 83;
        int nicolas3 = 82;
        int nicolas4 = 88;
        int nicolas5 = 85;

        int zahirah1 = 84;
        int zahirah2 = 96;
        int zahirah3 = 73;
        int zahirah4 = 85;
        int zahirah5 = 79;

        int jeong1 = 90;
        int jeong2 = 92;
        int jeong3 = 98;
        int jeong4 = 100;
        int jeong5 = 97;

        int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
        int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
        int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
        int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

        decimal sophiaScore = (decimal)sophiaSum / currentAssignments;
        decimal nicolasScore = (decimal)nicolasSum / currentAssignments;
        decimal zahirahScore = (decimal)zahirahSum / currentAssignments;
        decimal jeongScore = (decimal)jeongSum / currentAssignments;

        Console.WriteLine("Student\t\tGrade\n");
        Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
        Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
        Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
        Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");
    }
}
