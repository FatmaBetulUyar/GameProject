using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class ValidationManager : IValidationService
    {
       

        public bool Validation(Player player)
        {
            if(player.TcNo==123456789 && player.Name=="betul" && player.BirthYear == 2000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
