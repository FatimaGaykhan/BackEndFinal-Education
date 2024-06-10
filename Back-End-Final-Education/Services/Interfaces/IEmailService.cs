using System;
namespace Back_End_Final_Education.Services.Interfaces
{
	public interface IEmailService
	{
        void Send(string to, string subject, string html, string from = null);
    }
}

