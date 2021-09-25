namespace Entities
{
    public interface IUserValidator
    {
        bool isEmailValid(string email);

        bool isNameValid(string name);
    }
}
