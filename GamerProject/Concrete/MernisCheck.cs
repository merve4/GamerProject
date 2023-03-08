using GamerProject.Abstract;
using GamerProject.Adapters;
using GamerProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Concrete
{
    public class MernisCheck:IPlayerCheckService
    {

        public bool CheckIfRealPlayer(Player player)
            {
            return true;

                
            }


        }
    }

