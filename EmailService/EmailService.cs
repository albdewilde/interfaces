namespace Interface.EmailService;

class EmailService : IEmailService
{
    public void SendEmail()
    {
        Console.WriteLine("Sending an e-mail");
    }
}
