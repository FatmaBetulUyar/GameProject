using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class PlayerManager
    {
        public void Register(Player player)
        {
            Console.WriteLine(player.Name+" Sisteme kayıt olundu.");
        }
        public void Update(Player player)
        {
             Console.WriteLine(player.Name + " Bilgiler güncellendi.");
        }
        public void Delete(Player player)
        {
        Console.WriteLine(player.Name + " Silme işlemi gerçekleşti.");
        }
    }
    
}
