namespace ResumeBuilder.Core.Entities;

public class Resume
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Summary { get; set; }
    public Guid UserId { get; set; }
    public Guid TemplateId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    // Display settings for contact information
    public bool DisplayEmail { get; set; } = true;
    public bool DisplayPhone { get; set; } = true;
    public bool DisplayName { get; set; } = true;
    
    // Navigation properties
    public User User { get; set; } = null!;
    public Template Template { get; set; } = null!;
    public ICollection<Education> Education { get; set; } = new List<Education>();
    public ICollection<Experience> Experience { get; set; } = new List<Experience>();
    public ICollection<Skill> Skills { get; set; } = new List<Skill>();
    public ICollection<Project> Projects { get; set; } = new List<Project>();
    public ICollection<Certification> Certifications { get; set; } = new List<Certification>();
    public ICollection<CustomSection> CustomSections { get; set; } = new List<CustomSection>();
}