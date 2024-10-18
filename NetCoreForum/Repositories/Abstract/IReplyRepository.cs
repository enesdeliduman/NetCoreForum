using NetCoreForum.DTOs.ReplyDTOs;

namespace NetCoreForum.Repositories.Abstract
{
    public interface IReplyRepository
    {
        Task<CreateReplyDTO> CreateReply(CreateReplyDTO createReplyDTO);
    }
}
