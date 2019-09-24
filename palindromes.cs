using System;
using System.Text.RegularExpressions;

class Program
{
  static void Main()
  {
    Console.WriteLine("Enter a phrase to check if it's a palindrom:");
    string phrase = Console.ReadLine();
    Palindrome palindrome = new Palindrome(phrase);
    if(palindrome.checkPalindrome()) {
      Console.WriteLine("Yeah that's a palindrome.");
    } else {
      Console.WriteLine("Nope that's not a palindrome.");
    }
  }

}

class Palindrome 
{
  public string Phrase {get; set;}
  
  public Palindrome(string phrase) 
  {
    Phrase = CleanString(phrase.ToLower());
  }

  private string CleanString(string dirtyString)
  {
    string Output = "";

    for(int i = 0; i < dirtyString.Length; i ++)
    {
      int unicode = dirtyString[i];
      if ((unicode > 47 && unicode <58) || (unicode > 96 && unicode < 123))
      {
        Output += dirtyString[i];
      }
    }
    return Output;
  }

  public bool checkPalindrome() 
  {
    bool isPalindrome = true;
    for(int i=0; i<Phrase.Length/2; i++)
    {
      if(Phrase[i] != Phrase[Phrase.Length-1-i]) 
      {
        isPalindrome = false;
        break;
      }
    }
    return isPalindrome;
  }

}

