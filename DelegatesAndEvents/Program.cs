using System;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeChecker primeChecker = new PrimeChecker();
            MailSender mailSender = new MailSender();
            MessagingSystem messagingSystem = new MessagingSystem();
            bool isPrime;
            int userNumber = 419;

            primeChecker.PrimeCheckingStarted += messagingSystem.OnPrimeCheckingStarted;
            primeChecker.PrimeCheckedProgressUpdated += mailSender.OnPrimeCheckedProgressUpdated;
            primeChecker.PrimeCheckedFinished += mailSender.OnPrimeChecked;

            isPrime = primeChecker.IsPrime(userNumber);

            if (!isPrime)
            {
                Console.WriteLine("The number: {0} isn't prime number. :(", userNumber);
            }
            else
            {
                Console.WriteLine("The number: {0} is prime number. :)", userNumber);
            }

            Console.ReadKey();
        }
    }
}
