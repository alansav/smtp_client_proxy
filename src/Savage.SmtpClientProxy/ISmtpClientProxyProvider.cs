namespace Savage.SmtpClientProxy
{
    public interface ISmtpClientProxyProvider
    {
        ISmtpClientProxy Get();
    }
}
