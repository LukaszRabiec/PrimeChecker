using System;

namespace DelegatesAndEvents
{
    public class MailSender
    {
        // In this class you can implement sending notifications for e-mail.
        public void OnPrimeCheckedProgressUpdated(object sender, ProgressEventArgs e)
        {
            Console.WriteLine("Progress: {0}%", e.Progress);
        }

        public void OnPrimeChecked(object sender, EventArgs e)
        {
            Console.WriteLine("Checking completed.");
        }
    }
}
