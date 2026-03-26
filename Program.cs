// RUN COMMAND

// Project Folder => dotnet run

//practice

// Even/Odd checker

// Prime number program

// Factorial program

// Fibonacci series

// Reverse a string

// Palindrome check

// Sum of digits

// Largest of 3 numbers

// Simple calculator

// Student grade system

//Hello World

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
    }
}


//using System;

// class Program{
//        static void Main(){
//         string name = "vimal";
//         Console.WriteLine(name);
//         //Console.WriteLine(3 + 3);
//     }
// }

//User Input

Console.Write("Enter your name: ");
string name = Console.ReadLine();

Console.WriteLine("Hello " + name);


//Variables

// In C#, there are different types of variables (defined with different keywords), for example:

// int - stores integers (whole numbers), without decimals, such as 123 or -123
// double - stores floating point numbers, with decimals, such as 19.99 or -19.99
// char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
// string - stores text, such as "Hello World". String values are surrounded by double quotes
// bool - stores values with two states: true or false

//string name = "vimal";

int a = 10;
double b = 5.5;
char c = 'A';
string name = "Vimal";
bool isActive = true;

Console.WriteLine(a + " " + b + " " + c + " " + name + " " + isActive);

//operators

int a = 10, b = 5;

Console.WriteLine(a + b); // Add
Console.WriteLine(a - b); // Subtract
Console.WriteLine(a * b); // Multiply
Console.WriteLine(a / b); // Divide
Console.WriteLine(a % b); // Modulus

//if else

int age = 14;

if (age >= 18)
{
    Console.WriteLine("Eligible to vote");
}
else
{
    Console.WriteLine("Not Eligible to vote");
}


// loop

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int i = 0; i < 10; i++) 
      {
        if (i == 7) 
        {
          continue;
        }
        Console.WriteLine(i);
      }    
    }
  }
}
