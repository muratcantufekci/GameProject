using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class ValidationManager : IValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.BirthYear == 1998)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
            
        
    }
}
