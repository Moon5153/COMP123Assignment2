using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123Assignment2
{
    public class Tweet
    {
        private static int CURRENT_ID;

        public string From { get; }
        public string To { get; }
        public string Body { get; }
        public string Tag { get; }
        public string Id { get; }

        public Tweet(string from,string to,string body,string tag)
        {
            From = from;
            To = to;
            Body = body;
            Tag = tag;
            Id = Convert.ToString(CURRENT_ID);
            CURRENT_ID++;
        }
        public Tweet(string from, string to, string body, string tag,string id)
        {
            From = from;
            To = to;
            Body = body;
            Tag = tag;
            Id = id;
        }
        public override string ToString()
        {
            string body="";
            if(Body.Length>40)
            {
                body = Body.Substring(0, 40);
            }
            else
            {
                body = Body;
            }

            return $"ID: {Id}  From: {From}  To: {To}  Body: {body}  Tag: #{Tag}\n";
        }
        public static Tweet Parse(string line)
        {
            string[] values = line.Split(new char[] { '\t' });

            string tagValue = values[0];
            string fromValue = values[1];
            string toValue = values[2];
            string bodyValue = values[3];
            string idValue = values[4];

            return new Tweet(fromValue,toValue,bodyValue,tagValue,idValue);
        }

    }
}
