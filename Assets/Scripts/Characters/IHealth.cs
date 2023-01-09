namespace CloseCall.Interfaces
{
    public interface IHealth
    {
        void AddHealth(int damage);
        void RemoveHealth(int damage);
        int GetHealth();
    }
}
