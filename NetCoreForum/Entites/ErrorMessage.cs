using System.ComponentModel.DataAnnotations;

namespace NetCoreForum.Entities
{
    public class InfoMessage
    {
        public int InfoMessageID { get; set; }
        public string InfoMessageName { get; set; }
        public string InfoMessageDescription { get; set; }
    }
}
