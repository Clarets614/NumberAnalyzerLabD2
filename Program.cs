
Console.WriteLine("Hello what is your name:");

string name = Console.ReadLine();

Console.WriteLine("Today we will be doing some number analyzing, " + name);


Console.WriteLine("Please enter a number between 1 and 100");

int num1 = int.Parse(Console.ReadLine());

if (num1 < 60 && num1 % 2 == 1)
{
    Console.WriteLine(num1);
    Console.WriteLine("Odd and less than 60");
}

else if (num1 >= 2 && num1 <= 24 && num1 % 2 == 0)
{
    Console.WriteLine(num1);
    Console.WriteLine("Even and less than 25");
}
else if (num1 >= 26 && num1 <= 60 && num1 % 2 == 0)
{
    Console.WriteLine(num1);
    Console.WriteLine("Even between 26 and 60 inclusive");
}
else if (num1 > 60 && num1 % 2 == 1)
{
    Console.WriteLine(num1);
    Console.WriteLine("Odd and greater than 60");
}