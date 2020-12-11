using System;

class Program
{
  static void Main()
  {
    Console.WriteLine("What is your allergy score?");
    int score = int.Parse(Console.ReadLine());
    string[] arrayName = {"", "", "", "", "", "", "", ""};

    if (score >= 128)
    {
      score -= 128;
      arrayName[7] = "cats";
    } 
    if (score >= 64)
    {
      score -= 64;
      arrayName[6] = "pollen";
    }
    if (score >= 32)
    {
      score -= 32; 
      arrayName[5] = "chocolate";
    }
    if (score >= 16)
    {
      score -= 16;
      arrayName[4] = "tomatoes";
    }
    if (score >= 8)
    {
      score -= 8;
      arrayName[3] = "strawberries";
    }
    if (score >= 4)
    {
      score -= 4;
      arrayName[2] = "shellfish";
    }
    if (score >= 2)
    {
      score -= 2;
      arrayName[1] = "peanuts";
    }
    if (score >= 1)
    {
      score -= 1;
      arrayName[0] = "eggs";
    }       
    Console.WriteLine("You are allergic to: ");
    foreach (string allergy in arrayName)
    {
      if (allergy != "") 
      {
        Console.WriteLine(allergy);
      }
    }
  }
}