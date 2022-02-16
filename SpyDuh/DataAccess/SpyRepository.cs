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
                Relationship = SpyRelationship.Friend
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
                Relationship = SpyRelationship.Friend
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
                Relationship = SpyRelationship.Enemy
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

        internal object GetFriendsOfFriends(string name, SpyRelationship spyRelationship)
        {
            var matchingSpy = _spies.FirstOrDefault(s => s.CodeName == name);
            var friends = _spies.Where(matchingSpy => matchingSpy.Relationship == spyRelationship);
            var friendsOrEnemies = friends.Where(s => s.CodeName != name);
            return friendsOrEnemies;
        }
    }
}