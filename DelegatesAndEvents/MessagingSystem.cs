using System;

namespace DelegatesAndEvents
{
    public class MessagingSystem
    {
        public void OnPrimeCheckingStarted(object sender, EventArgs e)
        {
            Console.WriteLine("Checking whether a number is prime...");
        }
    }
}
