using SpyDuh.Models;

namespace SpyDuh.DataAccess
{
    public class SpyRepository
    {
        private static List<Spies> _spies = new List<Spies>()
        {
            new Spies()
            {
                CodeName = "Ivan",
                SkillsAndServices = new Dictionary<string, double>
                {
                    {
                        "Stealth",
                        1000.99
                    }
                },
                OriginStory = "From Soviet Era Russia",
                Relationship = SpyRelationship.Friend
            },
            new Spies()
            {
                CodeName = "Golden Eye",
                SkillsAndServices = new Dictionary<string, double>
                {
                    {
                        "Marksmenship",
                        15000.99
                    }
                },
                OriginStory = "Born by the bullet",
                Relationship = SpyRelationship.Friend
            },
            new Spies()
            {
                CodeName = "Mike",
                SkillsAndServices = new Dictionary<string, double>
                {
                    {
                        "Brute Force",
                        5000.99
                    }
                },
                OriginStory = "Born From A Mobster",
                Relationship = SpyRelationship.Enemy
            },
        };
    }
}
