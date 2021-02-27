using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface ISellServise
    {
        void GameSell(Game game,Gamer gamer);
        void CampaignGameSell(Game game, Gamer gamer,Campaign campaign);
    }
}
