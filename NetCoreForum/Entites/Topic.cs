namespace NetCoreForum.Entites
{
    public class Topic
    {
        public int TopicID { get; set; }
        public string TopicTitle { get; set; }
        public string TopicContent { get; set; }
        public int TopicLikeCount { get; set; }
        public int TopicViewCount { get; set; }

       public ICollection<Reply> Replies { get; set; }
        public AppUser AppUser { get; set; }
        public string AppUserID { get; set; }
        public Category Category { get; set; }
        public int CategoryID { get; set; }
        public TopicType TopicType { get; set; }
        public int TopicTypeID { get; set; }
    }
}
