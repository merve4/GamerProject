using GamerProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Remove(Campaign campaign); 
    }
}
