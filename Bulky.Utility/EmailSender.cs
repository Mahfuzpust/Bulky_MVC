using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
<<<<<<< HEAD
using System.Reflection.Metadata.Ecma335;
=======
>>>>>>> master
using System.Text;
using System.Threading.Tasks;

namespace Bulky.Utility
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
<<<<<<< HEAD
            //logic to send Email
=======
            //logic to send email
>>>>>>> master
            return Task.CompletedTask;
        }
    }
}
