﻿using System;
using Back_End_Final_Education.Helpers;
using Back_End_Final_Education.Services.Interfaces;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using MimeKit.Text;

namespace Back_End_Final_Education.Services
{
	public class EmailService:IEmailService
	{
        private readonly EmailSettings _emailSettings; 

        public EmailService(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }

        public void Send(string to, string subject, string html, string from = null)
        {
            // create message
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(from ?? _emailSettings.FromAddress));
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Html) { Text = html };

            // send email
            using var smtp = new SmtpClient();
            smtp.Connect(_emailSettings.Server, _emailSettings.Port, SecureSocketOptions.StartTls);
            smtp.Authenticate(_emailSettings.UserName, _emailSettings.Password);
            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }
}

