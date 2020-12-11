using System;

namespace Exercise_Post
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public readonly DateTime creationDateTime = DateTime.Now;
        public int Votes { get; private set; }

        public Post()
        {
            this.Votes = 0;
        }

        public void UpVote()
        {
            this.Votes++;
        }

        public void DownVote()
        {
            this.Votes--;
        }

    }
}
