using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    { 
        public bool Validate(Gamer gamer)
        {
            if(gamer.BirthYear==1985 && gamer.FirstName=="GOKHAN"
                &&gamer.LastName =="OZDEMIR" && gamer.IdentityNumber==1111)
            {
                return true;

            }
            else
            {
                return false;

            }
        }
    }
}
