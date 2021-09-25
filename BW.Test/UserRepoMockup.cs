using Entities;
using System;

namespace BW.Test
{
    public class UserRepoMockup : IUserRepo<UserEntity>
    {
        public void add(UserEntity client)
        {
            
        }

        public UserEntity get(int id)
        {
            return new UserEntity()
            {
                ID = id,
                Name = "Carlos",
                Email = "carlos@gmail.com"
            };
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
