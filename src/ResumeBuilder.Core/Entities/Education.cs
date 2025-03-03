namespace ResumeBuilder.Core.Entities;

public class Education
{
    public Guid Id { get; set; }
    public Guid ResumeId { get; set; }
    public string Institution { get; set; } = string.Empty;
    public string Degree { get; set; } = string.Empty;
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? Description { get; set; }
    public int DisplayOrder { get; set; }
    
    // Navigation property
    public Resume Resume { get; set; } = null!;
}