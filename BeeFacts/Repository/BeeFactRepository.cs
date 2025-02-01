using BeeFacts.Data;
using BeeFacts.Models;
using BeeFacts.Singletons;

namespace BeeFacts.Repository
{
    public class BeeFactRepository : IBeeFactRepository
    {
        private readonly BeeFactContext _context;
        private readonly IBeeFactSingleton _beeFactSingleton;
        private readonly ILogger<IBeeFactRepository> _logger;

        public BeeFactRepository(ILogger<IBeeFactRepository> logger, BeeFactContext context, IBeeFactSingleton beeFactSingleton)
        {
            _context = context;
            _logger = logger;
            _beeFactSingleton = beeFactSingleton;
        }

        private int CountFacts()
        {
            var count = _beeFactSingleton.getMaxCount();
            if(count is null)
            {
                count = _context.BeeFacts.Count();
                _beeFactSingleton.setMaxCount(count ?? 0);
            }
            return count ?? 0;
        }

        public BeeFact GetRandomBeeFact()
        {
            var count = CountFacts();
            Random r = new Random();
            var randomId = r.Next(0, count);
            return _context.BeeFacts.Skip(randomId).FirstOrDefault() ?? new BeeFact();
        }
    }
}
