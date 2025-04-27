// Two words are said to be Anagrams of each other if they share the same set of letters to form the respective words.
// For an example: Silent–>Listen, post–>opts.
namespace DataStructures;

class IsAnagrams
{
  public void Run()
  {
    Console.WriteLine("First word");
    string firstWord = Console.ReadLine();


    Console.WriteLine("Second word");
    string secondWord = Console.ReadLine();

    if (Anagram(firstWord, secondWord))
      Console.WriteLine($"Yes, it's an anagram ({firstWord} and {secondWord})");
    else
      Console.WriteLine("No");

  }

  public bool Anagram(string wordOne, string wordTwo)
  {
    char[] charsFirstWord = wordOne.ToLower().ToArray();
    char[] charsSecondWord = wordTwo.ToLower().ToArray();

    Array.Sort(charsFirstWord);
    Array.Sort(charsSecondWord);

    string newWordOne = new(charsFirstWord);
    string newWordSecond = new(charsSecondWord);

    return newWordOne == newWordSecond;
  }
}
