using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    class Game : IEntitiy
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public string Developer { get; set; }
        public int Price { get; set; }
    }
}
