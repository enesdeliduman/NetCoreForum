using System.ComponentModel.DataAnnotations;

namespace NetCoreForum.DTOs.InfoMessagesDTOs
{
    public class GetInfoMessageByInfoMessageNameDTO
    {
        public int InfoMessageID { get; set; }
        public string InfoMessageName { get; set; }
        public string InfoMessageDescription { get; set; }
    }
}
