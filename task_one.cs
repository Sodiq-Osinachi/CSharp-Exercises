using System;

namespace task_one
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter the value of n: ");
      int valueOfn = int.Parse(Console.ReadLine());
      string result = Exercise.TaskOne(valueOfn);

      Console.WriteLine(result);
    }
  }
}
