namespace CredentialsAPI.Models.Dtos
{
    public class CredentialFilterDto
    {
        public string? SearchTerm { get; set; }
        public bool? Active { get; set; }
        public bool? Expired { get; set; }
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string SortField { get; set; } = "Name";
        public bool SortAscending { get; set; } = true;
    }
}