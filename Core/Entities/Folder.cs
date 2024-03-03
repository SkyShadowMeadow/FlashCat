namespace Core.Entities
{
    public class Folder
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int? UserId { get; set; }
        public ICollection<Set>? Sets { get; set; }
    }
}