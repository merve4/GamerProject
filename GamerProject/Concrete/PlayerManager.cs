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
    public class PlayerManager : IPlayerService
    {
       public static Player player;

        public PlayerManager(MernisServiceAdapter mernisServiceAdapter)
        {
            MernisServiceAdapter = mernisServiceAdapter;
        }

        public MernisServiceAdapter MernisServiceAdapter { get; }

        public void Delete(Player player)
        {
            Console.WriteLine(player.NameInGame+" "+ "player has been deleted");
        }

        public virtual void  Save(Player player)
        {
            Console.WriteLine(player.NameInGame + " " + "player has been registered in the system.");
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.NameInGame + " " + "player has been updated");
        }

    }
}
