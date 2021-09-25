
namespace Entities
{
    public interface IUser<T>
    {
        void add(T user);

        void remove(int id);

        T get(int id);

        T getAll();
    }
}
