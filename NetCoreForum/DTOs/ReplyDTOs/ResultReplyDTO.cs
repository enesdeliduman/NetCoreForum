namespace NetCoreForum.Entites
{
    public class ResultReplyDTO
    {
        public int ReplyID { get; set; }
        public string ReplyContent { get; set; }
        public int ReplyLikeCount { get; set; }
        public ReplyOwnerAppUserDTO AppUser { get; set; }
    }
}
