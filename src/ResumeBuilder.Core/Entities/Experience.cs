namespace ResumeBuilder.Core.Entities;

public class Experience
{
    public Guid Id { get; set; }
    public Guid ResumeId { get; set; }
    public string Company { get; set; } = string.Empty;
    public string Position { get; set; } = string.Empty;
    public string? Location { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? Description { get; set; }
    public int DisplayOrder { get; set; }
    
    // Navigation property
    public Resume Resume { get; set; } = null!;
}