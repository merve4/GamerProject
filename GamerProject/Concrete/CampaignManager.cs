using GamerProject.Abstract;
using GamerProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+" "+"campaign started"+" "+"%"+campaign.DiscountAmount+" "+"discount!");
        }

        public void Remove(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + "campaign is over");
        }
    }
}
