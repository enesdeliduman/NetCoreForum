using System.ComponentModel.DataAnnotations;

namespace NetCoreForum.DTOs.EmailTemplateDTOs
{
    public class GetEmailTemplateByTemplateNameDTO
    {
        public int EmailTemplateID { get; set; }
        public string ViewedTemplateName { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
