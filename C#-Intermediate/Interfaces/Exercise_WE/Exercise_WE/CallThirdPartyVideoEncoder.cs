using System;

namespace Exercise_WE
{
    public class CallThirdPartyVideoEncoder : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Calling third-party web service video encoder");
        }
    }
}
