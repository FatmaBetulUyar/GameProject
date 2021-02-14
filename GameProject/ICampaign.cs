using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaign
    {
        public void AddCampaign(Sales sales);
        public void UpdateCampaign(Sales sales);
        public void DeleteCampaign(Sales sales);
    }
}
