namespace SpyDuh.Models
{
    public class Spies
    {
        public string CodeName { get; set; }
        public Dictionary<string, double> SkillsAndServices { get; set; }
        public string OriginStory { get; set; }
        public bool Enemy { get; set; }
    }
}