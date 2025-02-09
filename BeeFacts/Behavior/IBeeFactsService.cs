using BeeFacts.Models;

namespace BeeFacts.Behavior
{
    public interface IBeeFactsService
    {
        public BeeFact GetRandomBeeFact();
        public Suggestion CreateBeeFactSuggestion(Suggestion suggestion);
    }
}
