using System.Collections.Generic;

namespace CorporateWebsite.Models
{
    public class ContentModule
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<ModuleSection> Sections { get; set; }
    }
}
