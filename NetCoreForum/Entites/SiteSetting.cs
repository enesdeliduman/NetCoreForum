﻿namespace NetCoreForum.Entites
{
    public class SiteSetting
    {
        public int SiteSettingID { get; set; }
        public string SiteName { get; set; }
        public string LogoPath { get; set; }
        public string FaviconPath { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public string FooterText { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}