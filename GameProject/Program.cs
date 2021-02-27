using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oyuncu Ekleme
            Gamer gamer = new Gamer();
            gamer.ID = 1;
            gamer.Name = "Muratcan";
            gamer.Surname = "Tüfekçi";
            gamer.BirthYear = 1998;
            gamer.NationalytyId = "123456789";

            //Oyun Ekleme
            Game game = new Game();
            game.Id = 1;
            game.GameName = "Watch Dogs 2";
            game.GamePrice = 200;

            //Kampanya Ekleme
            Campaign campaign = new Campaign();
            campaign.Id = 1;
            campaign.CampaignName = "Öğrenci indirimi";
            campaign.Discount = 20;

            GamerManager gamerManager = new GamerManager(new ValidationManager());
            gamerManager.Add(gamer);
            gamerManager.Delete(gamer);
            gamerManager.Update(gamer);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            campaignManager.Delete(campaign);
            campaignManager.Update(campaign);

            SellManager sellManager = new SellManager();
            sellManager.GameSell(game,gamer);

            SellManager campaingSellManager = new SellManager();
            campaingSellManager.CampaignGameSell(game,gamer,campaign);

            Console.ReadKey();
        }
    }
}
