using SBShared.Const;

namespace SBShared.DTOs
{
    public class UpdateNameMessageDTO : IMessageDTO
    {
        public int PersonId { get; set; }
        public string NewName { get; set; }
    }
}