using System;
using System.Net.Mail;
using System.Threading;
using System.Threading.Tasks;

namespace Savage.SmtpClientProxy
{
    public interface ISmtpClientProxy
    {
        SmtpClient SmtpClient { get; }
        Task SendAsync(MailMessage mailMessage, CancellationToken cancellationToken);
    }

    public class SmtpClientProxy : ISmtpClientProxy, IDisposable
    {
        public SmtpClientProxy(SmtpClient smtpClient)
        {
            SmtpClient = smtpClient;
        }

        public SmtpClient SmtpClient { get; }

        public void Dispose()
        {
            SmtpClient.Dispose();
        }

        public async Task SendAsync(MailMessage mailMessage, CancellationToken cancellationToken)
        {
            await Task.Run(() => SmtpClient.Send(mailMessage), cancellationToken).ConfigureAwait(false);
        }
    }
}
