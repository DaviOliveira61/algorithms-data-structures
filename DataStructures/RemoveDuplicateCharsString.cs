/*
 * The string may have two or more same characters in it but we want it to have only one.
 */

namespace DataStructures
{
  class RemoveDuplicatedCharsString
  {
    public void Run()
    {
      Console.Write("Input: ");
      string? input = Console.ReadLine();

      Console.WriteLine("Output: " + RemoveDuplicated(input));
    }

    private string RemoveDuplicated(string input)
    {
      var eachChar = "";

      var finalResult = "";

      foreach (char value in input)
      {

        if (eachChar.Contains(value) == false)
        {
          eachChar += value;
          finalResult += value;
        }
      }
      return finalResult;
    }
  }


}
