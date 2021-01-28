using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class PlayerManager : IPlayerManager
    {
        IUserValidationService _userValidationService;

        public PlayerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Player player)
        {
            if (_userValidationService.Validate(player)==true)
            {
                Console.WriteLine("Oyuncu eklendi : " + player.FirstName);
            }
            else Console.WriteLine("Kullanıcı gerçek değildir. Doğrulama başarısız" + player.FirstName);

        }
        public void Delete(Player player)
        {
            Console.WriteLine("Oyuncu silindi : " + player.FirstName);
        }
        public void Update(Player player)
        {
            Console.WriteLine("Oyuncu güncellendi : " + player.FirstName);
        }
    }
}
