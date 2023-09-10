using SBReceiver.Messages;
using SBShared.DTOs;

namespace SBReveiver.Test.MessagesTest
{
    [TestFixture]
    public class AddPersonMessageTest
    {
        [Test]
        public void Invoke_PassNullObject_PrintNullMessage()
        {
            // Arrange
            AddPersonMessage sut = new AddPersonMessage();
            AddPersonMessageDTO dto = new AddPersonMessageDTO();
            // Act
            sut.Invoke(dto);
            // Assert
        }
    }
}
