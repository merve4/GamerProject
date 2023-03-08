// See https://aka.ms/new-console-template for more information

using GamerProject.Abstract;
using GamerProject.Adapters;
using GamerProject.Concrete;
using GamerProject.Entity;

PlayerManager playerManager = new PlayerManager(new MernisServiceAdapter());
Player player1 = new Player();   
player1.Id = 1;
player1.FirstName = "Merve";
player1.LastName = "Rdd";
player1.YearOfBirth = 2000;
player1.NationalityId = "44189625126";
player1.NameInGame = "Mercnns";

playerManager.Save(player1);

Campaign campaign = new Campaign();
CampaignManager campaignManager = new CampaignManager();
campaign.CampaignName = "Sales Day";
campaign.DiscountAmount = 65;

campaignManager.Add(campaign);


GameManager gameManager = new GameManager();
Gameİnfo gameİnfo = new Gameİnfo();
gameİnfo.NameOfGame = "Gta VC";
gameİnfo.GamePrice = 123;
gameİnfo.GameCategory = "Stealing a car";
gameManager.Save(gameİnfo);

SalesManager salesManager = new SalesManager();
salesManager.Add(player1, gameİnfo, campaign);

Player player2 = new Player();
player2.Id = 2;
player2.FirstName = "Recep";
player2.YearOfBirth = 1999;
player2.NameInGame = "Scx11";

playerManager.Delete(player2);




