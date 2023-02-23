using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle.ServicesHelper
{
  public  class EmailService
    {
        public void ValidateEmail(string email)
        {
            if (!email.Contains("@") || !email.Contains("."))
            {
                throw new Exception($"EMail '{email}' is not valid!");
            }
        }
    }
}
