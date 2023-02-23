using System;
using Single_Responsibility_Principle.ServicesHelper;

namespace Single_Responsibility_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get User details
            Console.WriteLine("Please enter Email");
            string email = Console.ReadLine();
            Console.WriteLine("Please enter FirstName");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter LastName");
            string lastName = Console.ReadLine();

            var emailService = new EmailService();
            var userNameService = new UserNameService();
            var userInvitationHelper = new UserInvitationHelper(userNameService, emailService);

            userInvitationHelper.SendNotification(email, firstName, lastName);
        }
    }
}
