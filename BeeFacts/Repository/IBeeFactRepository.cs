using BeeFacts.Models;

namespace BeeFacts.Repository
{
    public interface IBeeFactRepository
    {
        BeeFact GetRandomBeeFact();
        Suggestion UpsertSuggestion(Suggestion suggestion);
    }
}
