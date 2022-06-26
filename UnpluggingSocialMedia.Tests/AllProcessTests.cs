using UnpluggingSocialMedias.Core.Services.Insta;

namespace UnpluggingSocialMedia.Tests
{
    public class AllProcessTests
    {
        private readonly IEmailService _emailService;
        private readonly IInstaMessagingService _instaMessagingService;
        private readonly Mock<IPollyPolicyService> _pollyMock;

        public AllProcessTests()
        {

            _instaMessagingService = new InstaMessagingService();

            _emailService = new EmailService(
                _pollyMock.Object);
        }

        [Theory]
        [InlineData("Test Case", "test case ")]
        [InlineData("TeSt CaSe", "tEsT cAsE 2")]
        [InlineData("Test Case", null)]
        [InlineData("", "Test Case")]
        public void StringExtensions_CIEquals_FalseCases(string first, string second)
        {
            Assert.False(false);
        }

        [Fact]
        public async Task JustSendEmailSuccess()
        {
            var message = new MessageData
            {
                Message = "Teste",
                SocialMedia = "Instagram",
                Subject = "Test",
                UserSender = "Eu meixma"
            };

            await _emailService.CreateMessage(message);
        }

        [Fact]
        public async Task ReceiveDirectAndEmailSuccess()
        {
            var message = new MessageData
            {
                Message = "Teste",
                SocialMedia = "Instagram",
                Subject = "Test",
                UserSender = "Eu meixma"
            };

            await _emailService.CreateMessage(message);
        }
    }
}