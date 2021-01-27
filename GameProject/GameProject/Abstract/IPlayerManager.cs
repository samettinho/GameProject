using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IPlayerManager
    {
        public void Add(Player player);
        public void Delete(Player player);
        public void Update(Player player);

    }
}
