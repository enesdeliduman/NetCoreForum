using NetCoreForum.DTOs.TopicDTOs;

namespace NetCoreForum.Repositories.Abstract
{
    public interface ITopicRepository
    {
        Task<List<Last10TopicForHomePageDTO>> Last10TopicForHomePage();
        Task<GetTopicDTO> GetTopicByTopicID(int id);
    }
}
