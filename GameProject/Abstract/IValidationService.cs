using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IValidationService
    {
       bool Validate(Gamer gamer);
    }
}
