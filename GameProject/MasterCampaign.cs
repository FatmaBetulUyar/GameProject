using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class MasterCampaign : ICampaign
    {
        public void AddCampaign(Order sales)
        {
            Console.WriteLine("1000 puana gelen oyuncular için Master kampanyası eklendi.");
        }
        public void DeleteCampaign(Order sales)
        {
            Console.WriteLine("Master kampanyası güncellendi.");
        }
        public void UpdateCampaign(Order sale)
        {
            Console.WriteLine("Master kampanyası silindi");
        }
    }
}
