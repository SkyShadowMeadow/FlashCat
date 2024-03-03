namespace Core.Entities
{
    public class Card
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Word { get; set; }
        public string Definition { get; set; }
        public int SetId { get; set; }
        public string ImageUrl { get; set; }
    }
}