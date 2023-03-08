using GamerProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Abstract
{
    public interface IGameService
    {
        void Save(Gameİnfo game);
        void Delete(Gameİnfo game);
        void Update(Gameİnfo game);
    }
}
