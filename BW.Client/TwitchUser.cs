using Entities;
using System;

namespace BW
{
    public class TwitchUser : IUser<UserEntity>
    {

        IUserRepo<UserEntity> repository;
        IUserEmail emailService;
        IUserValidator validator;

        public TwitchUser(IUserRepo<UserEntity> repository,
            IUserEmail emailService,
            IUserValidator validator)
        {
            this.repository = repository;
            this.emailService = emailService;
            this.validator = validator;
        }
        public void add(UserEntity user) {
            if (isValidUser(user))
            {
                repository.add(user);
                emailService.sendCofirmation(user.Email);
            }
        }

        private bool isValidUser(UserEntity user)
        {
            return validator.isEmailValid(user.Email) &&
                validator.isNameValid(user.Name);
        }

        public UserEntity get(int id)
        {
            return repository.get(id);
        }

        public UserEntity getAll()
        {
            throw new NotImplementedException();
        }

        public void remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
