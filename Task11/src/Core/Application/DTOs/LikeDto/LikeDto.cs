using Application.DTOs.Common;

namespace Application.DTOs.LikeDto
{
    public class LikeDto : BaseDto
    {
        public int BlogId { get; set; }
        public int UserId { get; set; }
    }
}


