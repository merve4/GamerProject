using GamerProject.Abstract;
using GamerProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Add(Player player, Gameİnfo gameİnfo, Campaign campaign)
        {
            double discountedAmount = (gameİnfo.GamePrice * campaign.DiscountAmount) / 100;
            discountedAmount = gameİnfo.GamePrice - discountedAmount;

            Console.WriteLine("Discount applied!");
            Console.WriteLine("Player Name:" + " " + player.FirstName);
            Console.WriteLine("Name/Surname:" + " " + player.FirstName + " " + player.LastName);
            Console.WriteLine("Amount Without Discount: "+gameİnfo.GamePrice+"$");
            Console.WriteLine("Game to buy:" + gameİnfo.NameOfGame + " , " + "Total Price:" + " " + discountedAmount);
        }
    }
}
