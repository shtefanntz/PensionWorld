namespace PensionWorld.Services.Infrastructure
{
    using PensionWorld.Domain.MasterData;

    public interface IMailSender
    {
        void Send(string subject, string to, string body);

        void Send(Contact contact, string body, string subject);
    }
}