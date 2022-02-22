using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Models;

namespace TweetAt
{
    public class Tweety
    {
        public async Task tweetConnectionAsync(string tweetString)
        {
            string APIKey = "-";
            string APISecret = "-";
            string APIToken = "-";
            string APITokenSecret = "-";


            var userClient = new TwitterClient(APIKey, APISecret, APIToken, APITokenSecret);
            var user = await userClient.Users.GetAuthenticatedUserAsync();
            Console.WriteLine(user);
            var tweet = await userClient.Tweets.PublishTweetAsync("ssss");
            Console.WriteLine("You published the tweet : ");
        }
    }
}
