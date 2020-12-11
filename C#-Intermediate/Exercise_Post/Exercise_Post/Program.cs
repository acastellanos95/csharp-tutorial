using System;

namespace Exercise_Post
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the title");
            var title = Console.ReadLine();
            Console.WriteLine("Write the description");
            var description = Console.ReadLine();
            Post newPost = new Post() { Title = title, Description=description};
            string input;
            while(true)
            {
                input = Console.ReadLine();
                switch(input.ToLower())
                {
                    case "upvote":
                        newPost.UpVote();
                        break;
                    case "downvote":
                        newPost.DownVote();
                        break;
                    default:
                        break;
                }
                Console.WriteLine(string.Format("Title: {0}", newPost.Title));
                Console.WriteLine(string.Format("Description: {0}", newPost.Description));
                Console.WriteLine(string.Format("Time: {0}", newPost.creationDateTime.ToString()));
                Console.WriteLine(string.Format("Votes: {0}", newPost.Votes));
            }
        }
    }
}
