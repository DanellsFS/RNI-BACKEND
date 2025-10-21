using System.Text.Json.Serialization;

namespace UninunezRNIBackend.Models.DTO
{
    public class AgreementPublicDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("organizacionAliadaId")]
        public int PartnerOrganizationId { get; set; }

        [JsonPropertyName("organizacionNombre")]
        public string? PartnerOrganizationName { get; set; }

        [JsonPropertyName("paisDesarrolloId")]
        public int CountryId { get; set; }

        [JsonPropertyName("ciudadDesarrollo")]
        public string City { get; set; } = string.Empty;

        [JsonPropertyName("programasHomologos")]
        public string HomologousPrograms { get; set; } = string.Empty;

        [JsonPropertyName("areaConocimiento")]
        public string KnowledgeArea { get; set; } = string.Empty;

        [JsonPropertyName("fechaInicio")]
        public DateTime StartDate { get; set; }

        [JsonPropertyName("fechaFin")]
        public DateTime EndDate { get; set; }

        [JsonPropertyName("esVigente")]
        public bool IsActive { get; set; }

        [JsonPropertyName("enlaceInstitucion")]
        public string OrganizationLink { get; set; } = string.Empty;

        [JsonPropertyName("descripcion")]
        public string Description { get; set; } = string.Empty;
    }
}
