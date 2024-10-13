using System.ComponentModel.DataAnnotations;

namespace NetCoreForum.Entities
{
    public class ErrorMessage
    {
        public int ErrorMessageID { get; set; }
        public string ErrorMessageName { get; set; }
        public string ErrorMessageDescription { get; set; }
    }
}
