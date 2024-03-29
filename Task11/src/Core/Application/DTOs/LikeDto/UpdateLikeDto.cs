using Application.DTOs.Common;

namespace Application.DTOs.LikeDto
{
    public class UpdateLikeDto : BaseDto
    {
        public bool? isLiked {get; set;} = false;
    }
}


