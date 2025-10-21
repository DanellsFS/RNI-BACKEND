using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace UninunezRNIBackend.Models.DTO
{
    public class CreateAgreementDto
    {
        [Required]
        [JsonPropertyName("organizacionAliadaId")]
        public int PartnerOrganizationId { get; set; }

        [Required]
        [JsonPropertyName("paisDesarrolloId")]
        public int CountryId { get; set; }

        [Required]
        [JsonPropertyName("ciudadDesarrollo")]
        public string City { get; set; } = string.Empty;

        [Required]
        [JsonPropertyName("programasHomologos")]
        public string HomologousPrograms { get; set; } = string.Empty;

        [Required]
        [JsonPropertyName("areaConocimiento")]
        public string KnowledgeArea { get; set; } = string.Empty;

        [Required]
        [JsonPropertyName("fechaInicio")]
        public DateTime StartDate { get; set; }

        [Required]
        [JsonPropertyName("fechaFin")]
        public DateTime EndDate { get; set; }

        [JsonPropertyName("fechaFirma")]
        public DateTime? SigningDate { get; set; }

        [JsonPropertyName("renovacionAutomatica")]
        public bool AutomaticRenewal { get; set; }

        [Required]
        [Url]
        [JsonPropertyName("enlaceInstitucion")]
        public string OrganizationLink { get; set; } = string.Empty;

        [Required]
        [JsonPropertyName("descripcion")]
        public string Description { get; set; } = string.Empty;

        [JsonPropertyName("observaciones")]
        public string? Notes { get; set; }

        [Required]
        [JsonPropertyName("ambito")]
        public string Scope { get; set; } = string.Empty;

        [Required]
        [JsonPropertyName("claseJuridica")]
        public string LegalClass { get; set; } = string.Empty;

        [JsonPropertyName("contactos")]
        public List<object>? Contacts { get; set; }

        [JsonPropertyName("documentos")]
        public List<string>? Documents { get; set; }
    }
}
