public class Agreement
{
    public int Id { get; set; }
    public int PartnerOrganizationId { get; set; }
    public int CountryId { get; set; }
    public string City { get; set; }
    public string HomologousPrograms { get; set; }
    public string KnowledgeArea { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime? SigningDate { get; set; }
    public bool IsActive { get; set; }
    public bool AutomaticRenewal { get; set; }
    public string Status { get; set; }
    public string OrganizationLink { get; set; }
    public string Description { get; set; }
    public string Notes { get; set; }
    public string Scope { get; set; } // National or International
    public string LegalClass { get; set; } // Framework or Specific
    public List<Contact> Contacts { get; set; } = new();
    public List<Document> Documents { get; set; } = new();
    public List<Tag> Tags { get; set; } = new();
    public List<CooperationLine> CooperationLines { get; set; } = new();
    public List<Renewal> Renewals { get; set; } = new();
}
