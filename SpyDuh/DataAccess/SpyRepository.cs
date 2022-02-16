using SpyDuh.Models;

namespace SpyDuh.DataAccess
{
    public class SpyRepository
    {
        private static List<Spy> _spies = new List<Spy>()
        {
            new Spy()
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
                Relationship = SpyRelationship.Friend,
                DaysLeft = 20
            },
            new Spy()
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
                Relationship = SpyRelationship.Friend,
                DaysLeft = 1
            },
            new Spy()
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
                Relationship = SpyRelationship.Enemy,
                DaysLeft = 170
            },
        };

        internal object GetBySkill(string skill)
        {
            var matches = _spies.Where(s => s.SkillsAndServices.ContainsKey(skill));
            return matches;
        }

        internal object GetByName(string name)
        {
            var match = _spies.FirstOrDefault(s => s.CodeName == name);
            return match;
        }

        internal List<Spy> GetAll()
        {
            return _spies;
        }

        internal IEnumerable<Spy> GetRelationshipType(SpyRelationship spyRelationship)
        {
            var matchingRelationship = _spies.Where(relationship => relationship.Relationship == spyRelationship);
            return matchingRelationship;
        }

        internal void Post(Spy newSpy)
        {
            _spies.Add(newSpy);
        }

        internal object GetProfile(string name)
        {
            var match = _spies.FirstOrDefault(s => s.CodeName == name);
            var matchSkills = match.SkillsAndServices;
            return matchSkills;
        }

        internal object GetDaysLeft(string name)
        {
            var match = _spies.FirstOrDefault(s => s.CodeName == name);
            var matchDays = match.DaysLeft;
            return matchDays;
        }
    }
}