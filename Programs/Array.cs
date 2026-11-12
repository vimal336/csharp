using System;

  class ArrayProgram
  {
    public static void Run()
    {
      string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
      int[] numbers = {898, 99, 54, 23};
      int[] smallbig = {001, 105, 2, 103};
      //Console.WriteLine(cars[1]);
      //Console.WriteLine(cars.Length-1);
      Console.WriteLine(smallbig.Min());
            Array.Sort(numbers);
      foreach(int num in numbers){
        Console.WriteLine(num);
      }
    }
  }