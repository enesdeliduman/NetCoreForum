using NetCoreForum.Entites;

namespace NetCoreForum.DTOs.TopicDTOs
{
    public class GetTopicDTO
    {
        public int TopicID { get; set; }
        public string TopicTitle { get; set; }
        public string TopicContent { get; set; }
        public int TopicLikeCount { get; set; }
        public int TopicViewCount { get; set; }

        public ICollection<Reply> Replies { get; set; }
        public string AppUser { get; set; }
        public string CategoryTitle { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
    }
}
