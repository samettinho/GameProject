using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Ürun başarıyla eklendi. Eklenen ürün : "+ game.GameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Ürun başarıyla silindi. Silinen ürün : " + game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Ürun başarıyla güncellendi. Güncellenen ürün : " + game.GameName);
        }
    }
}
