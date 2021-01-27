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
            player.DateOfBirth="27.08.2000";
            player.NationalitiyId = "12345678910";

            PlayerManager playerManager = new PlayerManager();
            playerManager.Add(player);
        }
    }
}
