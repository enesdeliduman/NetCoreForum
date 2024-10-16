using NetCoreForum.Entites;

namespace NetCoreForum.DTOs.TopicDTOs
{
    public class Last10TopicForHomePageDTO
    {
        public int TopicID { get; set; }
        public string TopicTitle { get; set; }
        public int TopicLikeCount { get; set; }
        public int TopicViewCount { get; set; }
        public string AppUser { get; set; }
        public string CategoryTitle { get; set; }
    }
}
