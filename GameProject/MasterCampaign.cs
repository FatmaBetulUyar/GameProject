using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class MasterCampaign : ICampaign
    {
        public void AddCampaign(Sales sales)
        {
            Console.WriteLine("1000 puana gelen oyuncular için Master kampanyası eklendi.");
        }
        public void DeleteCampaign(Sales sales)
        {
            Console.WriteLine("Master kampanyası güncellendi.");
        }
        public void UpdateCampaign(Sales sale)
        {
            Console.WriteLine("Master kampanyası silindi");
        }
    }
}
