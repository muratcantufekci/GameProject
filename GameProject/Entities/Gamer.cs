using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    class Gamer:IEntity
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int BirthYear { get; set; }

        public string NationalytyId { get; set; }
    }
}
