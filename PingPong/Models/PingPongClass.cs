using System;
using System.Collections.Generic;

namespace PingPong
{
  public class PingPongClass
  {

    public string PingPongWorks(int testNumber)
    {    
        List<string> PingPongList = new List<string>() {};
        for(int index = 1; index <= testNumber; index++)
        {
            string indexString = index.ToString();
            if (index % 3 == 0)
            {
                PingPongList.Add("ping");
                Console.WriteLine(PingPongList[index-1]);
            }
            else if (index % 5 == 0)
            {
                PingPongList.Add("pong");
                Console.WriteLine(PingPongList[index-1]);
            }
            else
            {
            PingPongList.Add(indexString);
            Console.WriteLine(PingPongList[index-1]);
            }
        }
            return PingPongList[testNumber-1];
        }
    
  }
  public class Program
  {
      public static void Main ()
      {
          PingPongClass pingPongGame = new PingPongClass();
          Console.WriteLine("Please input a number:");
          string testNumberString = Console.ReadLine();
          int testNumber = int.Parse(testNumberString);
          pingPongGame.PingPongWorks(testNumber);
      }
  }
}