namespace Interface.EmailService;

class EmailService : IEmailService
{
    public EmailService() {}

    public void SendEmail()
    {
        Console.WriteLine("Sending an e-mail");
    }
}
