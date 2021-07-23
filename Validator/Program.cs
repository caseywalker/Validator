using System;

namespace Validator
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Validator");
      Console.WriteLine("Please enter a numeric pin code between 4 and 8 digits");
      var pinEntry = Console.ReadLine();
      var validPinCheck = int.TryParse(pinEntry, out int resultCheck);
      while (pinEntry.Length < 4 || pinEntry.Length > 8)
      {
        Console.WriteLine("Pin length invalid, please enter a valid pin between 4 and 8 digits");
        pinEntry = Console.ReadLine();
        while(validPinCheck == false)
        {
          Console.WriteLine("Pin code must be numeric digits, please re-enter a valid pin");
          pinEntry = Console.ReadLine();
          validPinCheck = int.TryParse(pinEntry, out int resultCheck2);
        }
      }
      var validPin = int.TryParse(pinEntry, out int result);
      while (validPin == false)
      {
        Console.WriteLine("Pin code must be numeric digits, please re-enter a valid pin");
        pinEntry = Console.ReadLine();
        validPin = int.TryParse(pinEntry, out int result2);
        while (pinEntry.Length < 4 || pinEntry.Length > 8)
        {
          Console.WriteLine("Pin length invalid, please enter a valid pin between 4 and 8 digits");
          pinEntry = Console.ReadLine();
          validPin = int.TryParse(pinEntry, out int result3);
        }
      }
      Console.WriteLine($"Pin entry is valid, your pin is {pinEntry}");
    }
  }
}
