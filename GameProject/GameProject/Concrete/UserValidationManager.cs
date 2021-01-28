using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Player player)
        {
            if (player.FirstName == "SAMET" && player.LastName == "YILMAZ" && player.NationalitiyId == "12345" && player.DateOfBirth == 2000)
            {
                return true;
            }
            else return false;
        }
    }
}
