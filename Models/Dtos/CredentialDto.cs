namespace CredentialsAPI.Models.Dtos
{
    public class CredentialDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Profile { get; set; }
        public string? Subject_ID { get; set; }
        public string? Nickname { get; set; }
        public string? Area { get; set; }
        public string? Section { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Url { get; set; }
        public string? Operativity { get; set; }
        public string? User_Admin { get; set; }
        public string? Password_First { get; set; }
        public string? Password_Admin { get; set; }
        public string? Password_3D_Secure { get; set; }
        public string? Password_Dispositiva { get; set; }
        public string? Password_History { get; set; }
        public string? Sim_Serial { get; set; }
        public string? Sim_Operator { get; set; }
        public string? SmartPhone_Model { get; set; }
        public string? SmartPhone_Serial { get; set; }
        public string? SmartPhone_IMEI { get; set; }
        public string? SmartPhone_Supplier { get; set; }
        public string? Numero_Cliente { get; set; }
        public string? Iban { get; set; }
        public string? Numero_Carta { get; set; }
        public string? Data_Scadenza { get; set; }
        public string? Pin_App { get; set; }
        public string? Pin_Carta { get; set; }
        public string? Pin { get; set; }
        public string? Puk { get; set; }
        public string? Codice_Dispositivo { get; set; }
        public string? Codice_Sicurezza { get; set; }
        public string? Frase_Identificativa { get; set; }
        public string? Machine_IP { get; set; }
        public string? Machine_Name { get; set; }
        public string? Machine_Type { get; set; }
        public int UsageCount { get; set; } = 0;
        public DateTime? LastUsed { get; set; }
        public string? Note { get; set; }
        public DateTime? Expired_Date { get; set; }
        public bool Expired { get; set; } = false;
        public bool Active { get; set; } = true;
        public DateTime Modified { get; set; }
        public DateTime Created { get; set; }
    }
}