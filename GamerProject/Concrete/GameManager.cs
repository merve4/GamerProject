using GamerProject.Abstract;
using GamerProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Delete(Gameİnfo game)
        {
            Console.WriteLine(game.NameOfGame+" "+"has been deleted from the system");
        }

        public void Save(Gameİnfo game)
        {
            Console.WriteLine(game.NameOfGame + " " + "has been saved to the system");
        }

        public void Update(Gameİnfo game)
        {
            Console.WriteLine(game.NameOfGame + " " + "has been updated");
        }
    }
}
