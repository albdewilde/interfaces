using Interface.EmailService;
using Interface.App;

IEmailService es = new EmailService();
App app = new(es);

app.DoStuff();
