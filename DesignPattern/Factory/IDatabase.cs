
namespace DesignPattern.Factory
{
    public interface IDatabase
    {
        void Connect();
        void ExecuteQuery(string query);
    }
}
