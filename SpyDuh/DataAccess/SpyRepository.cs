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
            }
        };
    }
}
