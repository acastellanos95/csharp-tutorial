using System;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            // Files and FileInfo(is good when we want to use a lot of file handling because of security in files of the OS)
            string __directory = Directory.GetCurrentDirectory();
            string path = __directory + "/hello.txt";
            File.Copy(path, __directory + "/hello1.txt", true);
            if(File.Exists(__directory + "/hello1.txt")){
                File.Delete(__directory + "/hello1.txt");
            }

            string[] content = File.ReadAllLines(path);
            foreach (var word in content)
            {
                Console.WriteLine(word);
            }
            // Directory and DirectoryInfo
            string[] files = Directory.GetFiles("/home/andre/Downloads", "*.*");
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
            string[] directories = Directory.GetDirectories("/home/andre", "*.*");
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }
            // Path
            path = "/home/andre/Documents/";
            Console.WriteLine(Path.GetFullPath(path));
        }
    }
}
