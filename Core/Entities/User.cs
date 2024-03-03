namespace Core.Entities
{
    public class User
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public  string? PasswordHash { get; set; }
        public string? GoogleId { get; set; }
        public required string Email { get; set; }
    }
}