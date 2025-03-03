namespace ResumeBuilder.Core.Entities;

public class Template
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string PreviewImageUrl { get; set; } = string.Empty;
    public string TemplateData { get; set; } = string.Empty; // JSON/HTML template structure
    public bool IsEmpty { get; set; }
    public DateTime CreatedAt { get; set; }
    
    // Navigation properties
    public ICollection<Resume> Resumes { get; set; } = new List<Resume>();
}