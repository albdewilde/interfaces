using Interface.EmailService;

namespace Interface.App;

class App
{
    private IEmailService es;

    public App(IEmailService emailService)
    {
        es = emailService;
    }

    public void DoStuff()
    {
        es.SendEmail();
        Console.WriteLine("E-mail sent");
    }
}
