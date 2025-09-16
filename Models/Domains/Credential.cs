using System.ComponentModel.DataAnnotations;

namespace CredentialsAPI.Models.Domains
{
    public class Credential
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        [StringLength(20)]
        public string? Profile { get; set; }

        [StringLength(30)]
        public string? Subject_ID { get; set; }

        [StringLength(30)]
        public string? Nickname { get; set; }

        [StringLength(20)]
        public string? Operativity { get; set; }

        [StringLength(50)]
        public string? Area { get; set; }

        [StringLength(50)]
        public string? Section { get; set; }

        [Required]
        [StringLength(50)]
        public string? Username { get; set; }        

        [Required]
        [StringLength(50)]
        public string? Password { get; set; }

        [StringLength(50)]
        public string? User_Admin { get; set; }

        [StringLength(50)]
        public string? Password_First { get; set; }

        [StringLength(50)]
        public string? Password_Admin { get; set; }

        [StringLength(50)]
        public string? Password_3D_Secure { get; set; }

        [StringLength(50)]
        public string? Password_Dispositiva { get; set; }

        [StringLength(255)]
        public string? Password_History { get; set; }

        [StringLength(70)]
        [EmailAddress]
        public string? Email { get; set; }

        [StringLength(500)]
        [Url]
        public string? Url { get; set; }

        [StringLength(30)]
        public string? SmartPhone_Model { get; set; }

        [StringLength(30)]
        public string? SmartPhone_Serial { get; set; }

        [StringLength(30)]
        public string? SmartPhone_IMEI { get; set; }

        [StringLength(30)]
        public string? SmartPhone_Supplier { get; set; }

        [StringLength(30)]
        public string? Sim_Serial { get; set; }

        [StringLength(30)]
        public string? Sim_Operator { get; set; }

        [StringLength(30)]
        public string? Iban { get; set; }

        [StringLength(16)]
        public string? Numero_Carta { get; set; }

        [StringLength(10)]
        public string? Pin_App { get; set; }

        [StringLength(5)]
        public string? Pin_Carta { get; set; }

        [StringLength(10)]
        public string? Pin { get; set; }

        [StringLength(10)]
        public string? Puk { get; set; }

        [StringLength(10)]
        public string? Codice_Dispositivo { get; set; }

        [StringLength(10)]
        public string? Codice_Sicurezza { get; set; }

        [StringLength(10)]
        public string? Frase_Identificativa { get; set; }

        [StringLength(50)]
        public string? Machine_IP { get; set; }

        [StringLength(50)]
        public string? Machine_Name { get; set; }

        [StringLength(50)]
        public string? Machine_Type { get; set; }

        [StringLength(30)]
        public string? Numero_Cliente { get; set; }

        [StringLength(255)]
        public string? Note { get; set; }

        [StringLength(5)]
        public string? Data_Scadenza { get; set; }

        public DateTime? Expired_Date { get; set; }

        public bool Expired { get; set; } = false;
        public bool Active { get; set; } = true;
        public DateTime Modified { get; set; } = DateTime.UtcNow;
        public DateTime Created { get; set; } = DateTime.UtcNow;
    }
}
