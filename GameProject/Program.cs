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

           
            
            Order order1 = new Order();
            order1.GameID = 1;
            order1.GameName = "Sims";
            order1.Price = 100;

            OrderManager orderManager = new OrderManager();
            orderManager.Sell(player1, order1);


            ICampaign campaign1 = new WelcomeCampaign();
            campaign1.AddCampaign(order1);
        }
    }
}
