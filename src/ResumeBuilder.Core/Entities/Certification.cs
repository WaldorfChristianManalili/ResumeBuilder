namespace ResumeBuilder.Core.Entities;

public class Certification
{
    public Guid Id { get; set; }
    public Guid ResumeId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? IssuingOrganization { get; set; }
    public DateTime? IssueDate { get; set; }
    public DateTime? ExpirationDate { get; set; }
    public string? CredentialId { get; set; }
    public string? CredentialUrl { get; set; }
    public int DisplayOrder { get; set; }
    
    // Navigation property
    public Resume Resume { get; set; } = null!;
}