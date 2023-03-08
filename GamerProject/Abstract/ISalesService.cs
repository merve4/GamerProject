using GamerProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Abstract
{
    public interface ISalesService
    {
        void Add(Player player,Gameİnfo gameİnfo,Campaign campaign);
    }
}
