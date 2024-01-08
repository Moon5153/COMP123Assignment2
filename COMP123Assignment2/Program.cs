using System;

namespace COMP123Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read from Initialize method
            Console.WriteLine("\nDisplaying Tweets from the Initialize method:\n");
            TweetManager.Initialize();
            TweetManager.ShowAll();
            

            //Read From File
            Console.WriteLine("\nDisplaying Tweets from the given file:\n");
            TweetManager.ReadFromFile();
            TweetManager.ShowAll("raptors");
            TweetManager.ShowAll("leaf");



        }
    }
}
