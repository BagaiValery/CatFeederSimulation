using Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    interface ICatService
    {
        void Eat(Feeder feeder);
        void Meow(/*Feeder*/);
    }
}
