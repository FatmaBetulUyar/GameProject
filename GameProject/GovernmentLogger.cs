using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GovernmentLogger : ILoggerService
    {
       

        public void Log(Player player)
        {
            Console.WriteLine("Tc No :"+player.TcNo );
            Console.WriteLine("Ad :" + player.Name);
            Console.WriteLine("Soyad:" + player.Surname);
            Console.WriteLine("Dogum Yılı :" + player.BornDate);
            Console.WriteLine("E-devlet doğrulaması yapıldı");
        }
    }
}
