using SBShared.Const;

namespace SBShared.DTOs
{
    public class AddPersonMessageDTO : IMessageDTO
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}