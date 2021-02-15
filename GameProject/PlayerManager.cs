using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class PlayerManager:IPlayerService
    {
        IValidationService validationService;

        public PlayerManager(IValidationService validationService)
        {
            this.validationService = validationService;
        }

        public void Register(Player player)
        {
            if (validationService.Validation(player)==true)
            {
                 Console.WriteLine(player.Name+" Doğrulama başarılı. Sisteme kayıt olundu.");
            }
            else
            {
                Console.WriteLine(" Doğrulama başarısız.Sisteme kayıt olunamadı!");
            }
           
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
