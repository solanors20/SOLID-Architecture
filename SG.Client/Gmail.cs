using System;
using Entities;

namespace SG
{
    public class Gmail : IUserEmail
    {
        public void sendCofirmation(string email)
        {
            // Aqui se llama la API de Gmail para
            // enviar un correo de confirmacion
        }

        public void sendPasswordReset(string email)
        {
            throw new NotImplementedException();
        }
    }
}
