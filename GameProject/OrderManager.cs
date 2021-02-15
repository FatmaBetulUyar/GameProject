using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OrderManager
    {
        public void Sell(Player player,Order sales)
        {
            Console.WriteLine(sales.GameName+" oyunu "+player.Id+ " ID'li oyuncuya "+sales.Price+" tl'ye satıldı.");
        }
    }
}
