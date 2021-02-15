using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OrderManager
    {
        public void Sell(Player player,Order order)
        {
            Console.WriteLine(order.GameName+" oyunu "+player.Id+ " ID'li oyuncuya "+order.Price+" tl'ye satıldı.");
        }
    }
}
