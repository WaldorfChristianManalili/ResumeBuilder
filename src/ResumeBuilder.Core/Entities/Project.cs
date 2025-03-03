namespace ResumeBuilder.Core.Entities;

public class Project
{
    public Guid Id { get; set; }
    public Guid ResumeId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? ProjectUrl { get; set; }
    public string? GitHubUrl { get; set; }
    public int DisplayOrder { get; set; }
    
    // Navigation property
    public Resume Resume { get; set; } = null!;
}