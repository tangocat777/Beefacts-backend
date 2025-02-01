using BeeFacts.Models;

namespace BeeFacts.Repository
{
    public interface IBeeFactRepository
    {
        BeeFact GetRandomBeeFact();
    }
}
