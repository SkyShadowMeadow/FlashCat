using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class Set
    {
    public int Id { get; set; }
    public required string Name { get; set; }
    public bool IsPublic { get; set; }
    public int? UserId { get; set; }
    public ICollection<Folder>? Folders { get; set; }
    public ICollection<Card>? Cards { get; set; }

    }
}