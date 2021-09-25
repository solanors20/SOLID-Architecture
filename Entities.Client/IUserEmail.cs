
namespace Entities
{
    public interface IUserEmail
    {
        void sendCofirmation(string email);

        void sendPasswordReset(string email);
    }
}
