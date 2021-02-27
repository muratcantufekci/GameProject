using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class SellManager : ISellServise
    {
        public void CampaignGameSell(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(game.GameName + " adlı oyun " + campaign.CampaignName + " kampanyasıyla " + "% " + campaign.Discount + " indirim ile " + gamer.Name + " adlı kişiye satılmıştır");
        }

        public void GameSell(Game game, Gamer gamer)
        {
            Console.WriteLine(game.GameName+" adlı oyun "+ gamer.Name+" adlı kişiye başarı ile satılmıştır");
        }

    }
}
