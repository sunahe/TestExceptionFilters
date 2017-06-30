using System;
using System.IO;

namespace TestExceptionFilters
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        Console.WriteLine("Hello World!");
      }
      catch (Exception e) when (e is IOException)
      {
        Environment.ExitCode = 1;
      }
    }
  }
}
