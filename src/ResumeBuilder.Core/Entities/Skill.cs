namespace ResumeBuilder.Core.Entities;

public class Skill
{
    public Guid Id { get; set; }
    public Guid ResumeId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Category { get; set; }
    public int DisplayOrder { get; set; }
    
    // Navigation property
    public Resume Resume { get; set; } = null!;
}