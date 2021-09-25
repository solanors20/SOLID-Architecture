using Entities;
using System;

namespace DA
{
    public class UserSQLServer : IUserRepo<UserEntity>
    {
        public void add(UserEntity user)
        {
            // Se realiza conexion con BD y
            // se guarda el cliente
        }

        public UserEntity get(int id)
        {
            var client = new UserEntity()
            {
                Email = "SQLServer",
                ID = 1,
                Name = "Steven"
            };
            return client;
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
