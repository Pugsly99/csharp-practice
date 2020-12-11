using System;

class Program
{
  static void Main()
  {
    Console.WriteLine("What is your allergy score?");
    int score = int.Parse(Console.ReadLine());

    if (score >= 128)
    {
      score -= 128;
      Console.WriteLine("128!");
    } 
    if (score >= 64)
    {
      score -= 64;
      Console.WriteLine("64!");
    }
    if (score >= 32)
    {
      score -= 32; 
      Console.WriteLine("32!!!!");
    }
    if (score >= 16)
    {
      score -= 16;
      Console.WriteLine("it's 16!");
    }
    if (score >= 8)
    {
      score -= 8;
      Console.WriteLine("!8!");
    }
    if (score >= 4)
    {
      score -= 4;
      Console.WriteLine("4--4--4--4!");
    }
    if (score >= 2)
    {
      score -= 2;
      Console.WriteLine("2...");
    }
    if (score >= 1)
    {
      score -= 1;
      Console.WriteLine("1.");
    }
    Console.WriteLine("0?");
    Console.WriteLine(score);
    // console write "hey u got allergy score right. wanna know what it means. put ur number below :) "
    // int (variable name) = console read line
    // if (variable name) > 128, 
    // cat, variable name - 128, else move on
    //  etc
    // etc
  }
}