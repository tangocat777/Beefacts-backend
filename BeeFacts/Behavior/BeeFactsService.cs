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

        public Suggestion CreateBeeFactSuggestion(Suggestion suggestion)
        {
            return _repo.UpsertSuggestion(suggestion);
        }
    }
}
