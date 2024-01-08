using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace COMP123Assignment2
{
    static class TweetManager
    {
        static List<Tweet> TWEETS;
        static string FILENAME = "Assignment_02_TweetFile (1).txt";
        static TweetManager()
        {
            TWEETS = new List<Tweet>();

        }
        public static void ReadFromFile()
        {
           
            TextReader reader = new StreamReader(FILENAME);
            string line = reader.ReadLine();
            while (line != null)
            {
                Tweet result = Tweet.Parse(line);
                TWEETS.Add(result);
                Console.WriteLine(result);
                line = reader.ReadLine();
            }
            reader.Close();
        }
     
        public static void Initialize()
        {
            TWEETS = new List<Tweet>();
            Tweet tweet1 = new Tweet("Moon", "Max", "I Love Canada", "Canada", "100");
            Tweet tweet2 = new Tweet("Tory", "Drake", "Toronto Will get them!", "LoveToronto", "101");
            Tweet tweet3 = new Tweet("Jays", "Drake", "Go Jays!!", "GoJays", "102");
            Tweet tweet4 = new Tweet("Tory", "Obama", "Toronto is the greatest city!", "LoveToronto", "103");
            Tweet tweet5 = new Tweet("Tredeau", "Obama", "Toronto Will get them!", "WinGame", "104");
            TWEETS.Add(tweet1);
            TWEETS.Add(tweet2);
            TWEETS.Add(tweet3);
            TWEETS.Add(tweet4);
            TWEETS.Add(tweet5);
        }
        public static void ShowAll()
        {
            
            foreach(Tweet t in TWEETS)
            {
                Console.WriteLine(t);
                
            }
        }
        public static void ShowAll(string tag)
        {
            Console.WriteLine("\nTweets that match the tag #"+tag+" are:\n");
            foreach (Tweet t in TWEETS)
            {
                
                if(t.Tag.ToLower()==tag.ToLower())
                {
                    Console.WriteLine(t);
                }

            }
        }
    }
}
