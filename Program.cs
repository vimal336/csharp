using System;

// class Program{
//        static void Main(){
//         string name = "vimal";
//         Console.WriteLine(name);
//         //Console.WriteLine(3 + 3);
//     }
// }

// using System;

// namespace MyApplication
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       // Type your username and press enter
//       Console.WriteLine("Enter username:");

//       // Create a string variable and get user input from the keyboard and store it in the variable
//       string userName = Console.ReadLine();

//       // Print the value of the variable (userName), which will display the input value
//       Console.WriteLine("Username is: " + userName);
//     }
//   }
// }


//Variables

// In C#, there are different types of variables (defined with different keywords), for example:

// int - stores integers (whole numbers), without decimals, such as 123 or -123
// double - stores floating point numbers, with decimals, such as 19.99 or -19.99
// char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
// string - stores text, such as "Hello World". String values are surrounded by double quotes
// bool - stores values with two states: true or false

//string name = "vimal";

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int i = 0; i < 10; i++) 
      {
        if (i == 6) 
        {
          continue;
        }
        Console.WriteLine(i);
      }    
    }
  }
}