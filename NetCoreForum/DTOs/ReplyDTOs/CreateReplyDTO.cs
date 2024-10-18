using NetCoreForum.Entites;

namespace NetCoreForum.DTOs.ReplyDTOs
{
    public class CreateReplyDTO
    {
        public string ReplyContent { get; set; }
        public int TopicID { get; set; }
        public string AppUserID { get; set; }

    }
}
