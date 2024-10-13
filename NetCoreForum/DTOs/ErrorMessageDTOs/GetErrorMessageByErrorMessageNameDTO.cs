using System.ComponentModel.DataAnnotations;

namespace NetCoreForum.DTOs.ErrorMessagesDTOs
{
    public class GetErrorMessageByErrorMessageNameDTO
    {
        public int ErrorMessageID { get; set; }
        public string ErrorMessageName { get; set; }
        public string ErrorMessageDescription { get; set; }
    }
}
