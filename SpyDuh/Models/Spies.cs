namespace SpyDuh.Models
{
    public class Spy
    {
        public string CodeName { get; set; }
        public Dictionary<string, double> SkillsAndServices { get; set; }
        public string OriginStory { get; set; }
        public SpyRelationship Relationship { get; set; }
    }

    public enum SpyRelationship
    {
        Friend,
        Enemy
    }
}