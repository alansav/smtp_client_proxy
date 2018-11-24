using System.Net.Mail;
using Xunit;

namespace Savage.SmtpClientProxy
{
    public class SmtpClientProxyTests
    {
        [Fact]
        public void Constructor_initializes_Properties()
        {
            var smtpClient = new SmtpClient();
            var sut = new SmtpClientProxy(smtpClient);

            Assert.Same(smtpClient, sut.SmtpClient);
        }
    }
}
