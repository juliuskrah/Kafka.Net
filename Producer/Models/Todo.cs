namespace Producer.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public string ItemDescription { get; set; }
        public bool IsComplete { get; set; }
    }
}