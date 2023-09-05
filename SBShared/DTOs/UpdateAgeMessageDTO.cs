using SBShared.Const;

namespace SBShared.DTOs
{
    public class UpdateAgeMessageDTO : IMessageDTO
    {
        public int PersonId { get; set; }
        public int NewAge { get; set; }
    }
}