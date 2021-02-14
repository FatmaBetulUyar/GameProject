using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class WelcomeCampaign : ICampaign
    {
        public void AddCampaign(Sales sales)
        {
            Console.WriteLine("Yeni başlayan oyuncular için Welcome kampanyası eklendi.");
        }

        public void DeleteCampaign(Sales sales)
        {
            Console.WriteLine("Welcome kampanyası güncellendi.");
        }

        public void UpdateCampaign(Sales sales)
        {
            Console.WriteLine("Welcome kampanyası silindi");
        }
    }
}
