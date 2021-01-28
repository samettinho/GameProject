using GameProject.Entities;
using GameProject.Abstract;
using GameProject.Concrete;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.FirstName = "Samet";
            player.LastName = "Yılmaz";
            player.DateOfBirth=2000;
            player.NationalitiyId = "12345";

            PlayerManager playerManager = new PlayerManager(new UserValidationManager());
            playerManager.Add(player);

            Game game = new Game();
            game.GameId = 1;
            game.GameName = "Footbal Manager 2021";
            game.Developer = "Sports Interactive";
            game.Price= 10;

            Game game1 = new Game()
            {
                GameId=2,
                GameName = "FİFA 2019",
                Developer = "EA SPORTS",
                Price = 10,
            };

            Order order = new Order()
            {
                Id = 1,
                GameId = 1,
                OrderPrice=1,
            };
            Campaign campaign1 = new Campaign()
            {
                Name = "Muhteşem cuma",
                Id = 1,
                DiscountRate = 40,

            };

            OrderManager orderManager = new OrderManager();
            CampaignManager campaignManager = new CampaignManager();
            GameManager gameManager = new GameManager();

            orderManager.Buy(order);
            orderManager.Delete(order);
            orderManager.Update(order);
            campaignManager.Add(campaign1);
            campaignManager.ApplyDiscount(campaign1, order);
            campaignManager.Delete(campaign1);
            gameManager.Update(game1);
            gameManager.Add(game1);
            gameManager.Delete(game1);
            
        }
    }
}
