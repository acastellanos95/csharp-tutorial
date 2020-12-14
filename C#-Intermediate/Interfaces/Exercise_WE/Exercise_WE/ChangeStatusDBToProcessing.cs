using System;

namespace Exercise_WE
{
    public class ChangeStatusDBToProcessing : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Processing");
        }
    }
}
