using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Player player1 = new Player();
            player1.Id = 1;
            player1.TcNo = 123456789;
            player1.Name = "betul";
            player1.Surname = "uyar";
            player1.BirthYear=2000;
            player1.City = "Kocaeli";
            player1.Level = 19;
            player1.Point = 85;
            player1.Mail = "bet@gmail.com";
            IValidationService loggerService = new ValidationManager();
            PlayerManager playerManager = new PlayerManager(loggerService);
           
            loggerService.Validation(player1);
            playerManager.Register(player1);
            playerManager.Update(player1);
            playerManager.Delete(player1);

           
            
            Order sale1 = new Order();
            sale1.GameID = 1;
            sale1.GameName = "Sims";
            sale1.Price = 100;

            OrderManager salesManager = new OrderManager();
            salesManager.Sell(player1, sale1);


            ICampaign campaign1 = new WelcomeCampaign();
            campaign1.AddCampaign(sale1);
        }
    }
}
