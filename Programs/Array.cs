using System;

  class ArrayProgram
  {
    public static void Run()
    {
      //string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
      int[] numbers = {88, 99, 54, 23};
      //Console.WriteLine(cars[1]);
      //Console.WriteLine(cars.Length-1);
             // Array.Sort(numbers);
      foreach(int num in numbers){
        Console.WriteLine(num);
      }
    }
  }