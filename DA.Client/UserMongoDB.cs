using Entities;

namespace DA
{
    public class UserMongoDB : IUserRepo<UserEntity>
    {
        public void add(UserEntity user)
        {
            // Se realiza conexion con MongoDB y
            // se guarda el cliente
        }

        public UserEntity get(int id)
        {
            var client = new UserEntity()
            {
                Email = "MongoDB",
                ID = 1,
                Name = "Steven"
            };
            return client;
        }

        public UserEntity getAll()
        {
            throw new System.NotImplementedException();
        }

        public void remove(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
