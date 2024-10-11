using System.Diagnostics;

namespace NetCoreForum.Entites
{
    public class TopicType
    {
        public int TopicTypeID { get; set; }
        public string TopicTypeName { get; set; }
        public ICollection<Topic> Topics { get; set; }
    }
}
