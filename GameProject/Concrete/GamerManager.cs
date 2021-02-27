using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GamerManager : IGamerService
    {
        IValidationService _validationService;

        public GamerManager(IValidationService validationService)
        {
            _validationService = validationService;
        }

        public void Add(Gamer gamer)
        {
            if (_validationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt oldu " + gamer.Name);
            }
            else
            {
                Console.WriteLine("Kayıt başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Silindi " + gamer.Name);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu güncellendi " + gamer.Name);
        }
    }
}
