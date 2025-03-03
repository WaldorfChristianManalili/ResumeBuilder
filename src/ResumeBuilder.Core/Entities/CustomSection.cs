namespace ResumeBuilder.Core.Entities;

public class CustomSection
{
    public Guid Id { get; set; }
    public Guid ResumeId { get; set; }
    public string Title { get; set; } = string.Empty;
    public int DisplayOrder { get; set; }
    
    // Navigation properties
    public Resume Resume { get; set; } = null!;
    public ICollection<CustomSectionItem> Items { get; set; } = new List<CustomSectionItem>();
}

public class CustomSectionItem
{
    public Guid Id { get; set; }
    public Guid CustomSectionId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? Subtitle { get; set; }
    public int DisplayOrder { get; set; }
    
    // Navigation property
    public CustomSection CustomSection { get; set; } = null!;
}