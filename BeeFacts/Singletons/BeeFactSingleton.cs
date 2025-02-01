namespace BeeFacts.Singletons
{
    public class BeeFactSingleton : IBeeFactSingleton
    {
        private int? count = null;
        public int? getMaxCount()
        {
            return count;
        }
        public void setMaxCount(int newCount)
        {
            count = newCount;
        }
    }
}
