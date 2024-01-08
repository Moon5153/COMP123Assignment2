using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP123Assignment2;

namespace TestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestToString()
        {
            //given
            string from = "Treudeau";
            string to = "Obama";
            string body = "Toronto is the greatest city!";
            string tag = "LoveToronto";
            string id = "100";
            Tweet tweet = new Tweet(from, to, body, tag, id);

            //when
            string result = tweet.ToString();

            //then
            Assert.AreEqual("ID: 100  From: Treudeau  To: Obama  Body: Toronto is the greatest city!  Tag: #LoveToronto\n", result);
        }

        [TestMethod]
        public void TestParseMethod()
        {
            //given
            string line = "Raptors\tTory\tObama\tToronto will win!\t1001";


            //when
            Tweet tweet = Tweet.Parse(line);

            //then
            Assert.AreEqual("1001", tweet.Id);
            Assert.AreEqual("Tory", tweet.From);
            Assert.AreEqual("Obama", tweet.To);
            Assert.AreEqual("Toronto will win!", tweet.Body);
            Assert.AreEqual("Raptors", tweet.Tag);
        }
    }
}
