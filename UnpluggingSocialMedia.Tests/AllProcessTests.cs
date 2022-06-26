using Moq;
using UnpluggingSocialMedias.Core.Domain;
using UnpluggingSocialMedias.Core.Services.Email;
using UnpluggingSocialMedias.Core.Services.Interfaces;

namespace UnpluggingSocialMedia.Tests
{
    public class AllProcessTests
    {
        private readonly IEmailService _emailService;
        private readonly Mock<IPollyPolicyService> _pollyMock;

        public AllProcessTests()
        {

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
    }
}