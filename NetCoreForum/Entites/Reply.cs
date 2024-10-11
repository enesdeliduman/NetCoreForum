namespace NetCoreForum.Entites
{
    public class Reply
    {
        public int ReplyID { get; set; }
        public string ReplyContent { get; set; }
        public int ReplyLikeCount { get; set; }
        public int ReplyViewCount { get; set; }

        public AppUser AppUser { get; set; }
        public string AppUserID { get; set; }

        public Topic Topic { get; set; }
        public int TopicID { get; set; }
    }
}
