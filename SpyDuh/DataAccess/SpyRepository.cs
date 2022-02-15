using SpyDuh.Models;

namespace SpyDuh.DataAccess
{
    public class SpyRepository
    {
        private static List<Spies> _spies = new List<Spies>()
        {
            new Spy()
            {
                CodeName = "albert",
                OriginStory = "revenge",
            }
        };

        internal object GetByName(string name)
        {
            var match = _spies.FirstOrDefault(s => s.CodeName == name);
            return match;
        }

        internal List<Spy> GetAll()
        {
            return _spies;
        }
    }
}
