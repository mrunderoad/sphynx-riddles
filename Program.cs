using System;
using System.Collections.Generic;

public class Program
{
  public static void Main()
  {
    List<string> riddle = new List<string> {{"When is a door not a door?"}, {"A girl fell off a 20-foot ladder. She wasn't hurt. How?"}, {"What is black and white and red all over?"}, {"What is at the end of the rainbow?"}};
    List<string> answers = new List<string> {{"ajar"}, {"bottom"}, {"newspaper"}, {"w"}};

    int rid = riddle.Count;
    while (riddle.Count > 0)
    {
      Random rand = new Random();
      int num = rand.Next(riddle.Count);

      Console.WriteLine(riddle[num]);
      string answer = Console.ReadLine();
      if (answer.Contains(answers[num]))
      {
        Console.WriteLine("Answer is correct!");
        riddle.Remove(riddle[num]);
        answers.Remove(answers[num]);
        rid--;
      }
      else
      {
        Console.WriteLine("Answer is WRONG!");
        break;
      }
      if (rid == 0)
      {
        Console.WriteLine("winner winner chicken dinner");
      }
    }
  }
}
