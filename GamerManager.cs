using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService

       IUserValidationService _userValidationService;

    {
        private object _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayit oldu");
            }
            else
            {
                Console.WriteLine("Dogrulama basarisiz. Kayit basarisiz");

            }
        }

     
        }
    }
}
