using System.ComponentModel.DataAnnotations;

namespace NetCoreForum.Entites
{
    public class Report
    {
        public int ReportID { get; set; }
        public string ReportReason { get; set; } // Şikayet Sebebi
        public string ReportedEntityType { get; set; }  // Şikayet edilen tür (örneğin: "User", "Topic", "Reply")
        public int ReportedEntityId { get; set; }  // Şikayet edilen varlığın ID'si (örneğin: UserId, TopicId, ReplyId)
        public string ReportAdditionalDetails { get; set; }  // Şikayete dair ekstra açıklamalar
        public bool ReportIsReviewed { get; set; } = false;  // Şikayetin admin tarafından incelenip incelenmediği
        public DateTime ReportCreatedAt { get; set; } = DateTime.Now; // Şikayet Tarihi
        
        public string AppUserID { get; set; }  // Şikayeti yapan kullanıcının ID'si
        public AppUser AppUser { get; set; }  // Şikayeti yapan kullanıcı
    }
}
