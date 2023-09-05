using SBShared.Const;

namespace SBShared.DTOs
{
    public class DeletePersonMessageDTO : IMessageDTO
    {
        public int PersonId { get; set; }
    }
}