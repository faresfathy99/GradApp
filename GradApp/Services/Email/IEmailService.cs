using GradApp.Data.Models.Email;

namespace GradApp.Services.Email;

public interface IEmailService
{
    string SendEmail(Message message);
}
