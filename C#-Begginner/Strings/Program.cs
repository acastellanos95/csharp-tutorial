using System;
using System.Text;

namespace Strings
{
    class Program
    {
        private const int Length = 25;

        static void Main(string[] args)
        {
            // Formatting Strings
            string name = "Andre Fabian castellanos aldama";
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.Trim());
            Console.WriteLine("Index of 'a': " + name.IndexOf('a'));
            Console.WriteLine("Last index of 'bian': " + name.LastIndexOf("bian"));

            // Substrings

            Console.WriteLine(name.Substring(8,6));

            // Replacing

            Console.WriteLine(name.Replace("castellanos", "Castellanos"));

            // Convert Strings to numbers

            Console.WriteLine(Convert.ToInt32("8500") is int);

            // Convert numbers to string 

            Console.WriteLine(1254.ToString() is String);

            // Summarizing text
            const int maxLength = 25;
            var longString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam sapien magna, pharetra sed tristique mattis, congue id tellus. Quisque vitae pellentesque sapien, ut aliquam enim. Pellentesque tortor nisi, efficitur at eros et, pellentesque sollicitudin nibh. Donec a odio molestie, dapibus sem consectetur, congue quam. Ut neque nunc, ultrices lacinia auctor vitae, ultricies sit amet magna. Sed hendrerit aliquet mauris. Nunc laoreet, arcu sit amet pharetra interdum, libero odio eleifend dui, ac condimentum urna dolor eu velit. Donec auctor, metus in blandit pulvinar, mauris urna euismod urna, sed gravida ex elit semper erat. Proin finibus mollis sem, vitae tincidunt massa scelerisque a. Aenean blandit sollicitudin diam.";
            
            if (longString.Length < maxLength)
            {
                Console.WriteLine(longString);
            }
            else
            {
                Console.WriteLine("Summarized content: " + longString.Substring(0, maxLength) + "...");
            }

            // StringBuilder

            var builder = new StringBuilder();

            builder
                .Append('-', 10)
                .AppendLine();
            builder
                .Append("Header")
                .AppendLine();
            builder
                .Append('-', 10)
                .AppendLine();

            Console.WriteLine(builder);

        }
    }
}
