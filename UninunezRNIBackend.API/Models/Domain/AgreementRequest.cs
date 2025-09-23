using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using UninunezRNIBackend.Models.Enums;

namespace UninunezRNIBackend.Models.Domain
{
    public class AgreementRequest
    {
        [Key]
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [Required]
        [JsonPropertyName("proposerName")]
        public string ProposerName { get; set; } = string.Empty;

        [Required]
        [JsonPropertyName("proposerEmail")]
        public string ProposerEmail { get; set; } = string.Empty;

        [Required]
        [JsonPropertyName("proposerRole")]
        public ProposerRole Role { get; set; } = ProposerRole.Director;

        [JsonPropertyName("proposerPhone")]
        public string? ProposerPhone { get; set; }

        [Required]
        [JsonPropertyName("proposerPosition")]
        public ProposerPosition Position { get; set; } = ProposerPosition.Director;

        [Required]
        [JsonPropertyName("requestType")]
        public  RequestType Type { get; set; } = RequestType.FirmaInvestigacion;

        [Required]
        [JsonPropertyName("proposedOrgnization")]
        public string ProposedOrgnization { get; set; } = string.Empty;

        [Required]
        [JsonPropertyName("requiresMembershipPayment")]
        public bool RequiresMembershipPayment { get; set; } = false;

        [JsonPropertyName("membershipPaymentAmount")]
        public double? MembershipPaymentAmount { get; set; }

        [JsonPropertyName("requestDate")]
        public DateTime RequestDate { get; set; } = DateTime.Today;

        [Required]
        [JsonPropertyName("status")]
        public RequestStatus Status { get; set; } = RequestStatus.Pending;
       

        [Required]
        [JsonPropertyName("observations")]
        public string Observations { get; set; } = string.Empty;

        [Required]
        [JsonPropertyName("contactName")]
        public string ContactName { get; set; } = string.Empty;

        [Required]
        [JsonPropertyName("contactPosition")]
        public string ContactPosition { get; set; } = string.Empty;

        [Required]
        [JsonPropertyName("contactEmail")]
        public string ContactEmail { get; set; } = string.Empty;

        [Required]
        [JsonPropertyName("contactPhone")]
        public int ContactPhone { get; set; } // o string para que acepte los caracteres + y () de otros países.

        [Required]
        [JsonPropertyName("AttachedDocumentsPath")]
        public List<string> AttachedDocumentsPath { get; set; } = new List<string>();

    }
}
