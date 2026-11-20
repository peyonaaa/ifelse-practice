using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata;

/*Your task
Create a C# console program that:

Asks the user to enter their name.

Asks the user to enter their grade (0–100).

Uses an if-else statement to check if the student passed or failed.

Uses a nested if statement to check if the student deserves an excellent mark.

Rules
Grade 90–100: Excellent!

Grade 75–89: Passed!

Grade 0–74: Failed!

Grade below 0 or above 100: Invalid grade! */


Console.Write("Enter name: ");
string name = Console.ReadLine();

Console.Write("Ente Grade: ");
int grade = int.Parse(Console.ReadLine()!);

if (grade >= 90 && grade == 100)
{
    Console.WriteLine("Excellent!");
    
    else if(grade >= 75 && grade == 89)
    {
        Console.WriteLine("Passed!");
    }
    else if(grade >= 0 && grade == 74)
    {
        Console.WriteLine("Failed!");
    }
}
else 
    Console.WriteLine(("Invalid Grade!");
}

