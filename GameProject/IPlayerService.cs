using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IPlayerService
    {
        public void Register(Player player);

        public void Update(Player player);

        public void Delete(Player player);
        
    }
}
