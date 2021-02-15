using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class WelcomeCampaign : ICampaign
    {
        public void AddCampaign(Order sales)
        {
            Console.WriteLine("Yeni başlayan oyuncular için Welcome kampanyası eklendi.");
        }

        public void DeleteCampaign(Order sales)
        {
            Console.WriteLine("Welcome kampanyası güncellendi.");
        }

        public void UpdateCampaign(Order sales)
        {
            Console.WriteLine("Welcome kampanyası silindi");
        }
    }
}
