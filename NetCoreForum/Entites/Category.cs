namespace NetCoreForum.Entites
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryTitle { get; set; }
        public string CategoryDescription { get; set; }
        public ICollection<Topic> Topics { get; set; }
    }
}
