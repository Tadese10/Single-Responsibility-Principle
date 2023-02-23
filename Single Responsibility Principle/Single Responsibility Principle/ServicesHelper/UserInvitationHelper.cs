﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle.ServicesHelper
{
  public sealed class UserInvitationHelper: Validator
    {
        private UserInvitationHelper(){}

        private static UserInvitationHelper instance = null;

        public static UserInvitationHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserInvitationHelper();
                }

                return instance;
            }
        }

      public void SendNotification(string email, string firstName, string lastName)
      {
          ValidateUserName(firstName, lastName);
          ValidateEmail(email);

          SmtpClient _client = new SmtpClient("", 80);
          _client.Send(new MailMessage("test@gmail.com", email)
          {
              Subject = "Testing SOLID Principle"
          });
      }

      
  }
}
