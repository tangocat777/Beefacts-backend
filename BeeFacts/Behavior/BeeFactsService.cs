using BeeFacts.Models;
using BeeFacts.Repository;

namespace BeeFacts.Behavior
{
    public class BeeFactsService : IBeeFactsService
    {
        private IBeeFactRepository _repo;
        public BeeFactsService(IBeeFactRepository repo)
        {
            _repo = repo;
        }

        public BeeFact GetRandomBeeFact()
        {
            return _repo.GetRandomBeeFact();
        }
    }
}
