using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class PlayerManager : IPlayerManager
    {
        public void Add(Player player)
        {
            Console.WriteLine("Oyuncu eklendi : "+ player.FirstName);
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
