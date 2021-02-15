using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaign
    {
        public void AddCampaign(Order sales);
        public void UpdateCampaign(Order sales);
        public void DeleteCampaign(Order sales);
    }
}
