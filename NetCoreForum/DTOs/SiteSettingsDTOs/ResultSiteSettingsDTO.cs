namespace NetCoreForum.DTOs.SiteSettingsDTOs
{
    public class ResultSiteSettingsDto
    {
        public int SiteSettingsID { get; set; }
        public string SiteName { get; set; }
        public string LogoPath { get; set; }
        public string FaviconPath { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public string FooterText { get; set; }
        public int MaxWarningCountForAppUser { get; set; }
        public bool RequireAdminApproval { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
