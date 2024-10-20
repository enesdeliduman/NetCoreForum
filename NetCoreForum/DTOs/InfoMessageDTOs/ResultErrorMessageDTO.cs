using System.ComponentModel.DataAnnotations;

namespace NetCoreForum.DTOs.InfoMessagesDTOs
{
    public class ResultInfoMessageDTO
    {
        [Key]
        public int InfoMessageID { get; set; }
        public string InfoMessageName { get; set; }
        public string InfoMessageDescription { get; set; }
    }
}
